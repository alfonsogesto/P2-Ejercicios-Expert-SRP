using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            
            Sector SectorA = new Sector ("A");
            Shelve Shelve7 = new Shelve ("7");

            SectorA.AddShelve(Shelve7);
            Shelve7.AddLibro(book2);
        
            Sector SectorB = new Sector ("B");
            Shelve Shelve3 = new Shelve ("3");

            SectorB.AddShelve(Shelve3);
            Shelve3.AddLibro(book1);

        
       }
    }
}