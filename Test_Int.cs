using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter7._5
{
    class Test_Int
    {
        public void Test()
        {
            //test int
            Vector<int> v = new Vector<int>();
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };


            v.push_back(1);
            v.push_back(2);
            v.push_back(3);
            v.push_back(4);
            v.push_back(5);
            v.push_back(6);

            v.addRange(3, arr);                //2020-05-05
            v.ToString();
            Console.WriteLine("\n ---range test---");
            v.addRange(50, arr);               //2020-05-05 //out of range
            
            v.ToString();

            v.pop_back();
            v.pop_back();

            v.ToString();

            v.removeAt(1);
            v.ToString();

            v.insertAt(1, 100); //2020-05-05
            Console.WriteLine("\n ---range test---");
            v.insertAt(9, 100); //2020-05-05 //out of range
            

            v.clear();
            v.ToString();

            v.pop_back();

            
        }
    }
}
