module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System

let schedule (appointmentDateDescription: string): DateTime = 
  DateTime.Parse(appointmentDateDescription)

let hasPassed (appointmentDate: DateTime): bool =
  let today = DateTime.UtcNow
  appointmentDate < today

let isAfternoonAppointment (appointmentDate: DateTime): bool =
  appointmentDate.Hour >= 12 && appointmentDate.Hour < 18

let description (appointmentDate: DateTime): string = 
  let descriptive = appointmentDate.ToString("M/d/yyyy h:mm:ss tt")
  sprintf "You have an appointment on %s." descriptive 

let anniversaryDate(): DateTime =
  DateTime(DateTime.Now.Year, 9, 15)
