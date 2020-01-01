using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mod06_ReadingWritingLocalData_L2_Serialize
{
    [Serializable]
    class People : List<Person> //, ISerializable <-- use if you wanted more control over the serialization
    {

        
        //public People(SerializationInfo info, StreamingContext context)
        //{

        //}

        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    // info.AddValue(string name, bool value);
        //}
    }
}
