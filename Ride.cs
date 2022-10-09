using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {

        readonly public double rideDistance;
        readonly public double rideTime;
        public Ride(double runningDistance, double runningTime)
        {
            this.rideDistance = runningDistance;
            this.rideTime = runningTime;
        }
    }
}