using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOver(3);
        }

        // 오버로딩
        public static int TestOver(int input) {  return 0; }
        public static int TestOver(double input) { return 0; }
        //public static bool TestOver(int input) { return true; }  // 매개변수가 같아서 error
    }
}
