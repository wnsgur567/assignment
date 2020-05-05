using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter7._5
{
    class Test_double
    {
        public void Test()
        {
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
