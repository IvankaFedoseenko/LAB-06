using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    internal class Apperance
    {
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string HasFreckles { get; set; }

        public Apperance(string eyeColor, string  hairColor, string hasFreckles)
        {
            EyeColor = eyeColor;
            HairColor = hairColor;
            HasFreckles = hasFreckles;
        }

    }
}
