﻿using System;
using System.Collections.Generic;

namespace CleanCompleteArchitecture.Data.Models
{
    public partial class VehicleTemperatures1
    {
        public long VehicleTemperatureId { get; set; }
        public string VehicleRegistration { get; set; }
        public int ChillerSensorNumber { get; set; }
        public DateTime RecordedWhen { get; set; }
        public decimal Temperature { get; set; }
        public string FullSensorData { get; set; }
    }
}
