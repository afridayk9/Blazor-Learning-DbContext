using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableModels
{
    /// <summary>
    /// a model used to structure the data in the Leads table
    /// </summary>
    public class Leads
    {
        [Key]
        public int Id { get; set; }
        public DateTime? DateContacted { get; set; }
        public string? Category { get; set; }
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public string? StoreNumber {  get; set; }
        public string? MarketNumber { get; set; }
        public string? Status { get; set; }
        public string? QueryRan { get; set; }
        public string? PersonContacted { get; set; }        

    }
}
