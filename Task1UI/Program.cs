using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Task1;

namespace Task1UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int countdown;
            do { Console.Write("Set the timeout in seconds: "); }
            while (!int.TryParse(Console.ReadLine(), out countdown));

            var timer = new TimerImitation();
            var manager = new TimerManager();
            SignedTypesBase[] array = new SignedTypesBase[3];
            array[0] = new SignedClassNumber1();
            array[1] = new SignedClassNumber2();
            array[2] = new SignedClassNumber2();
            

            array[0].Register(manager);
            array[1].Register(manager);
            array[2].Register(manager);
            timer.Imitation(manager, countdown);
            Console.WriteLine();
            foreach (SignedTypesBase element in array)
            {
                try { Console.WriteLine(element.GetMsg()); }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }

            array[0].Unregister(manager);
            timer.Imitation(manager, countdown); 
            Console.WriteLine();
            foreach (SignedTypesBase element in array)
            {
                try { Console.WriteLine(element.GetMsg()); }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }

            array[1].Unregister(manager);
            timer.Imitation(manager, countdown);
            Console.WriteLine();
            foreach (SignedTypesBase element in array)
            {
                try { Console.WriteLine(element.GetMsg()); }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }
    }
}
