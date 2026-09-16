//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP05
//{
//    public class StandardShipment
//    {
//        public class StandardShipment : Shipment

//        {
//            public override decimal EstimatedCost => DeliveryFee + (Weight * 5);
//            public override ShipmentType=> "Standard Shipment";
//            public StandardShipment(
//                string trackingCode,
//                string description,
//                decimal weight,
//                decimal deliveryFee,
//                Deliveryaddess destination
//                )
//                : base(trackingCode, description, weight, deliveryFee, destination)
//            {
//            }

//            public override void PrintShipment()
//            {
//                Console.WriteLine($"Type: {ShipmentType}");
//                Console.WriteLine($"Tracking Code : {TrackingCode}");
//                Console.WriteLine($"Description : {Description}");
//                Console.WriteLine($"Weight : {Weight} KG");
//                Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
//                Console.WriteLine($"Destination :{Destination.GetFullAddress}");
//                Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
//            }

//            public override string GetTrackingStatues()
//            {
//                return $"Shipment {TrackingCode} is ready";
//            }

//            public override decimal calclatedInsurance() => EstimatedCost * 0.05m;
//        }
//    }
//}
