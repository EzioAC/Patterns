using System;

namespace Patterns.Bridge
{
    public class McDonnellDouglas:IPlaneManufacturer
    {
        private IPlane _plane;
        IPlane IPlaneManufacturer.plane { get => _plane; set => _plane = value; }
        void IPlaneManufacturer.Manufacture()
        {   
            Console.WriteLine(this.GetType().Name+" "+_plane.GetType().Name);
        }
    }
}