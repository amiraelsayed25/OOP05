using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    public class DeliveryReport
    {
        public static class DeliveryReport
        {
            public static void printShipment(ITrackable shipment)
                => Console.WriteLine(shipment.GetTrackingStatus());
            public static void printInsurance(Ilinsurance shipment)
               => Console.WriteLine(shipment.calclatedInsurance());
        }


    }
}
