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

