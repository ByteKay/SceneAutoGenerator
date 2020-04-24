using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SceneGenerator
{
    [AttributeUsage(AttributeTargets.All)]
    public class RenameAttribute : PropertyAttribute
    {
        public string mName;
        public RenameAttribute(string name)
        {
            mName = name;
        }
    }
}
