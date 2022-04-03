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
                //Rezervariu
                if (!context.Reservations.Any())
                {

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
                    }
                    });
                    context.SaveChanges();

                }
              
                //Antrenori
                if (!context.Trainers.Any())
                {
                    context.Trainers.AddRange(new List<Trainer>() {
                    new Trainer()
                    {
                        FirstName = "Pamela",
                        LastName = "Reif",
                        ProfilePictureUrl ="",
                        Biography = "Pamela Reif și-a început călătoria în fitness pe rețelele de socializare încă din 2012, când avea doar 16 ani. " +
                        "Exercițiile ei preferate sunt podurile pentru fesieri, genuflexiunile, miscarile abdominale sau orice fel de seturi de greutate corporală.",
                        ClassesId = 1
                    }

                    });
                context.SaveChanges();

                }
            



            }
        }
    }

}
