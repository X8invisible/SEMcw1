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
        private bool extraWarranty;

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
        public Bike(int fs, int fc, int g, int b, int w, int h, int s, bool extra) : this(fs, fc, g, b, w, h, s)
        {
            ExtraWarranty = extra;
        }
        public int FrameSize
        {
            get { return frameSize; }
            set { frameSize = value; }
        }
        public int FrameColour
        {
            get { return frameColour; }
            set { frameColour = value; }
        }
        public int Gears
        {
            get { return gears; }
            set { gears = value; }
        }
        public int Brakes
        {
            get { return brakes; }
            set { brakes = value; }
        }
        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }
        public int Handlebar
        {
            get { return handlebar; }
            set { handlebar = value; }
        }
        public int Saddle
        {
            get { return saddle; }
            set { saddle = value; }
        }
        public bool ExtraWarranty
        {
            get { return extraWarranty; }
            set { extraWarranty = value; }
        }
    }
}
