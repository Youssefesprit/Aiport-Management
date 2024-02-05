// See https://aka.ms/new-console-template for more information


using AM.Core.Domain;

Console.WriteLine("Hello, World!");

Plane plane = new Plane();
plane.Capacity = 1;
plane.ManufactureDate = DateTime.Now;
plane.MyPlaneType = PlaneType.Boing;

Plane plane2 = new Plane(PlaneType.Boing, 1,DateTime.Now) ;

Plane plane3 = new Plane()
{
    Capacity = 1,
    ManufactureDate = DateTime.Now,
} ;
// Testing polymorphism through inheritance
Passenger p = new Passenger();   // Creating an instance of the Passenger class
Staff s = new Staff();           // Creating an instance of the Staff class
Traveller t = new Traveller();   // Creating an instance of the Traveller class

// Calling the GetPassengerType method on each object to demonstrate polymorphic behavior
Console.WriteLine(p.GetPassengerType()); // Outputs: "I am a passenger"
Console.WriteLine(s.GetPassengerType()); // Outputs: "I am a Staff" (assuming you update the Staff class as mentioned before)
Console.WriteLine(t.GetPassengerType()); // Outputs: "I am a Traveller"
