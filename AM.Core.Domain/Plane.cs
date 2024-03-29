﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType { Boing, Airbus }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "Capacity : " + Capacity 
                    + "ManufactureDate :" + ManufactureDate
                    + "PlaneId :" + PlaneId
                    + "MyPlaneType :" + MyPlaneType
                    ;
        }

        public Plane(PlaneType myPlaneType, int capacity, DateTime manufactureDate)
        {
            MyPlaneType = myPlaneType;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
        }

        public Plane()
        {
        }
    }
}