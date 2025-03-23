namespace s30049_APBD;

public class LiquidContainer : Container,IHazardNotifier
{
    public bool IsHazardous { get; }
    public LiquidContainer(double mass, double height, double tareWeight, double cargoWeight, double depth, string containerType, bool isHazardous) : base(mass, height, tareWeight, cargoWeight, depth, containerType)
    {
        this.IsHazardous = isHazardous;
    }

   

    public void NotifyHazard(string message) {
        Console.WriteLine($"[HAZARD] {SerialNumber}: {message}");
    }
    public new void LoadCargo(double mass) {
        double limit = IsHazardous ? maxPayload * 0.5 : maxPayload * 0.9; 

        if (mass + cargoWeight > limit) 
        {
            NotifyHazard($"Attempted to load {mass}kg, exceeding {limit}kg safety limit.");
        }
        else
        {
           this.LoadCargo(mass);
        }
    }

    public override void EmptyCargo()
    {
        cargoWeight *= 0.05; 
    }
}
