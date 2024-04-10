using System.Collections.Generic;
using Tutorial4.Models;

namespace Tutorial4.Database
{
    public class StaticVisitsData
    {
        public static List<Visit> visits = new List<Visit>()
        {
            new Visit("2024-04-10", 1, "Wizyta kontrolna", 50.0),
            new Visit("2024-04-12", 2, "Szczepienie", 80.0),
            new Visit("2024-04-15", 3, "Badanie krwi", 120.0),
            new Visit("2024-04-16", 3, "Wizyta kontrolna", 50.0),
            new Visit("2024-04-17", 3, "Szczepienie", 80.0)
        };
    }
}