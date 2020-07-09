using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePart
{
    class Program
    {
        delegate void Maind(string name);
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Car car = new Car();
            Train train = new Train();
            Express express = new Express();

            Maind del = vehicle.changeData;
            del += car.changeData;
            del += train.changeData;
            del += express.changeData;
            del += express.countOrdWagon;

            del("Bmw");
        }
    }
}
