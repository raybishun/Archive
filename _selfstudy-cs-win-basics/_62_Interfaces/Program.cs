using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_Interfaces
{
    // - Are public by default
    // - You cannot specify access modifiers for its members
    interface IControls
    {
        void Start();
        void Stop();
    }

    class Program
    {
        static void Main(string[] args)
        {



            Console.ReadLine();
        }
    }

    public class Machine1 : IControls
    {
        public void Start()
        {

        }

        public void Stop()
        {
            
        }
    }

    public class Machine2 : IControls
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Machine3 : IControls
    {
        void IControls.Start()
        {
            throw new NotImplementedException();
        }

        void IControls.Stop()
        {
            throw new NotImplementedException();
        }
    }
}
