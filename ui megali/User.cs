using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_ergasia
{
    public static class User
    {
        public static bool work { get; set; } 

        public static bool gym { get; set; }
        public static bool super_market { get; set; } 
        public static bool car { get; set; }

        public static bool metro { get; set; } 

        public static bool onfoot { get; set; }

        public static bool bus { get; set; }

        public static bool bycicle { get; set; } 

        public static DateTime time { get; set; }

        static User() {
            gym = false;
            super_market = false;
            car = false;
            metro = false;
            onfoot = false;
            bus = false;
            bycicle = false;
            work = false;

        }


    }
}
