﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300104
{
    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }
}