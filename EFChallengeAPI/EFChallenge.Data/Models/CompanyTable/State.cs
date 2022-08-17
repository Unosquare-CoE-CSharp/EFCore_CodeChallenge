//-----------------------------------------------
// Proyect: EFChallenge 
// Developers: Christian Alvarado 
// Company:  Unosquare 2022
//-----------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace EFChallenge.Data.Models.Company
{
    /// <summary>
    ///   Class State
    /// </summary>
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CountryId { get; set; }

        //Navigation Properties
        public Country Country { get; set; } = null!;
        public List<County> ? Counties { get; set; }

    }
}