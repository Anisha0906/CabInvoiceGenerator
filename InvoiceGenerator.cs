using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        readonly private double COST_PER_KILO_METER = 10.0;
        readonly private double COST_PER_MININUTES = 1.0;
        readonly private double MINIMUM_FARE = 5.0;

        public InvoiceGenerator()
        {
        }
        public double CalculateCabFare(double runningDistance, double runningTime)
        {
            double totalFare = (runningDistance * COST_PER_KILO_METER) + (runningTime * COST_PER_MININUTES);
            if (totalFare < MINIMUM_FARE)
            {
                return MINIMUM_FARE;
            }
            return totalFare;
        }

        public double CalculateCabFare(Ride[] rides)
        {
            double totalFare = 0;
            foreach (Ride ride in rides)
            {
                totalFare += CalculateCabFare(ride.rideDistance, ride.rideTime);
            }
            if (totalFare < MINIMUM_FARE)
            {
                return MINIMUM_FARE;
            }
            return totalFare;
        }
    }
}