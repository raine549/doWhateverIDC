namespace VehicleOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(0);
            //myCar.gasolineAmount = 0;

            Console.WriteLine("Enter the amount of gasoline to refuel: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            myCar.refuel(amount);
            myCar.drive();
        }
    }
}
