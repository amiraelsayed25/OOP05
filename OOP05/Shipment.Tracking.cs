//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP05
//{
//    public abstract partial class Shipment
//    {
//        public string TrackingStatus { get; set; }
//        public abstract string GetTrackingStatus();
//        partial void OnTrackingStatusChanged(string newStatus);
//        => Console.WriteLine("Tracking Status Changed:{newStatues}");


//            public void UpdateTrackingStatus(string newStatus)
//        {
//            if (string.IsNullOrWhiteSpace(newStatus))
//                return;
//            TrackingStatus = newStatus;
//            OnTrckingStatusChanged(newStatus);
//        }
//    }
//}
