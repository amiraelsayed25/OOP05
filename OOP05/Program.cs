//namespace OOP05
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //  Console.WriteLine("Hello, World!");
//            //Part 01 — Theoretical Questions
//            //a) What happens when you assign one object variable to another object variable?
//            //only the reference is copied ,not the actual data

//            //b) Does assigning one object to another create a new object? Explain.
//            //No ,both variables point to the exact same object in memory

//            //c) What is the difference between copying an object and copying its reference?
//            //coping the refrence duplicates the memory address , while coping an object creates a whole new independent object in memory

//            //a) What is a Shallow Copy?
//            //a copy  that duplicate the objects top level structure but shared reference type member

//            //b) What is a Deep Copy?
//            //a copy  that duplicate the object along with all nasted refrence-type objects independently

//            //c) What happens to reference-type members when a Shallow Copy is created?
//            //they are shared; modifying them in the copy afects the original object

//            //d) What happens to reference-type members when a Deep Copy is created?
//            //they are duplicate a new object changes do not affect the original object

//            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
//            //when modifing nasted data(like updating a delivery address ) without alerting original profile data

//            //a) What is a static field, and how is it different from an instance field?
//            //is shared by the whole class, ehile an instance field belongs to a specific object

//            //b) What is a static method? Can a static method directly access instance members?
//            //a method belongs to a class itdelf. no, it cannot directly access instance method

//            //c) What is a static constructor, and when is it executed?
//            //a constructor used to initialize static data; it executes automatically once before the class is used

//            //d) What is a static class? Can you create an object from a static class?
//            //A CLASS ONLY containing static members , no you cannot create objects from it

//            //a) What is an Extension Method?
//            //a special static method that allowes adding new methods to existing without modified or inheriting them 

//            //b) What keyword must be used in the first parameter of an extension method?
//            //THIS keyword

//            //Where must an extension method be declared?
//            //inside a non-nasted , non-generic static class

//            //d) Can an extension method access private members of the class it extends?
//            // no it can only access public or internal members

//            //a) What is a Partial Class?
//            //a class whose defination can be split across multiple physical .cs files

//            //b) Why would a developer split one class into multiple files?
//            // to orgainze large code databases and allows multiple developers to work on the same class simultaneously without conflicts

//            //c) What is a Partial Method?
//            //A method declared in one partial class file eith its body optional or within in another partial file

//            //d) What happens if a declared partial method has no implementation?
//            //the compiler completely removes the method call and defination at compile time

        
//                //// 1. Static Class & Static Constructor & Static Method
//                //DeliveryUtilities.PrintSystemTitle("Smart Delivery Management System");

//                //var sh1 = new StandardShipment("SH001", 3.0, new DeliveryAddress("Cairo"), "In Transit");
//                //var sh2 = new ExpressShipment("SH002", 2.0, new DeliveryAddress("Alexandria"), "In Transit");
//                //var sh3 = new InternationalShipment("SH003", 8.0, new DeliveryAddress("Aswan"), "In Transit");

//                //Console.WriteLine($"Total: {Shipment.GetTotalShipmentsCreated()}");

//                //// 2. Reference Assignment
//                //Shipment assigned = sh1;
//                //Console.WriteLine($"Same Object: {object.ReferenceEquals(sh1, assigned)}");

//                //// 3. Shallow Copy
//                //Shipment shallow = sh1.ShallowCopy();
//                //shallow.DeliveryAddress.City = "Giza";
//                //Console.WriteLine($"Shallow - Orig: {sh1.DeliveryAddress.City} | Same Ref: {object.ReferenceEquals(sh1.DeliveryAddress, shallow.DeliveryAddress)}");

//                //// 4. Deep Copy
//                //sh1.DeliveryAddress.City = "Cairo";
//                //Shipment deep = sh1.DeepCopy();
//                //deep.DeliveryAddress.City = "Giza";
//                //Console.WriteLine($"Deep - Orig: {sh1.DeliveryAddress.City} | Same Ref: {object.ReferenceEquals(sh1.DeliveryAddress, deep.DeliveryAddress)}");

//                //// 5. Extension Methods
//                //sh2.UpdateTrackingStatus("Out For Delivery");
//                //sh3.UpdateTrackingStatus("Delivered");
//                //Console.WriteLine($"{sh1.GetSummary()}\nIs Delivered: {sh3.IsDelivered()}");

//                //// 6. Partial Method
//                //sh1.UpdateTrackingStatus("Out For Delivery"); // ينفذ OnTrackingStatusChanged أوتوماتيكياً
//            }
//        }
//    }



