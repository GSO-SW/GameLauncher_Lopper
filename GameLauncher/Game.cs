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
        public string installdate;
        public string lastdate;
        public string category;
        public string publisher;
        public int usk;

        public Game(string titel, string pfad, string install, string zuletzt, string hersteller, string kategorie, int einstufung)
        {
            title = titel;
            path = pfad;
            installdate = install;
            lastdate = zuletzt;
            category = kategorie;
            publisher = hersteller;
            usk = einstufung;

            /*try
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException();
            }
            catch (FileNotFoundException)
            {
                throw;
            }*/
            
        }

        public string methode(string blabla)
        {
            string abc = blabla;
            return abc;
        }
        
    }
}
