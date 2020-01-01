﻿namespace _2_02_Adv_Generics
{
    class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }

    class Result<T, U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public U Data2 { get; set; }
        public U Data3 { get; set; }
    }
}
