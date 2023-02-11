using System;
using Basics.TreeModel;

namespace Basics.PersonModel
{
    class Person
    {
        private int _serialNumber = 0;

        public void DoWork()
        {
            TreeModel.Tree tree = new TreeModel.Tree();
            Console.WriteLine(tree.Color);
        }
    }
}
