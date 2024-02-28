# Setup and Run
Run Visual Studio and Docker Desktop as Admin

Pull down SQL server image for demo - Run command in Windows Terminal
 docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=myStrong(!)Password" -p 1433:1433 --name sql_server_arksoft -d mcr.microsoft.com/mssql/server:2019-latest



- Code will run initial start up script to seed data for demo

# Developer Questions

- What is the difference between interfaces and abstract classes? Provide an example where you would use each.

  > Abstract classes can provide implementation while interfaces do not on principle.
  > Abstract classes can implement multiple interfaces while an interface cannot by design
  > Interfaces dont allow for defining fields while abstract classes can include fields and other members with or without implementation
 
 
  > Examples of when to use:
  
  > Use an abstract class when you have a group of related classes that should inherit common behavior from a base class
  
  ```csharp
  public abstract class Vehicle
  {
      public void StartEngine()
      {
          Console.WriteLine("Engine started.");
      }
  
      public abstract void Drive();
  }
  
  public class Car : Vehicle
  {
      public override void Drive()
      {
          Console.WriteLine("Driving a car.");
      }
  }
  
  public class Motorcycle : Vehicle
  {
      public override void Drive()
      {
          Console.WriteLine("Riding a motorcycle.");
      }
  }
  ```
  
  > Use an interface when you want unrelated classes to implement the same functionality, but each with its own method of execution.
  
  ```csharp
  public interface IChargeable
  {
      void Charge();
  }
  
  public class Smartphone : IChargeable
  {
      public void Charge()
      {
          Console.WriteLine("Charging smartphone.");
      }
  }
  
  public class ElectricCar : IChargeable
  {
      public void Charge()
      {
          Console.WriteLine("Charging electric car.");
      }
  }
  ```

- What are the advantages of using interfaces?

  > **Decoupling**: Interfaces help decouple the implementation from the interface, allowing changes to be made to the implementation without affecting the interface consumers.
  > **Interoperability**: Interfaces are crucial for defining contracts for different systems to interact, ensuring compatibility and interoperability.

- Give an example of inheritance i.e., real life business example where it could be used?

  > Building on the abstract class example provided earlier, The below code sample is of a scenario where a logistics company may build out a set of variations on the base vehicle fleet:
 ```csharp
  
  public class Car : Vehicle
  {
      public int SeatingCapacity { get; set; }
  
      public override void DisplayInfo()
      {
          Console.WriteLine($"Car: {Make} {Model}, Year: {Year}, Seats: {SeatingCapacity}");
      }
  }
  
  public class Truck : Vehicle
  {
      public int LoadCapacity { get; set; }
  
      public override void DisplayInfo()
      {
          Console.WriteLine($"Truck: {Make} {Model}, Year: {Year}, Load Capacity: {LoadCapacity}kg");
      }
  }
  
  public class Bus : Vehicle
  {
      public int PassengerCapacity { get; set; }
  
      public override void DisplayInfo()
      {
          Console.WriteLine($"Bus: {Make} {Model}, Year: {Year}, Passengers: {PassengerCapacity}");
      }
  }:
  
  var car = new Car { Make = "Toyota", Model = "Corolla", Year = 2020, SeatingCapacity = 5 };
  var truck = new Truck { Make = "Ford", Model = "F-150", Year = 2019, LoadCapacity = 1000 };
  var bus = new Bus { Make = "Mercedes", Model = "Sprinter", Year = 2018, PassengerCapacity = 15 };
  
  car.DisplayInfo();
  truck.DisplayInfo();
  bus.DisplayInfo();
  ```
