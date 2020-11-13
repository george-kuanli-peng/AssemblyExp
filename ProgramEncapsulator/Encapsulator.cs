using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEncapsulator
{
    class Encapsulator
    {
        public static void Encapsulate(string templateLoc, string origProgLoc, string outProgramLoc)
        {
            CheckArg(templateLoc, "templateLoc");
            CheckArg(origProgLoc, "origProgLoc");
            CheckArg(outProgramLoc, "outProgramLoc");

            ModuleDefinition module = ModuleDefinition.ReadModule(templateLoc);
            var namespaceName = "ProgramExtractor";

            foreach (var rsc in module.Resources.ToList())
            {
                if (rsc.Name == $"{namespaceName}.progBody" || rsc.Name == $"{namespaceName}.progName")
                {
                    module.Resources.Remove(rsc);
                }
            }

            using (FileStream fsOrigProg = File.OpenRead(origProgLoc))
            {    
                var rscProgName = new EmbeddedResource(
                    $"{namespaceName}.progName",
                    ManifestResourceAttributes.Private,
                    Encoding.UTF8.GetBytes(Path.GetFileName(origProgLoc))
                    );
                var rscProgBody = new EmbeddedResource(
                    $"{namespaceName}.progBody",
                    ManifestResourceAttributes.Private,
                    fsOrigProg
                    );
                module.Resources.Add(rscProgName);
                module.Resources.Add(rscProgBody);
                module.Write(outProgramLoc);
            }
        }

        private static void CheckArg(string arg, string argName)
        {
            if (arg == null)
            {
                throw new ArgumentException($"{argName} is null");
            }
        }
    }
}
