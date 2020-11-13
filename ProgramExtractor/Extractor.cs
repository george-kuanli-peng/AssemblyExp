using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ProgramExtractor
{
    class Extractor
    {
        protected static string PROG_NAME_RSC_NAME = "ProgramExtractor.progName";
        protected static string PROG_BODY_RSC_NAME = "ProgramExtractor.progBody";

        protected Assembly asm = typeof(Extractor).Assembly;
        protected string progName = null;
        protected byte[] progBody = null;

        public Extractor()
        {
            CheckRsc(PROG_NAME_RSC_NAME);
            CheckRsc(PROG_BODY_RSC_NAME);
        }

        protected void CheckRsc(string rscName)
        {
            if (asm.GetManifestResourceInfo(rscName) == null)
            {
                throw new Exception($"{rscName} not found");
            }
        }

        public string GetProgName()
        {
            if (progName == null)
            {
                using (var progNameRscStream = asm.GetManifestResourceStream(PROG_NAME_RSC_NAME))
                {
                    progName = (new StreamReader(progNameRscStream, Encoding.UTF8)).ReadToEnd();
                }
            }
            return progName;
        }

        protected byte[] GetProgBody()
        {
            if (progBody == null)
            {
                using (var progBodyRscStream = asm.GetManifestResourceStream(PROG_BODY_RSC_NAME))
                {
                    var memStream = new MemoryStream();
                    progBodyRscStream.CopyTo(memStream);
                    progBody = memStream.ToArray();
                }
            }
            return progBody;
        }

        public void Extract(string extractLoc)
        {
            using (var outFileStream = File.OpenWrite(extractLoc))
            {
                byte[] _progBody = GetProgBody();
                outFileStream.Write(_progBody, 0, _progBody.Length);
            }
        }
    }
}
