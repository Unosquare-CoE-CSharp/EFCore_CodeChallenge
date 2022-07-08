using EFChallenge.Data.Models.Company;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFChallenge.Data
{
    public class AppDbInitializer 
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            //{
            //    var context = serviceScope.ServiceProvider.GetService<EFChallengeContext>();

            //    if (!context.Countries.Any())
            //    {
            //        context.Countries.AddRange(new Country()
            //        {
            //            Name = "Mexico"
            //        });

            //        context.SaveChanges();
            //    }
            //}

        }

    }
}
