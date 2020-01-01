using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_Classes_L3_EnumerableColl
{
    class CustomerList : IList<Customer>
    {
        public Customer this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Customer item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Customer item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Customer item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Customer item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
