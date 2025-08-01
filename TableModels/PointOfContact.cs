﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableModels
{
    /// <summary>
    /// a model used to structure the data in the PointofContact Table
    /// </summary>
    public class PointOfContact
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? StoreNumber { get; set; }
        public string? MarketNumber { get; set; }


    }
}
