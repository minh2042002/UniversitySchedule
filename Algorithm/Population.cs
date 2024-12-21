using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Dto;

namespace UniversitySchedule.Algorithm
{
    public class Population
    {
        public List<ScheduleDto> Schedules { get; set; }

        public Population(int size, Data data)
        {
            Schedules = new List<ScheduleDto>(size);
            for (int i = 0; i < size; i++)
            {
                Schedules.Add(new ScheduleDto(data));
            }
        }

        public Population SortByFitness()
        {
            Schedules.Sort((s1, s2) =>
            {
                int returnValue = 0;
                if (s1.Fitness > s2.Fitness) returnValue = -1;
                else returnValue = 1;
                return returnValue;
            });
            return this;
        }
    }
}
