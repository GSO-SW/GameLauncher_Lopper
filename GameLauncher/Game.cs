using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher
{
    public class Game
    {
        public string title;
        public string path;

        public Game(string titel, string pfad)
        {
            title = titel;
            path = pfad;
            try
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException();
            }
            catch(FileNotFoundException e)
            {
                throw;
            }
            
            //throw new NotImplementedException();
        }
        
    }
}
