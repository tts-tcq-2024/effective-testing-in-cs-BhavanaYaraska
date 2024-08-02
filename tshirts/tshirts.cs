using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms >= 38 && cms <= 42) { // Changed condition to include boundary value
                return "M";
            } else {
                return "L";
            }
        }

        static void Main(string[] args) {
            Debug.Assert(Size(37) == "S");
            Debug.Assert(Size(38) == "M"); // Added boundary value
            Debug.Assert(Size(40) == "M");
            Debug.Assert(Size(43) == "L");
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
