using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01
{
    internal struct phonebook
    {
        //attrubutes
        string[] names;
        long[] numbers;
        int size;
        // properties 
        public int Size //read only for size
        {
            get { return size; } 

        }
        // constructor 
        public phonebook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        //method 
        public void addnumber(int position, string name, long number)
        {
            if (position >= 0 && position < size)
            {
                names[position] = name;
                numbers[position] = number;
            }
        }
        public long GetNumber (string name)
        {
            for(int i = 0; i < names?.Length; i++)
                if (names[i] == name)
                    return numbers[i];
            return -1;   
        }
        public void SetNumber (string name, long number)
        {
            for (int i = 0;i < numbers?.Length; i++)
            {
                if (numbers[i].Equals(number))
                    numbers[i] = number;
            }
        }
        // indexer 
        public long this[string Name]
        {
            get
            {
                for (int i =0 ; i < names?.Length; i++)
                    if (Name == names[i] )
                        return numbers[i];
                return -1;
            }
            set
            {
                for (int i =0; i< names?.Length; i++)
                {
                    if (Name.Equals(names[i]))
                        numbers[i] =value;
                }
            }
        }
        public string this[int Index]
        {
            get
            {
                return $"{Index} :: {names[Index]} :: {numbers[Index]}";
            }
        }
    }
}
