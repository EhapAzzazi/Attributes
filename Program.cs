using System;
using System.Collections.Generic;

namespace Assembilies
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class Updates Usage 'Comments'
            /*
            Updates[] updates = { 
            new Updates(1, "Security Update"),
            new Updates(2, "UI Enhancements"),
            new Updates(3, "Bug Fixes Update"),
            new Updates(4, "Security Update")
            };

            UpdateProcessor.Download(updates);
            UpdateProcessor.Install(updates);

            Console.WriteLine("-----------------------");

            UpdateProcessor.DownloadAndInstall(updates);
           */
            #endregion


            List<Players> players = new List<Players>()
            {
                new Players() { Name = "Messi", Description="RW", BallControl = 80, Dribbling= 90, Power= 95, Speed = 85},
                new Players() { Name = "Mpabbe", Description="CF", BallControl = 70, Dribbling= 80, Power= 100, Speed = 95},
                new Players() { Name = "CR7", Description="CF", BallControl = 85, Dribbling= 92, Power= 93, Speed = 86},
                new Players() { Name = "Mo Salah", Description="RWF", BallControl = 80, Dribbling= 80, Power= 89, Speed = 100},
                new Players() { Name = "L.Sane", Description="RWF", BallControl = 83, Dribbling= 82, Power= 88, Speed = 87},
                new Players() { Name = "Sergio Ramos", Description="CB", BallControl = 100, Dribbling= 100, Power= 100, Speed = 100}
            };
            Players.CheckingPowers(players);
            Errors.PrintingErrors();

            // Both of CheckingPowers, PrintingErrors Usage before making them as methods.
            #region Comments
            //List<Errors> errors = new List<Errors>();

            //foreach(var player in players)
            //{
            //    var properties = player.GetType().GetProperties();

            //    foreach (var prop in properties)
            //    {
            //        var skillattr = prop.GetCustomAttribute<SkillAttribute>(); // to get only the methods which has [SkillAttribute] Above it of class Players.
            //        if(skillattr is not null)
            //        {
            //            var value = prop.GetValue(player);
            //            if(!skillattr.IsValid(value))
            //            {
            //                errors.Add(new Errors(prop.Name, $"Invalid Value {value} Accepted Range {skillattr.Minimum} - {skillattr.Maximum} of {player.Name}"));
            //            }
            //        }
            //    }
            //}
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
            #endregion


            Console.ReadKey();
        }
    }
}
