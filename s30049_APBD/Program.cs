// See https://aka.ms/new-console-template for more information

using s30049_APBD;

class Program
{
    static void Main()
    {
        ContainerShip ship1 = new(30, 5, 50000);
        ContainerShip ship2 = new(25, 5, 40000);

        LiquidContainer milkContainer = new(500, 250, 5000, 18000, 500, "L", false);
        GasContainer heliumContainer = new(200, 200, 3000, 2000, 400, "G", 5);
        RefrigeratedContainer bananaContainer = new(400, 220, 4000, 14000, 450, "C", "Bananas", 5);

        milkContainer.LoadCargo(18000);
        //heliumContainer.LoadCargo(10);
        bananaContainer.LoadCargo(14000);

        ship1.LoadContainer(milkContainer);
            // ship1.LoadContainer(heliumContainer);
        //ship1.LoadContainer(bananaContainer);
            
        Console.WriteLine("--- Ship 1 Details ---");
        ship1.PrintInfo();
            
        ship1.TransferContainer(ship2, milkContainer.SerialNumber);
            
        Console.WriteLine("--- Ship 2 Details After Transfer ---");
        ship2.PrintInfo();
    }
}