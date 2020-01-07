using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HRArraysLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int d = 4;

            var rotatedArray = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                var offset = (i + d) % a.Length;
                rotatedArray[i] = a[offset];
            }

            return rotatedArray;

        }
    }
}
