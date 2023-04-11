
Console.WriteLine();

Console.WriteLine("Journey by airplane: ");
Airplane myPlane = new Airplane();
myPlane.StartEngine("Contact");
myPlane.TakeOff();
myPlane.Drive();
myPlane.Land();
myPlane.StopEngine("Whirr");

Console.WriteLine();

Console.WriteLine("Journey by car: ");
Car myCar = new Car();
myCar.StartEngine("Bruuuum");
myCar.Accelerate();
myCar.Drive();
myCar.Brake();
myCar.StopEngine("Phut");

Console.WriteLine();

Console.WriteLine("Testing polymorphism");
Vehicle v = myCar;
v.Drive();
v = myPlane;
v.Drive();

