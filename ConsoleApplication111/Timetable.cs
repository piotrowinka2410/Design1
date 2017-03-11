using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design1
{
    class Timetable
        
    {
        public List<DateTime> DepartureTimes(string BusStop)
        {
            var time = DateTime.Now;
            var DepartureDate1 = new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, 0);
            var DepartureDate2 = new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, 0).AddHours(1);
            var DepartureDate3 = new DateTime (time.Year, time.Month, time.Day, time.Hour, time.Minute, 0).AddHours(2);
            List<DateTime> DepartureTimes= new List<DateTime>();
            
            if (BusStop == "Dworzec Główny")
            {
                DepartureTimes.Add(DepartureDate1);
                DepartureTimes.Add(DepartureDate2);
                DepartureTimes.Add(DepartureDate3);
            }
            else if ( BusStop == "Lubicz")
            {
                DepartureTimes.Add(DepartureDate1.AddMinutes(2));
                DepartureTimes.Add(DepartureDate2.AddMinutes(2));
                DepartureTimes.Add(DepartureDate3.AddMinutes(2));

            }
            else if ( BusStop == "Rondo Mogilskie")
            {
                DepartureTimes.Add(DepartureDate1.AddMinutes(4));
                DepartureTimes.Add(DepartureDate2.AddMinutes(4));
                DepartureTimes.Add(DepartureDate3.AddMinutes(4));
            }
            else if ( BusStop == "Białucha")
            {
                DepartureTimes.Add(DepartureDate1.AddMinutes(6));
                DepartureTimes.Add(DepartureDate2.AddMinutes(6));
                DepartureTimes.Add(DepartureDate3.AddMinutes(6));
            }

            return DepartureTimes;
        }
        public List<StopWithTheDeparture> ListOfByStop(int number)
        {

            List<StopWithTheDeparture> BusStop = new List<StopWithTheDeparture>();
            if (number == 4)
            {
                BusStop.Add(new StopWithTheDeparture
                {
                    TheNameOfTheBusStop = "Dworzec Główny",
                    DepartureFromBusStop = DepartureTimes("Dworzec Główny")

                });
                BusStop.Add(new StopWithTheDeparture
                {
                    TheNameOfTheBusStop = "Lubicz",

                    DepartureFromBusStop = DepartureTimes("Lubicz")

                });
                BusStop.Add(new StopWithTheDeparture
                {
                    TheNameOfTheBusStop = "Rondo Mogilskie",
                    DepartureFromBusStop = DepartureTimes("Rondo Mogilskie")

                });
                BusStop.Add(new StopWithTheDeparture
                {
                    TheNameOfTheBusStop = "Białucha",
                    DepartureFromBusStop = DepartureTimes("Białucha")

                });

            }
            return BusStop;
        }
        

    }
}
