using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Leandro", "5876235","27", "09354004", "Casa Central");
            Doctor doctor1 = new Doctor ("Dr.Albert","C#");
            string appointmentResult = AppointmentService.CreateAppointment(patient1, DateTime.Now, doctor1);
            Console.WriteLine(appointmentResult);
            Patient patient2= new Patient("Romina ", "1843201","20", "093213187", "Policlinica");
            Doctor doctor2 = new Doctor ("Dr.Maurice","Adios");
            string appointmentResult2 = AppointmentService.CreateAppointment(patient2, DateTime.Now, doctor2);
            Console.WriteLine(appointmentResult2);

           }
        }
    }