using System;

namespace AdvancedMathLibrary {

    public static class Math {

                        // Absolute vlaue is always a positive. Even if you pass in a negative number
       public static int AbsoluteValue(int x) {             //gets only one parameter
            return (x < 0) ? -x : x;
        }
       public static int Add(int x, int y) {
            return x + y;
        }               
       public static int Subtract(int x, int y) {
            return x - y;
        }        
       public static int Multiply(int x, int y) {
            return x * y;
        }
        public static int Divide(int x, int y) {
            return x / y;
        }        
    }
}
