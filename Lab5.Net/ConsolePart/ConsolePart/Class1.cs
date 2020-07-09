using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePart
{
    class Vehicle : IDefault
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Mark { get; set; }

        public Vehicle()
        {
            this.Type = "None";
            this.Model = "None";
            this.Mark = "None";
        }

        public Vehicle(string type, string model, string mark)
        {
            this.Type = type;
            this.Model = model;
            this.Mark = mark;
        }

        public void changeData(string value)
        {
            this.Model = value;
        }
    }

    class Car : Vehicle, IDefault
    {
        public int WheelCount { get; set; }

        public Car() : base() {
            this.WheelCount = 4;
        }

        public Car(string type, string model, string mark, int wheelCount)
            :base(type, model, mark)
        {
            this.WheelCount = wheelCount;
        }
        

    }

    class Train : Vehicle
    {
        public int TicketPrice { get; set; }
        public int CarriageCount { get; set; }

        public Train() : base()
        {
            this.TicketPrice = 20;
            this.CarriageCount = 10;
        }

        public Train(string type, string model, string mark, int ticketPrice, int carriageCount)
            : base(type, model, mark)
        {
            this.TicketPrice = ticketPrice;
            this.CarriageCount = carriageCount;
        }

    }

    class Express : Train, IDefault, ICountOrdinaryWagon
    {
        public int VipCarriage { get; set; }

        public Express() : base()
        {
            this.VipCarriage = 2;
        }

        public Express(string type, string model, string mark, int ticketPrice, int carriageCount, int vipCarriage)
            : base(type, model, mark, ticketPrice, carriageCount)
        {
            this.VipCarriage = vipCarriage;
        }

        public void countOrdWagon(string n)
        {
            Console.WriteLine("Количество обычых вагонов в экспрессе: " + (this.CarriageCount - this.VipCarriage));
        }
    }
}
