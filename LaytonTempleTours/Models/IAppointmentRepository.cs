using System;
using System.Linq;

namespace LaytonTempleTours.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }
        IQueryable<Time> Times { get; }

        public void SaveAppointment(Appointment a);
        public void CreateAppointment(Appointment a);
        public void DeleteAppointment(Appointment a);
        public void SaveTimeslot(Time t);
    }
}
