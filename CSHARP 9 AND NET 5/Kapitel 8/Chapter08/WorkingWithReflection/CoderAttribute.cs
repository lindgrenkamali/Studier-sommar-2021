﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithReflection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CoderAttribute : Attribute
    {
        public string Coder { get; set; }
        public DateTime LastModified { get; set; }

        public CoderAttribute(string coder, string lastModified)
        {
            Coder = coder;
            LastModified = DateTime.Parse(lastModified);
        }
    }
}
