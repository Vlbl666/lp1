using System;

namespace ComputerApp
{
    class Computer
    {
        public int InventoryNumber;
        public double ProcessorFrequency;
        public int HardDriveSize;

        public void ShowData()
        {
            Console.WriteLine("Computer Specifications:");
            Console.WriteLine($"Inventory Number: {InventoryNumber}");
            Console.WriteLine($"Processor Frequency: {ProcessorFrequency} GHz");
            Console.WriteLine($"Hard Drive Size: {HardDriveSize} GB");
        }

        public double CalculateStorageCost(double pricePerGB)
        {
            return HardDriveSize * pricePerGB;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer();

            myComputer.InventoryNumber = 123345;
            myComputer.ProcessorFrequency = 1.5;
            myComputer.HardDriveSize = 400;

            myComputer.ShowData();

            double pricePerGB = 100;
            double totalCost = myComputer.CalculateStorageCost(pricePerGB);
            Console.WriteLine($"\nStorage Cost: {totalCost} rubles");

            Console.ReadKey();
        }
    }
}