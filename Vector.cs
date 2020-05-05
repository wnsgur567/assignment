using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter7._5
{
    static class Constants
    {
        public const uint firstCapacity = 2;
        public const uint MAX = 128;
    }


    class Vector<T>
    {

        private T[] data;
        private uint capacity = Constants.firstCapacity;
        private uint size = 0;
        private Type type;

        //2020-05-05
        public uint Count
        {
            get { return size; }
        }

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
            if (size == 0)
            {
                Console.WriteLine("null");
            }
            else
            {
                for (int i = 0; i < size; i++)
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
                resize(capacity * 2);
                data[size++] = input_data;
            }
        }
        //재할당
        public void resize(uint newSize)
        {
            if (newSize >= Constants.MAX)
                return;

            capacity = newSize;

            T[] tmp = new T[newSize];
            for (int i = 0; i < size; i++)
            {
                tmp[i] = data[i];
            }
            data = tmp; //delete없는데 기존 data 놔두는게 맞나
        }
        //마지막 원소 제거
        public void pop_back()
        {
            if (empty())
                return;

            data[size--] = default(T);
        }

        //모든 원소를 제거, 메모리는 남아있음
        public void clear()
        {
            while (size != 0) { pop_back(); }
        }

        //2020-05-05
        //index에 원소 추가
        public void insertAt(uint _index, T _val)
        {
            if (IsAvailableIndex(_index))
            {
                if (size >= capacity)
                {
                    resize(capacity * 2);
                }

                for (uint i = size - 1; i >= _index; i--) //한칸씩 밀기
                {
                    data[i + 1] = data[i];
                }
                data[_index] = _val;
            }
        }

        //index로 원소 제거
        public void removeAt(uint _index)
        {
            if (IsAvailableIndex(_index))
            {
                for (uint i = _index; i < size; i++)
                {
                    data[i] = data[i + 1];
                }
                pop_back();
            }
        }

        //2020-05-05
        public void addRange(uint _index, T[] arr)
        {
            if (IsAvailableIndex(_index))
            {
                int arrLength = arr.Length;
                if (size + arrLength >= capacity)
                {
                    resize(capacity * 2);
                }

                int aIndex = arrLength - 1;
                size += (uint)arrLength;
                for (uint i = size - 1; aIndex >= 0; i--) 
                {
                    data[i] = data[i - arrLength];
                    data[i - arrLength] = arr[aIndex--];
                }
                
            }
        }


        //---------------------------------//

        //2020-05-05
        //index가 유효 범위에 있는지
        //유효 : true
        public bool IsAvailableIndex(uint _index)
        {
            if (_index > size - 1)
            {
                Console.WriteLine("\nIs not availble Index");
                return false;
            }
            return true;
        }

        //size가 0이면 true
        private bool empty()
        {
            if (size == 0)
            {
                Console.WriteLine("\n ---vector is empty---");
                return true;
            }
            return false;
        }
        public bool isEmpty()
        {
            if (size == 0)
                return true;
            return false;
        }

        //원소의 개수를 리턴
        public uint getSize()
        {
            return size;
        }
        //할당된 공간의 크기를 리턴
        public uint getCapacity()
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
