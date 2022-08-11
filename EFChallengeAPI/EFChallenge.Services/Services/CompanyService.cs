using EFChallenge.Data;
using EFChallenge.Data.Models.Company;
using EFChallenge.Services.Interfaces;

namespace EFChallenge.Services.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly EFChallengeContext _context;
        
        
        public CompanyService(EFChallengeContext context) => _context = context;

        public Country AddCountry(Country country)
        {
             _context.Add(country);
             _context.SaveChanges();
             return country;
        }

        public Country UpdateCountry(Country country)
        {
            var existCountry = _context.Countries.Where(x => x.Id == country.Id).FirstOrDefault(); 

            if (existCountry != null)
            {
                existCountry.Name = country.Name;
                _context.SaveChanges();
                return country;
            }
            return null ;
        }

        public Country DeleteCountry(int id)
        {
            var countryToRemove = _context.Countries.Find(id);
            if(countryToRemove != null)
            {
                _context.Countries.Remove(countryToRemove);
                _context.SaveChanges();
                return countryToRemove;
            }
            return null;
        }

        public IList<Country> GetCountry()
        {
            var countries = new List<Country>();
            countries = _context.Countries.ToList();
            return countries;
        }
    }
}
