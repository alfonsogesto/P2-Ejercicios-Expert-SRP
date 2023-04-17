using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string Name {get; set;}
        public string Specialty {get; set;}
        public Doctor(string name, string speciality)
        {
            this.Name = name;
            this.Specialty = speciality;
        }
    }
}