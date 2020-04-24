using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SceneGenerator
{
    public class OnChangedCallAttribute : PropertyAttribute
    {
        public string mMethodName;
        public OnChangedCallAttribute(string methodNameNoArguments)
        {
            mMethodName = methodNameNoArguments;
        }
    }
}
