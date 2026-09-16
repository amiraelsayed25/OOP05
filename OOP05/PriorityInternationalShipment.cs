//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static OOP05.Deliveryaddess.Deliveryaddess;

//namespace OOP05
//{
//    public class PriorityInternationalShipment
//    {
//        public class PriorityInternationalShipment : InternationalShipment
//        {
//            public override string ShipmentType => this.GetType().Name;
//            public PriorityInternationalShipment(
//                string trackingCode,
//                string description,
//                decimal weight,
//                decimal deliveryFee,
//                DeliveryAddress destination,
//                string destinationCountry,
//                decimal customsFee)
//                : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
//            {
//            }

//            //("sealed method")
//            public override sealed void GenerateCustomReport()
//            {
//                Console.WriteLine($"[Priority] :Custom Report -Tracking :{TrackingCode}=Country :{DestinationCountry}-Fee :{CustomsFee}");
//            }
//        }
//    }
//}
