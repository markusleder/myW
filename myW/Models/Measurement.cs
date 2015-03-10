using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyW.Models
{
    public class Measurement
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public float Weight { get; set; }

        public MeasurementTime Time { get; set; }
    }
}