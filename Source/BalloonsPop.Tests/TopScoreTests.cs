﻿namespace BalloonsPop.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;
    using System.Collections.Generic;

    using Data.Contracts;
    using Models;
    using TopScoreBoard;
    using Mocks;

    [TestClass]
    public class TopScoreTests
    {
        private readonly IEnumerable<Player> fakePlayers;
        private readonly MockGenericRepository<Player> playersRepo;
        private readonly IBalloonsData db;
        private  TopScore scoreBoard;

        public TopScoreTests()
        {
            this.fakePlayers = this.GenerateFakeCollectionOfPlayers();
            this.playersRepo = new MockGenericRepository<Player>(this.fakePlayers);
            this.db = new TestBalloonsData(this.playersRepo.mockedRepo.Object, null);
            this.scoreBoard = new TopScore(this.db);
        }

        [TestMethod]
        public void GetTopCount_WithCetainNumberOfRecordsIfTheyArePresented_ShouldReturnTheRequestedNumber()
        {
            var requestedNumber = 3;
            var numberOfRecords = this.scoreBoard.GetTop(requestedNumber).Count();

            Assert.AreEqual(requestedNumber, numberOfRecords);
        }

        [TestMethod]
        public void GetTopCount_WithCetainNumberOfRecordsIfTheyAreNotPresented_ShouldReturnAllHighScoreRecordsNumber()
        {
            var requestedNumber = 5;
            var numberOfRecords = this.scoreBoard.GetTop(requestedNumber).Count();
            var allRecords = this.scoreBoard.HighScores.All().Count();

            Assert.AreEqual(allRecords, numberOfRecords);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetTop_ShouldThrow_IfCountIsNegative()
        {
            var requestedNumber = -1;
            var numberOfRecords = this.scoreBoard.GetTop(requestedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddPlayer_ShouldThrow_IfPlayerIsNull()
        {
            this.scoreBoard.AddPlayer(null);
        }

        private IEnumerable<Player> GenerateFakeCollectionOfPlayers()
        {
            var players = new List<Player>();
            players.Add(new Player() { Name = "Player0", Score =10, Id= "0" });
            players.Add(new Player() { Name = "Player1", Score = 20 , Id ="1"});
            players.Add(new Player() { Name = "Player2", Score = 30 , Id="2"});

            return players;
        }
    }
}
