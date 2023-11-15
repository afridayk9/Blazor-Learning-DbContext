using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TableModels
{
    /// <summary>
    /// a model used to structure the data in the Market Table
    /// </summary>
    public class Market
    {
        [Key]
        public int Id { get; set; }
        public string? MarketNumber { get; set; }
        public string? Poc { get; set; }
        
    }
}
