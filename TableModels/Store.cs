﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableModels
{
    /// <summary>
    /// A model used to structure the Store Table 
    /// </summary>
    public class Store
    {
        [Key]
        public int Id { get; set; }
        public string? StoreNumber { get; set; }
        public string? MarketNumber { get; set; }
        public string? Poc { get; set; }
        public string? PhoneNumber { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? PostalCode { get; set; }

    }
}
