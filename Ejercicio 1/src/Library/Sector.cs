using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
{
    public string SectorNombre{get;}

    public List<Shelve> ListaShelve = new List<Shelve>();

    public Sector(string SectorNombre)
    {
        this.SectorNombre = SectorNombre;    
    }

    public void AddShelve(Shelve Estanteria)
    {
        ListaShelve.Add(Estanteria);
        Console.WriteLine("Se ha agregado la estanteria ");
    }
    public void RemoveShelve(Shelve Estanteria)
    {
        ListaShelve.Remove(Estanteria);
        Console.WriteLine("Se ha eliminado la estanteria ");
    }

}
}