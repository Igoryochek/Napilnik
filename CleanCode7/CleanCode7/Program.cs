using System;

namespace CleanCode7
{
    class Program
    {
        private static int chance;
        private static int hourlyRate;

        static void Main(string[] args)
        {


            static void SpawnUnit()
            {
                //Создание объекта на карте
            }

            static void SetChance()
            {
                Random random = new Random();
                chance = random.Next(0, 100);
            }

            static int SetSalary(int hoursWorked)
            {
                return hourlyRate * hoursWorked;
            }
        }
    }
}
