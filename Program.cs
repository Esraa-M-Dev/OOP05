namespace AssignmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region theoretical questions
            //Q(1) :object copying
            //(A): 2 variables carry same reference/address so both variables refer to same object in heap
            //(B):No,assignment with = only copies the reference from object to another not create new place/object in memory
            //(C)coping reference:both variables point to same object so , changing the object through any variable of them can affect anathor variable
            //   coping object:create new object include same values as originalc,changing one object don't affect the other 


            //Q(2):shallow and deep copy
            //(A):shallow copy:creates new object then copy the values for value types and copy the reference for reference types(same nested objects) 
            //(B)Deep copy:creates new object then copy the values for value types and creates new copies for reference types with same values(completely independent)
            //(C)it copies the reference itself so original object and copied object refer to the same reference object in memory=>changing through any object will affect
            //(D) it cteates new copies for reference types=>so changes through any reference willnot affect other
            //(E)For example, if you copy a Student object that contains a List<string> of courses, a Deep Copy ensures that adding or removing courses from the copied student's list does not change the original student's list


            //Q(3):Static members
            //(A) static field belongs to the class itself Only one copy of the static field and it is shared by all objects of the class
            //while instance field belongs to a specific object, so each object has its own separate copy.
            //(B) static method belongs to the class not specific object. It can be called using the class name without creating an object
            // static method cannot directly access instance members, because instance members belong to a specific object.
            //(C) static constructor is used to initialize static members of a class. Has the same name as the class.Has no access modifier.Has no parameters
            // executed automatically once, before the class is first used.
            //(D) static class is a class that can contain only static members. It cannot be inherited from, and you cannot create an object from it


            //Q(4):extension method
            //(A) extension Method is a method that allows you to add a new method to an existing type without modifying the original class or creating a derived class
            //(B) The this keyword must be used before the first parameter
            //(C)extension method must be declared inside a static class, and the extension method itself must also be static
            //(D)No. An extension method does not have special access to the private/protected members of the class it extends where not part of class






            #endregion
            #region question1-object copying
            //demonstrate the difference between assignment shipment and copy shipment
            //assignment
            // Shipment shipment1 = new Shipment("sh001", "laptop", 8m, 60m, new DeliveryAddress("cairo", "Naser street", 13));
            //Shipment shipment2 = shipment1; //2 shipments refer to same object
            //shipment2.Description = "phone";
            //Console.WriteLine(shipment1.Description); //phone->affect change

            //coping object
            //Shipment shipment3 = shipment1.CopyShipment();
            //shipment3.Description = "Pc";
            //Console.WriteLine(shipment1.Description); // un changed->new objects with new places
            #endregion
            #region question2-shallow copying
            //Shipment originalshipment = new Shipment("sh001", "laptop", 7m, 70m, new DeliveryAddress("giza", "tahrir street", 9));
            //Shipment copiedshipment = originalshipment.ShallowCopy();
            //copiedshipment.Destination.City = "cairo";
            //Console.WriteLine(originalshipment.Destination.City); //cairo :affected:2 objects has same reference of Delivery Address
            #endregion
            #region question3-deep copy
            //Shipment original = new Shipment("sh001", "laptop", 8m, 50m, new DeliveryAddress("cairo", "nasr street", 8));
            //Shipment copied = original.DeepCopy();
            //copied.Destination.City = "beni suef";
            //Console.WriteLine(original.Destination.City); //references completely independent
            //Console.WriteLine(object.ReferenceEquals(original.Destination,copied.Destination));
            #endregion
        }
    }
}
