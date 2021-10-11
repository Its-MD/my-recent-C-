using System;

namespace Game
{
    public enum TypeOfCharacter
    {
        None,
        Archer,
        Warrior,
        Magician
    }
    // Enumerations represent a collection of logically related constants. An enumeration is declared using the enum operator.
    //each element of the enumeration is assigned an integer value, with the first element being 0, the second 1, and so on.
    /* enum Days
        {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
        }
    */
    public enum Bonus
    {
        None,
        Life,
        Damage,
        Luck
    }

    class Program
    {
        static void Main(string[] args)
        {
            // string type = "";
            TypeOfCharacter type = TypeOfCharacter.None;
            int choiceType;
            // string bonus = "";
            Bonus bonus = Bonus.None;
            int choiceBonus;
            int hp = 100, damage = 30, luck = 30;
            string[] bonusNames = {"Unknown", "More health", "More damage", "More luck"};
            Console.Write("Set your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Your name is {playerName}");
            while ( type == TypeOfCharacter.None)
            { 
            Console.WriteLine("Type your type: 1. Archer 2. Magician 3. Warrior");
            choiceType = int.Parse(Console.ReadLine());
            switch (choiceType)
            {

                case 1:
                    type = TypeOfCharacter.Archer;
                    break;

                case 2:
                    type = TypeOfCharacter.Magician;
                    break;

                case 3:
                    type = TypeOfCharacter.Warrior;
                        break;

                default:
                    type = TypeOfCharacter.None;
                    Console.WriteLine("Oops, you typed an invalid number, try again");
                    break;
            }
                // switch construct allows you to simplify code that returns some value
                // The switch / case construction is similar to the if / else construction, since it allows you to process several conditions at once
            }
            Console.WriteLine($"Your type is {type}");
            while (bonus == Bonus.None)
            {
                Console.WriteLine(" 1. More health 2. More damage 3. More luck");
                // Console.WriteLine($"--(1 - {bonusNames[(int)Bonus.Life]}");
                choiceBonus = int.Parse(Console.ReadLine());
                switch (choiceBonus)
                {
                    case 1:
                        bonus = Bonus.Life;
                        hp = hp * 2;
                        break;

                    case 2:
                        bonus = Bonus.Damage;
                        damage = damage * 2;
                        break;

                    case 3:
                        bonus = Bonus.Luck;
                        luck = luck * 2;
                        break;

                    default:
                        bonus = Bonus.None;
                        Console.WriteLine("Oops, you typed an invalid number, try again");
                        break;
                }
            }
            Console.WriteLine($"Your bonus is {bonus}");
            Random r = new Random();
            // random number generator
            int days = 1;
            while (days <= 5)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("--(1 -Walk, 2 -Talk, 3 -Rest, 4 -Finish Day)--");
                    Console.Write("Choose your action: ");
                    int typeOfAction = int.Parse(Console.ReadLine());
                    if (typeOfAction == 1)
                    {
                        Console.WriteLine($"{playerName} went somewhere.");
                        for (int j = 1; j < 6; j++)
                        {
                            int km = r.Next(1, 10);
                            Console.WriteLine($"{playerName} went  {km} km.");
                        }
                    }
                    else if (typeOfAction == 2)
                    {
                        Console.WriteLine($"{playerName} is talking to someone.");
                        for (int clockCounter = 1; clockCounter < 4; clockCounter++)
                        {
                            int time = r.Next(1, 10);
                            Console.WriteLine($"{playerName} has talked to someone for {time} hours.");
                        }
                    }
                    else if (typeOfAction == 3)
                    {
                        Console.WriteLine($"{playerName} has went to nap for a bit.");
                    }
                    else if (typeOfAction == 4)
                    {
                        Console.WriteLine($"{playerName} has went to sleep.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please try again.");
                    }
                }
                Console.WriteLine($"{playerName} finished {days} in-game days");
                Console.WriteLine("Continue (Enter) or exit (0)?");
                if (Console.ReadLine()== "0")
                {
                    break;
                }
                days = days + 1;
            }
            

        }
    }
}
