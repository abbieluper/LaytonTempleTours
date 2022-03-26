using System;
using System.Linq;

namespace LaytonTempleTours.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        private AppointmentContext context { get; set; }

        public EFAppointmentRepository(AppointmentContext c)
        {
            context = c;
        }

        public IQueryable<Appointment> Appointments => context.Appointments;
        public IQueryable<Time> Times => context.Times;

        public void CreateAppointment(Appointment a)
        {
            context.Add(a);
            context.SaveChanges();
        }

        public void DeleteAppointment(Appointment a)
        {
            context.Remove(a);
            context.SaveChanges();
        }

        public void SaveAppointment(Appointment a)
        {
            context.Update(a);
            context.SaveChanges();
        }

        public void SaveTimeslot(Time t)
        {
            context.Update(t);
            context.SaveChanges();
        }
    }
}
