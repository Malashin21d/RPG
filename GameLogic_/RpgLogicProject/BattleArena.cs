using System;
namespace RpgLogicProject
{

    public class BattleArena
    {
        public Enemy Enemy { get; set; }
        public Hero Hero { get; set; }




        public BattleArena(Enemy enemy, Hero hero)
        {
            Enemy = enemy;
            Hero = hero;

        }



        public int Battle()
        {
            Random rand = new Random();
            int Chance;
            var Enemy = new Enemy("Гоблин", 1, 70, 5);
        start:
            Console.WriteLine("1 - Напасть 2 - Прокрасться");
            int ans = int.Parse(Console.ReadLine());
            if (ans == 1)
            {
                Console.WriteLine("Отравить клинок? 1 - Да 2 - нет");
                int ansa = int.Parse(Console.ReadLine());
                if (ansa == 1)
                {
                    do
                    {
                    restart:
                        Console.WriteLine();
                        Console.WriteLine($"Героя здоровье: {Math.Round(Hero.Hp, 0)}");
                        Console.WriteLine($"Здоровье противника: {Math.Round(Enemy.Hp, 0)}");
                        Chance = rand.Next(0, 3);
                        if (Chance == 0)
                        {
                            Console.WriteLine($"Вы нанесли урона противнику: {Math.Round(Hero.Damage, 1)}");
                            Enemy.Hp -= (Hero.Damage);
                            Console.WriteLine($"Вы получили урон: {Math.Round(Enemy.Damage, 1)}");
                            Hero.Hp -= Enemy.Damage;
                            if (Enemy.Hp <= 0)
                            {
                                Console.WriteLine("Вы победили врага!");
                                return 1;

                            }
                        }
                        else if (Chance == 1)
                        {
                            Console.WriteLine($"Вы нанесли крит противнику: {Math.Round(1.5 * (Hero.Damage), 1)}");
                            Enemy.Hp -= (Hero.Damage);
                            Console.WriteLine($"Вы получили урон: {Math.Round(Enemy.Damage, 1)}");
                            Hero.Hp -= Enemy.Damage;
                            if (Enemy.Hp <= 0)
                            {
                                Console.WriteLine("Вы победили врага!");
                                return 1;
                            }
                            else if (Chance == 2)
                            {
                                Console.WriteLine($"Вы застанили врага противнику: {Math.Round(1.5 * (Hero.Damage), 1)}");
                                Enemy.Hp -= (Hero.Damage);
                                if (Enemy.Hp <= 0)
                                {
                                    Console.WriteLine("Вы победили врага!");
                                    return 1;

                                }
                            }

                            if (Hero.Hp <= 0)
                            {
                                Console.WriteLine("Вы погибли!");
                                return 0;
                            }
                            else { goto restart; }
                        }
                        while (Enemy.Hp > 0 && Hero.Hp > 0) ;
                        }


                    
                    else if (ansa ==2)
                    {
                    do
                    {
                    restart:
                            Console.WriteLine($"Вы нанесли крит противнику: {Math.Round(1.5 * (Hero.Damage), 1)}");
                            Enemy.Hp -= (Hero.Damage);
                            Console.WriteLine($"Вы получили урон: {Math.Round(Enemy.Damage, 1)}");
                            Hero.Hp -= Enemy.Damage;
                            if (Enemy.Hp <= 0)
                            {
                                Console.WriteLine("Вы победили врага!");
                                return 1;
                            }
                            else if (Chance == 2)
                            {
                                Console.WriteLine($"Вы застанили врага противнику: {Math.Round(1.5 * (Hero.Damage), 1)}");
                                Enemy.Hp -= (Hero.Damage);
                                if (Enemy.Hp <= 0)
                                {
                                    Console.WriteLine("Вы победили врага!");
                                    return 1;

                                }
                            }

                            if (Hero.Hp <= 0)
                            {
                                Console.WriteLine("Вы погибли!");
                                return 0;
                            }
                            else { goto restart; }
                        }
                        while (Enemy.Hp > 0 && Hero.Hp > 0);
                    }

                }
                else if (ans == 2)
                {
                    Chance = rand.Next(0, 2);
                    if (Chance == 0)
                    {
                        Console.WriteLine("Вы прокрались мимо противника, и продолжили свой путь.");
                        goto start;


                    }
                    else if (Chance == 1)
                    {
                        Console.WriteLine(Chance);
                        Console.WriteLine("Противник обнаружил Вас. Введите 1 чтоб начать битву");
                        ans = int.Parse(Console.ReadLine());
                        if (ans == 1)
                        {
                            do
                            {
                            restart:
                                Console.WriteLine($"Вы нанесли крит противнику: {Math.Round(1.5 * (Hero.Damage), 1)}");
                                Enemy.Hp -= (Hero.Damage);
                                Console.WriteLine($"Вы получили урон: {Math.Round(Enemy.Damage, 1)}");
                                Hero.Hp -= Enemy.Damage;
                                if (Enemy.Hp <= 0)
                                {
                                    Console.WriteLine("Вы победили врага!");
                                    return 1;
                                }
                                else if (Chance == 2)
                                {
                                    Console.WriteLine($"Вы застанили врага противнику: {Math.Round(1.5 * (Hero.Damage), 1)}");
                                    Enemy.Hp -= (Hero.Damage);
                                    if (Enemy.Hp <= 0)
                                    {
                                        Console.WriteLine("Вы победили врага!");
                                        return 1;

                                    }
                                }

                                if (Hero.Hp <= 0)
                                {
                                    Console.WriteLine("Вы погибли!");
                                    return 0;
                                }
                                else { goto restart; }
                            }
                            while (Enemy.Hp > 0 && Hero.Hp > 0);

                        }

                        else
                        {
                            goto start;
                        }
                    }
                    else
                    {
                        Console.WriteLine(Chance);
                        goto start;
                    }
                }
            }
        }
    }
}





