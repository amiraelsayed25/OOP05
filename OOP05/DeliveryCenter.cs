//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP05
//{
//    public class DeliveryCenter
//    {
//        public class DeliveryCenter
//        {
//            private Shipment[] shipments;

//            public string CenterName { get; set; }

//            // Aggregation
//            public Driver Driver { get; set; }

//            public DeliveryCenter(string centerName)
//            {
//                CenterName = centerName;
//                shipments = new Shipment[20];
//            }

//            // Integer Indexer
//            public Shipment this[int index]
//            {
//                get
//                {
//                    if (index >= 0 && index < shipments.Length)
//                        return shipments[index];

//                    return default;
//                }

//                set
//                {
//                    if (index >= 0 && index < shipments.Length)
//                        shipments[index] = value;
//                }
//            }

//            // String Indexer
//            public Shipment this[string trackingCode]
//            {
//                get
//                {
//                    for (int i = 0; i < shipments.Length; i++)
//                    {
//                        if (shipments[i] != null &&
//                            shipments[i].TrackingCode == trackingCode)
//                        {
//                            return shipments[i];
//                        }
//                    }

//                    return default;
//                }
//            }

//            public bool AddShipment(Shipment shipment)
//            {
//                if (shipment == null)
//                    return false;

//                for (int i = 0; i < shipments.Length; i++)
//                {
//                    if (shipments[i] == null)
//                    {
//                        shipments[i] = shipment;
//                        return true;
//                    }
//                }

//                return false;
//            }

//            public bool RemoveShipment(string trackingCode)
//            {
//                for (int i = 0; i < shipments.Length; i++)
//                {
//                    if (shipments[i] != null &&
//                        shipments[i].TrackingCode == trackingCode)
//                    {
//                        shipments[i] = null;
//                        return true;
//                    }
//                }

//                return false;
//            }

//            public void PrintAllShipments()
//            {
//                Console.WriteLine("==========================================");
//                Console.WriteLine(CenterName);
//                Console.WriteLine("==========================================");

//                for (int i = 0; i < shipments.Length; i++)
//                {
//                    if (shipments[i] != null)
//                    {
//                        shipments[i].PrintShipment();
//                    }
//                }
//            }
//            public void PrintTrackingStatues()
//            {
//                foreach (ITrackable Shipment in shipments)
//                {
//                    Console.WriteLine(shipments.GetTrackingStatues();
//                }
//            }
//            public void PrintInsuranceCost()
//            {
//                foreach (Ilinsurance Shipment in shipments)
//                {
//                    Console.WriteLine(shipments.calclatedInsurance());
//                }
//            }

//        }
//    }
//}
