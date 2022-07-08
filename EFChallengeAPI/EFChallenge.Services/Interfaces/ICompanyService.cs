using EFChallenge.Data.Models.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge.Services.Interfaces
{
    internal interface ICompanyService
    {
        public void AddCountry(Country country);
    }
}
