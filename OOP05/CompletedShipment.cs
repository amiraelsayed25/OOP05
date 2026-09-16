using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    public class CompletedShipment
    {
        public sealed class CompletedShipment : Shipment
        {
            public override string ShipmentType => "Completed Shipment";
            public override decimal EstimatedCost => 0;
            public CompletedShipment
                (
                 string trackingCode,
                 string description,
                 decimal weight,
                 decimal deliveryFee,
                 Deliveryaddess destination
                ) : base(trackingCode, description, weight, deliveryFee, destination)
            {
            }
            public override void PrintShipment()
            {
                Console.WriteLine($"Type: {ShipmentType}");
                Console.WriteLine($"Tracking Code : {TrackingCode}");
                Console.WriteLine($"Description : {Description}");
                Console.WriteLine($"Weight : {Weight} KG");
                Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
                Console.WriteLine($"Destination :{Destination.GetFullAddress}");
                Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
            }
            public override string GetTrakingStatus() => "pinding";

            public override decimal calclatedInsurance() => 0;

        }
    }
}
