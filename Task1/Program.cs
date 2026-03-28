namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();

            Display display = new Display();
            AirConditioner ac = new AirConditioner();
            SecuritySystem security = new SecuritySystem();

            sensor.OnTemperatureChanged += display.Update;
            sensor.OnTemperatureChanged += ac.HandleTemperature;
            sensor.OnTemperatureChanged += security.CheckSafety;

            sensor.SetTemperature(22); 
            sensor.SetTemperature(12);
            sensor.SetTemperature(30); 
            sensor.SetTemperature(45); 
            sensor.SetTemperature(2);  

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
