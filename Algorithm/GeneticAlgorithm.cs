using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Dto;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Algorithm
{
    public class GeneticAlgorithm
    {

        public Data Data { get; set; }

        public GeneticAlgorithm(Data data)
        {
            Data = data;
        }

        public const int POPULATION_SIZE = 9; // 9 quần thể
        public const double MUTATION_RATE = 0.1; // tỷ lệ đột biến
        public const double CROSSOVER_RATE = 0.9; // tỷ lệ lai ghép
        public const int TOURNAMENT_SELECTION_SIZE = 3;
        public const int NUMBER_OF_ELIT_SCHEDULE = 1; // số cá thể ưu tú
        public const int MAX_GENERATIONS = 1000; // Giới hạn số thế hệ

        public int NumberSchedule { get; set; } = 0;
        public int NumberClass { get; set; } = 1;

        public Population Evolve(Population population)
        {
            return MutationPopulation(CrossoverPopulation(population));
        }

        // Đột biến quần thể
        Population MutationPopulation(Population parents)
        {
            Population mutationPopulation = new Population(parents.Schedules.Count(), Data);
            Population sortFitnessParents = parents.SortByFitness();
            for (int i = 0; i < NUMBER_OF_ELIT_SCHEDULE; i++)
            {
                mutationPopulation.Schedules[i] = sortFitnessParents.Schedules[i]; // Giữ lại các cá thể ưu tú => tăng tốc độ hội tụ
            }

            for (int i = NUMBER_OF_ELIT_SCHEDULE; i < sortFitnessParents.Schedules.Count(); i++)
            {
                mutationPopulation.Schedules[i] = MutationSchedule(sortFitnessParents.Schedules[i]);
            }
            return mutationPopulation;
        }


        // Đột biến cá thể
        ScheduleDto MutationSchedule(ScheduleDto mutationSchedule)
        {
            ScheduleDto schedule = new ScheduleDto(Data);
            for (int i = 0; i < mutationSchedule.Classes.Count(); i++)
            {
                if (MUTATION_RATE > new Random().NextDouble())
                {
                    mutationSchedule.Classes[i] = schedule.Classes[i];
                }
            }
            return mutationSchedule;
        }

        // Lai ghép quần thể
        Population CrossoverPopulation(Population parents)
        {
            Population crossoverPopulation = new Population(parents.Schedules.Count(), Data);
            Population sortFitnessParents = parents.SortByFitness();
            for (int i = 0; i < NUMBER_OF_ELIT_SCHEDULE; i++)
            {
                crossoverPopulation.Schedules[i] = sortFitnessParents.Schedules[i]; // Giữ lại các cá thể ưu tú => tăng tốc độ hội tụ
            }

            for (int i = NUMBER_OF_ELIT_SCHEDULE; i < sortFitnessParents.Schedules.Count(); i++)
            {
                if (CROSSOVER_RATE > new Random().NextDouble())
                {
                    ScheduleDto schedule1 = selectRandomTournament(sortFitnessParents).SortByFitness().Schedules[0];
                    ScheduleDto schedule2 = selectRandomTournament(sortFitnessParents).SortByFitness().Schedules[0];
                    crossoverPopulation.Schedules[i] = CrossoverSchedule(schedule1, schedule2);
                }
                else
                {
                    crossoverPopulation.Schedules[i] = sortFitnessParents.Schedules[i];
                }
            }
            return crossoverPopulation;
        }

        // Lai ghép cá thể
        ScheduleDto CrossoverSchedule(ScheduleDto schedule1, ScheduleDto schedule2)
        {
            ScheduleDto child = new ScheduleDto(Data);
            for (int i = 0; i < child.Classes.Count(); i++)
            {
                if (new Random().NextDouble() > 0.5)
                {
                    child.Classes[i] = schedule1.Classes[i];
                }
                else
                {
                    child.Classes[i] = schedule2.Classes[i];
                }
            }
            return child;
        }

        // Chọn lọc một nhóm cá thể trước khi lai ghép
        Population selectRandomTournament(Population parents)
        {
            Population tournamentPopulation = new Population(TOURNAMENT_SELECTION_SIZE, Data);
            for (int i = 0; i < TOURNAMENT_SELECTION_SIZE; i++)
            {
                tournamentPopulation.Schedules[i] = parents.Schedules[new Random().Next(parents.Schedules.Count())];
            }
            return tournamentPopulation;
        }
    }
}
