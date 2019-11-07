using System;
namespace AbstactClasses
{
    public class Lamp : iElectronics
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Lamp()
        {
        }

        public void Touch()
        {
            Console.WriteLine("Increase brightness");
        }

        public bool DoesPowerOn()
        {
            return true;
        }

        public void PowerOn()
        {

        }
    }
}
