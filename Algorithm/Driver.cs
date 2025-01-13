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
    public class Driver
    {
        public static ScheduleDto CreateSchedule()
        {
            ScheduleDto schedule = new ScheduleDto();
            try
            {
                Data data = new Data();
                if (data == null)
                {
                    MessageBox.Show("Bộ dữ liệu chưa đầy đủ, yêu cầu bổ sung dữ liệu!");
                }

                GeneticAlgorithm geneticAlgorithm = new GeneticAlgorithm(data);
                Population population = new Population(GeneticAlgorithm.POPULATION_SIZE, data).SortByFitness();
                int numberGenerations = 1;
                while(population.Schedules.First().Fitness != 1 && numberGenerations < GeneticAlgorithm.MAX_GENERATIONS)
                {
                    population = geneticAlgorithm.Evolve(population).SortByFitness();
                    numberGenerations++;
                }

                schedule = population.Schedules.First();
                if (schedule.Fitness != 1)
                {
                    MessageBox.Show("Tạo thời khóa biểu thất bại! Hãy kiểm tra lại bộ dữ liệu!");
                    return null;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return schedule;
        }
    } 
}
