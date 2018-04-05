using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Stocks
    {
        private int frame = 15;
        private int gears = 15;
        private int brakes = 15;
        private int wheels = 15;
        private int handlebar = 15;
        private int saddle = 15;
        private static Stocks instance;

        private Stocks() { }

        public static Stocks Instance
        {
            get
            {
                if (instance == null)
                    instance = new Stocks();
                return instance;
            }
        }
        public bool Check(int f, int g, int b, int w, int h, int s)
        {
            bool checker = true;
            if(frame - f < 0) { checker = false; }
            if(gears - g < 0) { checker = false; }
            if(brakes - b < 0) { checker = false; }
            if(wheels - w < 0) { checker = false; }
            if(handlebar - h < 0) { checker = false; }
            if(saddle - s < 0) { checker = false; }

            return checker;
        }
        public bool UpdateStocks(int f, int g, int b, int w, int h, int s)
        {
            bool success = Check(f, g, b, w, h, s);
            if (success)
            {
                frame -= f;
                gears -= g;
                brakes -= b;
                wheels -= w;
                handlebar -= h;
                saddle -= s;
            }
            return success;
        }
        public void Revert(int f, int g, int b, int w, int h, int s)
        {
            frame += f;
            gears += g;
            brakes += b;
            wheels += w;
            handlebar += h;
            saddle += s;
        }
    }
}
