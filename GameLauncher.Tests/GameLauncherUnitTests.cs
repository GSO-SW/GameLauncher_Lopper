using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLauncher;

namespace GameLauncher.Tests
{
    [TestClass]
    public class GameLauncherUnitTests
    {
        
        [TestCategory("AddGame")]
        [TestMethod]
        public void AddGame_Successful()
        {
            List<Game> GameList = new List<Game>();

            GameList.Add(new Game("Minesweeper", @"C:\Program Files\Microsoft Games\Minesweeper\MineSweeper.exe"));
           
            Assert.AreEqual(1, GameList.Count);
        }
        
        [TestCategory("AddGame")]
        [ExpectedException(typeof(FileNotFoundException))]
        [TestMethod]
        public void AddGame_NotExists()
        {
            List<Game> GameList = new List<Game>();

            GameList.Add(new Game("World of Warcraft", @"C:\Program Files (x86)\World of Warcraft\Wow-64.exe"));

        }

    }
}
