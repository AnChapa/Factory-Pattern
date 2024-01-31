namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels do you want?");
            IVehicle vehicle = VehicleFactory.GetVehicle(Console.ReadLine());
            vehicle.Drive();
        }
    }
}
