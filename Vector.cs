using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter7._5
{
    static class Constants
    {
        public const int firstCapacity = 2;
        public const int MAX = 128;
    }


    class Vector<T>
    {
        private T[] data;
        private int capacity = Constants.firstCapacity;
        private int size = 0;
        private Type type;

        public Vector()
        {   
            data = new T[capacity];
            type = typeof(T);
            string outStr = "**********************************************";
            Console.WriteLine($"\n{outStr}");
            Console.WriteLine($"vector<{type}> is created");
            Console.WriteLine($"{outStr}");
        }

        public override string ToString()
        {
            Console.WriteLine($"\nSize:{size}\nCapacity:{capacity}");
            if(size == 0)
            {
                Console.WriteLine("null");
            }
            else
            {
                for(int i = 0; i < size; i++)
                {
                    Console.Write($"{data[i]} ");
                    if (i < size - 1)
                        Console.Write(",");
                }
                Console.WriteLine();
            }

            return string.Format($"vector<{type}>");
        }

        //c#제네릭에서 연산자 오버로드 사용 불가
        //public static operator[] (int index)
        //{ type별로 하나하나 찍어 만드세요           
        //}


        //원소 추가
        public void push_back(T input_data)
        {            
            if (size < capacity)
                data[size++] = input_data;
            else
            {
                resize(capacity = capacity * 2);
                data[size++] = input_data;
            }
        }
        //재할당
        public void resize(int newSize)
        {
            if (newSize >= Constants.MAX)
                return;

            T[] tmp = new T[newSize];
            for(int i = 0; i < size; i++)
            {
                tmp[i] = data[i];
            }
            data = tmp; //delete없는데 기존 data 놔두는게 맞나
        }
        //마지막 원소 제거
        public void pop_back()
        {
            if (size == 0)
                return;

            //default는 7.0부터 지원
            //그전 버전에서는 어떻게 사용?
            data[size--] = default(T);

        }
        //모든 원소를 제거, 메모리는 남아있음
        public void clear()
        {
            while (size != 0) { pop_back(); }
        }

        public void removeAt(int _index)
        {
            if (_index < 0 || _index > size - 1)
                return;

            for(int i = _index; i < size; i++)
            {
                data[i] = data[i + 1];
            }
            pop_back();
        }
        //size가 0이면 true
        public bool empty()
        {
            if (size == 0)
                return true;
            return false;
        }

        //원소의 개수를 리턴
        public int getSize()
        {
            return size;
        }
        //할당된 공간의 크기를 리턴
        public int getCapacity()
        {
            return capacity;
        }
      


        //---------------------------------//

        public void begin()
        {
            //포인터 못쓰는데 주소값 어케 반환함????
        }
        public void end()
        {

        }
        //첫번째 원소를 참조
        public void front()
        {

        }
        //마지막 원소를 참조
        public void back()
        {

        }
    }
}
