//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------
using EFChallenge.Data.Models.Company;


namespace EFChallenge.Services.Interfaces
{
    /// <summary>
    /// Interface ICompanyService 
    /// </summary>
    public interface ICompanyService
    {
        /// <summary>
        /// Method to create a Country
        /// </summary>
        /// <param name="country">Type Model</param>
        /// <returns>Country type model</returns>
        public Country AddCountry(Country country);

        /// <summary>
        /// Method to update a Country
        /// </summary>
        /// <param name="country"></param>
        /// <returns>Country type model</returns>
        public Country UpdateCountry(Country country);

        /// <summary>
        /// Method to delete a Country
        /// </summary>
        /// <param name="id">Type Model</param>
        /// <returns>Country type model</returns>
        public Country DeleteCountry(int id);

        /// <summary>
        /// Method to get Contries
        /// </summary>
        /// <returns>List of countries</returns>
        public IList<Country> GetCountry();
    }
}
