using System;
using System.Collections.Generic;
using System.Text;

namespace CZGL.Reflect.Shared
{
    [AttributeUsage(AttributeTargets.Field)]
    public class MemberDefineNameAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
