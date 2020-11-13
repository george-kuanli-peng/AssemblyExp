using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTest1
{
    class Program
    {
        public int SomeMethod()
        {
            Console.WriteLine("Some Method...");
            return 30;
        }

        static void Main(string[] args)
        {
            Assembly assem = typeof(Program).Assembly;

            Console.WriteLine("\nAssembly Full Name: " + assem.FullName);
            Console.WriteLine("\nAssembly CodeBase: " + assem.CodeBase);

            Object obj = assem.CreateInstance("AssemblyTest1.Program");
            MethodInfo minfo = assem.GetType("AssemblyTest1.Program").GetMethod("SomeMethod");
            Object ret = minfo.Invoke(obj, null);
            Console.WriteLine("\nSomeMethod returned {0}", ret);

            Console.WriteLine("\nAssembly Entry Point: " + assem.EntryPoint);
        }
    }
}
