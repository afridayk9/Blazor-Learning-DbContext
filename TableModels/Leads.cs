using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableModels
{
    public class Leads
    {
        [Key]
        public int Id { get; set; }
        public string? Category { get; set; }
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public int StoreNumber {  get; set; }
        public string? Status { get; set; }
        public string? PersonContacted { get; set; }
        public DateTime? DateContacted { get; set; }

    }
}
