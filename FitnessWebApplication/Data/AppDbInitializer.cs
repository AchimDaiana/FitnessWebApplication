using FitnessWebApplication.Data.Enums;
using FitnessWebApplication.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebApplication.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                //database este creata si exista
                context.Database.EnsureCreated();

                //Abonamente
                if (!context.Subscriptions.Any())
                {

                }
                //Abonamentele clientilor
                if (!context.User_Subcriptions.Any())
                {

                }
                //Utilizatori
                if (!context.Users.Any())
                {

                }
                //Rezervari
                if (!context.Reservations.Any())
                {

                }


                //Antrenori
                if (!context.Trainers.Any())
                {
                    context.Trainers.AddRange(new List<Trainer>() {
                    new Trainer()
                    {
                        FirstName = "Pamela",
                        LastName = "Reif",
                        ProfilePictureUrl ="C:/LICENTA/Aplicatie/FitnessWebApplication/FitnessWebApplication/wwwroot/Images/pamela.jpg",
                        Biography = "Pamela Reif și-a început călătoria în fitness pe rețelele de socializare încă din 2012, când avea doar 16 ani. " +
                        "Exercițiile ei preferate sunt podurile pentru fesieri, genuflexiunile, miscarile abdominale sau orice fel de seturi de greutate corporală.",

                    }

                    });
                    context.SaveChanges();

                }


                //Clase
                if (!context.Classes.Any())
                {
                    context.Classes.AddRange(new List<Classes>() {
                    new Classes()
                    {
                        Name = "HIT",
                        Description = "HIT este o clasa care reuseste sa lucreze cu toate grupurile musculare intr-o singura ora.",
                        PictureUrl = "",
                        ClassCategory = ClassCategory.FullBody,
                        TrainerId = 1
                    },

                   /*  new Classes()
                    {
                        Name = "Pilates",
                        Description = "Descriere Pilates",
                        PictureUrl = "",
                        ClassCategory = ClassCategory.FullBody,
                       // TrainerId = 
                    },

                      new Classes()
                    {
                        Name = "Circuit Training",
                        Description = "Descriere Circuit Training",
                        PictureUrl = "",
                        ClassCategory = ClassCategory.FullBody,
                       // TrainerId = 
                    },

                       new Classes()
                    {
                        Name = "Kangoo Jumps",
                        Description = "Descriere Kangoo Jumps",
                        PictureUrl = "",
                        ClassCategory = ClassCategory.LowerBody,
                       // TrainerId = 
                    },

                        new Classes()
                    {
                        Name = "Abs&Arms",
                        Description = "Descriere Abs&arms",
                        PictureUrl = "",
                        ClassCategory = ClassCategory.Core,
                       // TrainerId = 
                    }*/
                    }) ;
                    context.SaveChanges();

                }
              
            



            }
        }
    }

}
