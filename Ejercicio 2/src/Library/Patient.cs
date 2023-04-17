using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        public string Name {get; set;}
        public string Id {get; set;}
        public string Edad {get; set;}
        public string PhoneNumber {get; set;}
        public string AppointmentService {get; set;}
        public Patient(string name, string id, string edad, string phoneNumber, string appoinmentPlace)
        {
            this.Name = name;
            this.Id = id;
            this.Edad = edad;
            this.PhoneNumber = phoneNumber;
            this.AppointmentService = appoinmentPlace;
        }
    }
}