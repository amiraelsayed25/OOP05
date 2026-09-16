using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05
{
    public abstract class Shipment : ITrakable, Ilinsurance
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public string TrackingCode
        {
            get => trackingCode;
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }
        public string Description
        {
            get => description;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }
        public decimal Weight
        {
            get => weight;
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public decimal DeliveryFee
        {
            get => deliveryFee;
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }

            }
        }
        public Deliveryaddess Destination { get; set; }


        public abstract decimal EstimatedCost { get; set; }

        public Shipment(string trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                TrackingCode = trackingCode;
            }
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new Deliveryaddess("Unknown", "Unknown", 0);

            TotalShipmentCreated++;
        }

        public Shipment
            (string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            Deliveryaddess destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                TrackingCode = trackingCode;
            }
            Destination = destination;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

            TotalShipmentCreated++;

        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0) DeliveryFee = newFee;
        }
        public void UpdateWeight(decimal newWeight)   //اول ابديت
        {
            if (newWeight > 0)
                Weight = newWeight;
        }
        public void UpdateWeight(decimal newWeight, decimal extrapackingWeight)  //تاني ابديت هياخد 2 بارامتر
        {
            decimal totalWeight = newWeight + extrapackingWeight;
            if (newWeight > 0 && extrapackingWeight >= 0)
                weight = totalWeight;
        }
        public abstract string GetTrakingStatus();



        public abstract void PrintShipment();

        public abstract decimal calclatedInsurance();
        public abstract Shipment CopyShipment();
    


        public Shipment CopyShipment()
         {
               return (Shipment)this.MemberwiseClone();
         }

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();
            copy.Destination = new Deliveryaddess(Destination.City,Destination.Street,Destination.BuildingNumber);
            return copy;
        }

        public static int TotalShipmentCreated;

        public Shipment()
        {
            TotalShipmentCreated = 0;
            Console.WriteLine("Total Inazialization");
        }



        //=========================================================
        public virtual string TrackingStatus => "pending";

        partial void OnTrackingStatusChanged(string newStatus);
    }
}
