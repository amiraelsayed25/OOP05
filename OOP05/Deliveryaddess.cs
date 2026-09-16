using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    public class Deliveryaddess
    {
        
            
                public string City { get; set; }
                public string Street { get; set; }
                public int BuildingNumber { get; set; }

                public Deliveryaddess(string city, string street, int buildingNumber)
                {
                    City = city;
                    Street = street;
                    BuildingNumber = buildingNumber;
                }

                public string GetFullAddress()
                {
                    return $"{BuildingNumber} {Street}, {City}";
                }
            
        
    }
}
