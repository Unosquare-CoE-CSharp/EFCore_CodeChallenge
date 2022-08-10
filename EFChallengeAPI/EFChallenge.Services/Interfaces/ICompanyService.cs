using EFChallenge.Data.Models.Company;


namespace EFChallenge.Services.Interfaces
{
    public interface ICompanyService
    {
        public  Country AddCountry(Country country);
        public Country UpdateCountry(Country country);
        public Country DeleteCountry(int id);
        public IList<Country> GetCountry();
    }
}
