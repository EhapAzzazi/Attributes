using System.Collections.Generic;
using System.Reflection;

namespace Assembilies
{
    class Players
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [Skill(nameof(BallControl), 1, 85)]
        public int BallControl { get; set; } // not above 85 

        [Skill(nameof(Dribbling), 1, 90)]
        public int Dribbling { get; set; } // not above 90

        [Skill(nameof(Power), 1, 95)]
        public int Power { get; set; } // not above 95

        [Skill(nameof(Speed), 1, 95)]
        public int Speed { get; set; } // not above 95

        /// <summary>
        /// Used only inside CheckingPowers(List<Players> players) Method so u can print the Errors using PrintingErrors().
        /// </summary>
        public static List<Errors> errors = new List<Errors>();

        public static void CheckingPowers(List<Players> players)
        {
            foreach (var player in players)
            {
                PropertyInfo[] properties = player.GetType().GetProperties();

                foreach (PropertyInfo prop in properties)
                {
                    SkillAttribute skillattr = prop.GetCustomAttribute<SkillAttribute>(); // to get only the methods which has [SkillAttribute] Above it of class Players.
                    if (skillattr is not null)
                    {
                        int value = (int)prop.GetValue(player);
                        if (!skillattr.IsValid(value))
                        {
                            errors.Add(new Errors(prop.Name, $"Invalid Value {value} Accepted Range {skillattr.Minimum} - {skillattr.Maximum} of {player.Name}"));
                        }
                    }
                }
            }
            //if (errors.Count > 0)
            //{
            //    foreach (var e in errors)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Info is valid.");
            //}
        }

    }
}
