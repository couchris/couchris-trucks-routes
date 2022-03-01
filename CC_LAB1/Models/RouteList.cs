using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_LAB1.Models
{
    public class RouteList
    {

        private static List<Route> routesList = new List<Route>();

        public static IEnumerable<Route> Routes
        {
            get { return routesList; }
        }

        public static void AddRoutes(Route route)
        {
            routesList.Add(route);
        }



    }
}
