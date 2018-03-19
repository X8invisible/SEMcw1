using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Bike
    {
        private int frameSize;
        private int frameColour;
        private int gears;
        private int brakes;
        private int wheels;
        private int handlebar;
        private int saddle;
        private bool extraWarranty = false;
        private double price;

        public Bike(int fs, int fc, int g, int b, int w, int h, int s)
        {
            FrameSize = fs;
            FrameColour = fc;
            Gears = g;
            Brakes = b;
            Wheels = w;
            Handlebar = h;
            Saddle = s;
        }
        //constructor with extra warranty
        public Bike(int fs, int fc, int g, int b, int w, int h, int s, bool extra) : this(fs, fc, g, b, w, h, s)
        {
            ExtraWarranty = extra;
        }
        public string Name
        {
            get { return "Maverick"; }
        }
        public int FrameSize
        {
            get { return frameSize; }
            set
            {
                if(value <1 || value >3)
                    throw new ArgumentException("Incorrect Size");
                frameSize = value;
            }
        }
        public int FrameColour
        {
            get { return frameColour; }
            set
            {
                if (value < 1 || value > 3)
                    throw new ArgumentException("Incorrect Colour");
                frameColour = value;
            }
        }
        public int Gears
        {
            get { return gears; }
            set
            {
                if (value < 1 || value > 3)
                    throw new ArgumentException("Incorrect Gears");
                gears = value;
            }
        }
        public int Brakes
        {
            get { return brakes; }
            set
            {
                if (value < 1 || value > 2)
                    throw new ArgumentException("Incorrect Brakes");
                brakes = value;
            }
        }
        public int Wheels
        {
            get { return wheels; }
            set
            {
                if (value < 1 || value > 3)
                    throw new ArgumentException("Incorrect Wheels");
                wheels = value;
            }
        }
        public int Handlebar
        {
            get { return handlebar; }
            set
            {
                if (value < 1 || value > 3)
                    throw new ArgumentException("Incorrect Handlebar");
                handlebar = value;
            }
        }
        public int Saddle
        {
            get { return saddle; }
            set
            {
                if (value < 1 || value > 2)
                    throw new ArgumentException("Incorrect HandleBar");
                saddle = value;
            }
        }
        public bool ExtraWarranty
        {
            get { return extraWarranty; }
            set { extraWarranty = value; }
        }
        public double Price
        {
            get
            {
                TotalPrice();
                return price;
            }
        }

        public void TotalPrice()
        {
            price = 100;
            if (extraWarranty)
                price += 50;
            price = price + frameSize * 70 + 25 + 50 * (gears + brakes / 2) + 35 * (wheels / 2) + 30 * (handlebar / 2) + 25 * (saddle / 2);
        }
    }
}
