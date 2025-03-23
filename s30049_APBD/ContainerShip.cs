namespace s30049_APBD;

public class ContainerShip
{
    public double MaxSpeed { get; }
    public int MaxContainers { get; }
    public double MaxWeight { get; }
    private List<Container> Containers = new();

    public ContainerShip(double maxSpeed, int maxContainers, double maxWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers)
            throw new Exception("Ship at full capacity!");
        if (Containers.Sum(c => c.cargoWeight + c.tareWeight) + container.cargoWeight + container.tareWeight > MaxWeight)
            throw new Exception("Exceeds ship weight limit!");
        Containers.Add(container);
    }

    public void UnloadContainer(string serialNumber)
    {
        var container = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container != null)
            Containers.Remove(container);
    }

    public void TransferContainer(ContainerShip targetShip, string serialNumber)
    {
        var container = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container != null)
        {
            UnloadContainer(serialNumber);
            targetShip.LoadContainer(container);
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Ship Max Speed: {MaxSpeed} knots, Capacity: {Containers.Count}/{MaxContainers}, Max Weight: {MaxWeight} tons");
        foreach (var c in Containers)
            Console.WriteLine(c);
    }
}