using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLauncher
{
    public class Controller
    {
        public List<Game> GameList = new List<Game>();

        public void Add(Game game)
        {
            try
            {
                if (!File.Exists(game.path))
                   throw new FileNotFoundException();
            }
            catch(FileNotFoundException)
            {
                throw;
            }
            try
            {
                if(game == null)
                    throw new NullReferenceException();
            }
            catch(NullReferenceException)
            {
                throw;
            }
            GameList.Add(game);
        }

        public void Remove(Game game)
        {
            try
            {
                if (game == null)
                   throw new NullReferenceException();
            }
            catch(NullReferenceException)
            {
                throw;
            }
        }

        /*public Game GetDetails(Game game)
        {
            return game;
        }*/
    }
}
