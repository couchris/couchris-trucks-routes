using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_LAB1.Models
{
    public class TruckList
    {

        private static List<Truck> trucksList = new List<Truck>();

        public static IEnumerable<Truck> Trucks
        {
            get { return trucksList; }
        }

        public static void AddTrucks(Truck truck)
        {
            trucksList.Add(truck);
        }



    }
}
