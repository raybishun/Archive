using System;

/// <summary>
/// Attributes are used to add metadata to your code
/// And can be retrieved using Reflections
/// </summary> 
namespace _2_03_Adv_Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    class SampleAttribute : Attribute
    {
        public string AppName { get; set; }
        public int Version { get; set; }
    }
}
