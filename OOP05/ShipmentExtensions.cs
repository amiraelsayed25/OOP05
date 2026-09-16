//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP05
//{
//    public static class ShipmentExtensions
//    {
//        public static string GetSummery(this Shipment shipment)
//        {
//            return $"{shipment.TrackingCode}-{shipment.ShipmentType}-{shipment.Weight}-{shipment.TrackingStatus}";
//        }

//        public static bool IsDeliverd(this Shipment shipment)
//        {
//            return shipment.GetTrackingStatus() == "Deliverd";
//        }
//    }
//}
