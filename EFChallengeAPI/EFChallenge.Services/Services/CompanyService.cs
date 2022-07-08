using EFChallenge.Data;
using EFChallenge.Data.Models.Company;
using EFChallenge.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.Services.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyService _companyService;

        public void AddCountry(Country country)
        {
            using(var context = new EFChallengeContext())
            {
                context.Add(country);
                context.SaveChanges();
            }
        }
    }
}
