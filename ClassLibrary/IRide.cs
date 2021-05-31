using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IRide
    {
        void GetDistanceOfRide();
        void CountFare();
        void CheckVip(Client _client);
        Worker GetDriver(Worker driver);
        int getAmountOfWorkers();
    }
}
