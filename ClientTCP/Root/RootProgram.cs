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

        // Cписок виджетов, доступный для добавления на форму
        public List<BlockObjectInterface> blocks;

        //Пресеты
        public List<Precet> Pages { get; set; }

        // пробел между виджетами
        public int Separator = 20;

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
