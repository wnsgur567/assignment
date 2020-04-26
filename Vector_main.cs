using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter7._5
{
    class Vector_main
    {
        //int, double만 테스트 함
        static void Main()
        {
            //test int
            Vector<int> v = new Vector<int>();

            v.push_back(1);
            v.push_back(2);
            v.push_back(3);
            v.push_back(4);
            v.push_back(5);
            v.push_back(6);

            v.ToString();

            v.pop_back();
            v.pop_back();

            v.ToString();

            v.removeAt(1);
            v.ToString();

            v.clear();
            v.ToString();

            //test double
            Vector<double> vd = new Vector<double>();
            vd.push_back(1.1);
            vd.push_back(2.2);
            vd.push_back(3.3);
            vd.push_back(4.4);
            vd.push_back(5.5);
            vd.push_back(6.6);
            vd.push_back(10);

            vd.ToString();

            vd.pop_back();
            vd.pop_back();
            vd.pop_back();
            vd.ToString();

            vd.removeAt(1);
            //vd.removeAt(100);
            vd.ToString();

            vd.clear();
            vd.ToString();
        }
    }
}
