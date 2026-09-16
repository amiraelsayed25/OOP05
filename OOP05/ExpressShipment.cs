using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    public class ExpressShipment
    {
        public class ExpressShipment : Shipment
        {
            private decimal extraFee;
            public override string ShipmentType => this.GetType().Name;
            public decimal ExtraFee
            {
                get { return extraFee; }
                set
                {
                    if (value >= 0)
                    {
                        extraFee = value;
                    }
                }
            }

            public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + ExtraFee;


            public ExpressShipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                Deliveryaddess destination,
                decimal extraFee)
                : base(trackingCode, description, weight, deliveryFee, destination)
            {
                ExtraFee = extraFee;
            }

            public override void PrintShipment()
            {
                Console.WriteLine("Express Shipment");
                Console.WriteLine($"Tracking Code : {TrackingCode}");
                Console.WriteLine($"Description : {Description}");
                Console.WriteLine($"Weight : {Weight} KG");
                Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
                Console.WriteLine($"Extra Fee : {ExtraFee} EGP");
                Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
            }

            public override string GetTrackingStatus()
            {
                return $"Shipment {TrackingCode}out for delivery ";
            }
            public override decimal calclatedInsurance() => EstimatedCost * 0.08m;
        }
    }
}
