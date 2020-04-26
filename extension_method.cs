using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace chapter7._5
{   //과제 1
    //string.isEmpty() 구현
    public static class CheckIsEmpty
    {
        public static bool isEmpty(this string myStr)
        {
            if(myStr == null || myStr == "")
            {
                return true;
            }
            return false;
        }
    }

    class extension_method
    {
        static void Main(string[] args)
        {
            string tempstr1 = null;
            string tempstr2 = "";
            string tempstr3 = "Abc";

            bool isflag = tempstr1.isEmpty();
            Console.WriteLine($"{tempstr1} : {isflag}");
            isflag = tempstr2.isEmpty();
            Console.WriteLine($"{tempstr2} : {isflag}");
            isflag = tempstr3.isEmpty();
            Console.WriteLine($"{tempstr3} : {isflag}");
        }
    }
}
