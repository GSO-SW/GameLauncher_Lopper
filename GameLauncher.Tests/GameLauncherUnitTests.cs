using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLauncher;

namespace GameLauncher.Tests
{
    [TestClass]
    public class GameLauncherUnitTests
    {
        Controller controller = new Controller();


        [TestCategory("AddGame")]
        [TestMethod]
        public void AddGame_Successful()
        {
            Game minesweeper = new Game("Minesweeper", @"C:\Program Files\Microsoft Games\Minesweeper\MineSweeper.exe", DateTime.Now.ToString(), "never", "Microsoft", "strategy", 0);
            controller.Add(minesweeper);
           
            Assert.AreEqual(minesweeper, controller.GameList.Last());
        }
        
        [TestCategory("AddGame")]
        [ExpectedException(typeof(FileNotFoundException))]
        [TestMethod]
        public void AddGame_NotExists()
        {
            Game wow = new Game("World of Warcraft", @"C:\Program Files (x86)\World of Warcraft\Wow-64.exe", DateTime.Now.ToString(), "never", "Blizzard", "MMORPG", 12);
            controller.Add(wow);

            Assert.AreNotEqual(wow, controller.GameList.Last());
        }

        [TestCategory("AddGame")]
        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void AddGame_Null()
        {
            controller.Add(null);

            Assert.Fail();
        }

        [TestCategory("RemoveGame")]
        [TestMethod]
        public void RemoveGame_Successful()
        {
            Game minesweeper = new Game("Minesweeper", @"C:\Program Files\Microsoft Games\Minesweeper\MineSweeper.exe", DateTime.Now.ToString(), "never", "Microsoft", "strategy", 0);
            controller.GameList.Remove(minesweeper);

            Assert.IsTrue(!controller.GameList.Exists(x => x.title == "Minesweeper"));
            
        }

        [ExpectedException(typeof(System.NullReferenceException))]
        [TestCategory("RemoveGame")]
        [TestMethod]
        public void RemoveGame_Null()
        {
            controller.Remove(null);

            Assert.Fail();
        }

        [TestCategory("ShowDetails")]
        [TestMethod]
        public void ShowDetails_Successful()
        {
            //Game spiel = new Game();

            //controller.GetDetails(spiel);
            //hier müsste geprüft werden,
        }
    }
}
