using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    public interface InternationalShipment
    {
        public class InternationalShipment : Shipment
        {
            private string destinationCountry;
            private decimal customsFee;
            public override string ShipmentType => this.GetType().Name;

            public string DestinationCountry
            {
                get { return destinationCountry; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        destinationCountry = value;
                }
            }

            public decimal CustomsFee
            {
                get { return customsFee; }
                set
                {
                    if (value >= 0)
                        customsFee = value;
                }
            }

            public override decimal EstimatedCost
            {
                get
                {
                    return DeliveryFee + (Weight * 5) + CustomsFee;
                }
            }

            public InternationalShipment(
                string trackingCode,
                string description,
                decimal weight,
                decimal deliveryFee,
                Deliveryaddess destination,
                string destinationCountry,
                decimal customsFee)
                : base(trackingCode, description, weight, deliveryFee, destination)
            {
                DestinationCountry =
                    string.IsNullOrWhiteSpace(destinationCountry) ? "Unknown" : destinationCountry;

                CustomsFee = customsFee;
            }

            public virtual sealed void GenerateCustomsReport()
            {
                Console.WriteLine($"Customs Report for {TrackingCode}");
                Console.WriteLine($"Country : {DestinationCountry}");
                Console.WriteLine($"Customs Fee : {CustomsFee} EGP");
            }

            public override void PrintShipment()
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("International Shipment");
                Console.WriteLine($"Tracking Code : {TrackingCode}");
                Console.WriteLine($"Description : {Description}");
                Console.WriteLine($"Weight : {Weight} KG");
                Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
                Console.WriteLine($"Destination Country : {DestinationCountry}");
                Console.WriteLine($"Customs Fee : {CustomsFee} EGP");
                Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
            }
            public override string GetTrackingStatus()
            {
                return $"Shipment {TrackingCode} is delivered ";
            }
            public override decimal calclatedInsurance() => EstimatedCost * 0.012m;
        }
    }
}
