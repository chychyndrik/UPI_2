using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientTCP.Root
{
    internal class RootProgram
    {
        public static RootProgram rootObject;
        
        RootProgram()
        {
        }

        public static RootProgram GetRoot()
        {
            if (rootObject == null)
            {
                rootObject = new RootProgram();
            }
            return rootObject;
        }
    }
}
