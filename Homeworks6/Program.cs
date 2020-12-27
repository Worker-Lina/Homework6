using System;
using MyClassLib.WordOfTanks;

namespace Homeworks6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int countOfTanks = 5;
            var t34 = new Tank[countOfTanks];
            var pantera = new Tank[countOfTanks];

            try
            {

                for (int i = 0; i < t34.Length; i++)
                {
                    t34[i] = new Tank("T34", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
                    pantera[i] = new Tank("Pantera", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            try
            {
                for (int i = 0; i < countOfTanks; i++)
                {
                    Console.WriteLine($"\tБоекомплект | Броня | Маневренность\n" +
                        $" T34\t{t34[i].GetAllowanceOfAmmunition()}\t    | {t34[i].GetArmor()}    | {t34[i].GetManeuverability()}\n" +
                        $" Pant\t{pantera[i].GetAllowanceOfAmmunition()}\t    | { pantera[i].GetArmor()}    | { pantera[i].GetManeuverability()}");

                    string winner = t34[i] * pantera[i];
                    if (winner == "ничья")
                    {
                        Console.WriteLine("Ничья");
                    }
                    else
                    {
                        Console.WriteLine($"\nВ {i + 1} схватке победил танк {winner}");
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine();
                }
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
           
        }
    }
}
