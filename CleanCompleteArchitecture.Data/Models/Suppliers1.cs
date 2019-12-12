﻿using System;
using System.Collections.Generic;

namespace CleanCompleteArchitecture.Data.Models
{
    public partial class Suppliers1
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCategoryName { get; set; }
        public string PrimaryContact { get; set; }
        public string AlternateContact { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WebsiteUrl { get; set; }
        public string DeliveryMethod { get; set; }
        public string CityName { get; set; }
        public string SupplierReference { get; set; }
    }
}
