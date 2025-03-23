namespace s30049_APBD;

public class Container
{
    public double mass;
    public double height;
    public double tareWeight;
    public double cargoWeight;
    public double depth;
    public String containerType;
    public int maxPayload;
    private static Random random = new Random();
    public string SerialNumber { get; private set; }
    public static int counter = 0;
    public Container(double mass, double height, double tareWeight, double cargoWeight, double depth, String containerType)
    {
        this.mass = mass;
        this.height = height;
        this.tareWeight = tareWeight;
        this.cargoWeight = cargoWeight;
        this.depth = depth;
      

        counter++;
        SerialNumber = $"KON-{containerType}-{counter}";
        maxPayload = random.Next(500,100000);
    }
    public virtual void EmptyCargo()
    {
        cargoWeight = 0;
    }
    
    public void LoadCargo(double mass)
    {
        if (cargoWeight + mass > maxPayload)
        {
            throw new OverfillException($"Cannot load {mass}kg into {SerialNumber}. Overfill detected! Max capacity: {maxPayload}kg.");
        }
        cargoWeight += mass;
    }

}

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message) { }
}


