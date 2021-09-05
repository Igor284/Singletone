using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var text1 = new FileWorker();
            var text2 = new FileWorker();*/

            var text1 = FileWorker.Instance;
            var text2 = FileWorker.Instance;

            text1.WhriteText("hhh");
            text2.WhriteText("ggg");
            
            text1.Save();
            text2.Save();

            Console.ReadLine();
            
        }
    }
}
