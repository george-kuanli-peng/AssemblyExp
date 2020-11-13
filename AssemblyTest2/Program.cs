using System;
using Mono.Cecil;

namespace AssemblyTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            var moduleFileName = "AssemblyTest2.exe";
            ModuleDefinition module = ModuleDefinition.ReadModule(moduleFileName);
            foreach (TypeDefinition type in module.Types)
            {
                Console.WriteLine((type.IsPublic? "[Public]": "[Private]") + " " + type.FullName);
            }
        }
    }
}
