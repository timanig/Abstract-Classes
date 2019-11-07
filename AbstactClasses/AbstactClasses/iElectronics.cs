using System;
namespace AbstactClasses
{
    public interface iElectronics
    {
        string Material { get; set; }
        public bool DoesPowerOn();
        public void PowerOn();
        
    }
}
