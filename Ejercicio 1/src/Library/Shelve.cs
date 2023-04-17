using System;
using System.Collections.Generic;


namespace SRP
{
    public class Shelve
    {
       public string Numero{get;}

       public List<Book> ListaLibros = new List<Book>();

       public Shelve(string Numero)
       {
        this.Numero = Numero;
       }
     public void AddLibro(Book Libro)
    {
        ListaLibros.Add(Libro);
        Console.WriteLine("Se ha agregado un libro");

    }
    public void RemoveLibro(Book Libro)
    {
        ListaLibros.Remove(Libro);
        Console.WriteLine("Se ha eliminado un libro");

    }
    }
}