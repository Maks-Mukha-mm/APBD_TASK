namespace s30049_APBD;

public class RefrigeratedContainer : Container
{
    public RefrigeratedContainer(double mass, double height, double tareWeight, double cargoWeight, double depth, string containerType, string productType, double temperature) : base(mass, height, tareWeight, cargoWeight, depth, containerType)
    {
        ProductType = productType;
        Temperature = temperature;
    }

    public string ProductType { get; }
    public double Temperature { get; }
   
  
}