using System;

namespace PlanesInheritance
{
    class PlaneApp
    {
        static void Main(string[] args)
        {
            CargoPlane cp = new CargoPlane();
            FighterPalne fp = new FighterPalne();
            Airport ap = new Airport();
            ap.AcceptPlane(cp);
            ap.AcceptPlane(fp);
            Plane p = new Plane();
            p.Fly();
            p.TakeOff();
            p.Land();
        }
    }
}
