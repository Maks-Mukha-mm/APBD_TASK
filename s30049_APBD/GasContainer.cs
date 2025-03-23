namespace s30049_APBD;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double mass, double height, double tareWeight, double cargoWeight, double depth, string containerType, double pressure) : base(mass, height, tareWeight, cargoWeight, depth, containerType)
    {
        Pressure = pressure;
    }

    public double Pressure { get; }

    

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[HAZARD] {SerialNumber}: {message}");
    }

    public override void EmptyCargo()
    {
        cargoWeight *= 0.05; 
    }
}