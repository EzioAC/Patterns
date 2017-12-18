using System;

namespace Patterns.Bridge
{
    public interface IPlaneManufacturer
    {
        IPlane plane{get;set;}
        void Manufacture();
    }
}