using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TableModels
{
    public class Market
    {
        [Key]
        public int Id { get; set; }
        public int MarketNumber { get; set; }
        public string? Poc { get; set; }
        
    }
}
