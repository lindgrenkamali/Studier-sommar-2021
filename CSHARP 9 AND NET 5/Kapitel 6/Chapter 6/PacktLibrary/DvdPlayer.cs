using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary.Shared
{
    class DvdPlayer: IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("DVD-spelaren har pausats. Disco Stu är arg.");
        }

        public void Play()
        {
            Console.WriteLine("DVD-spelaren börjar spela igen. Disco Stu är glad igen (:");
        }
    }
}
