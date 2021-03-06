﻿namespace BalloonsPop.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;
    using Models;

    [TestClass]
    public class TopScoreControllerTests
    {
        private readonly IEnumerable<Player> fakePlayers;
        private readonly MockIGenericRepository<Player> playersRepo;
        private TopScoreController topScoreController;

        public TopScoreControllerTests()
        {
            this.fakePlayers = this.GenerateFakeCollectionOfPlayers();
            this.playersRepo = new MockIGenericRepository<Player>(this.fakePlayers);
            this.topScoreController = new TopScoreController(this.playersRepo.MockedRepo.Object);
        }

        [TestMethod]
        public void GetTopCount_WithCetainNumberOfRecordsIfTheyArePresented_ShouldReturnTheRequestedNumber()
        {
            var expectedNumberOfRecords = 3;
            var actualNumberOfRecords = this.topScoreController.GetTop(expectedNumberOfRecords).Count();

            Assert.AreEqual(expectedNumberOfRecords, actualNumberOfRecords);
        }

        [TestMethod]
        public void GetTopCount_WithCetainNumberOfRecordsIfTheyAreNotPresented_ShouldReturnAllHighScoreRecordsNumber()
        {
            var requestedNumber = 5;
            var actualNumberOfRecords = this.topScoreController.GetTop(requestedNumber).Count();
            var expectedNumberOfRecords = this.topScoreController.All().Count();

            Assert.AreEqual(expectedNumberOfRecords, actualNumberOfRecords);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetTop_ShouldThrow_IfCountIsNegative()
        {
            var requestedNumber = -1;
            var numberOfRecords = this.topScoreController.GetTop(requestedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddPlayer_ShouldThrow_IfPlayerIsNull()
        {
            this.topScoreController.AddPlayer(null);
        }

        [TestMethod]
        public void AddPlayer_ShouldNotThrowAnException()
        {
            this.topScoreController.AddPlayer(new Player());
        }

        private IEnumerable<Player> GenerateFakeCollectionOfPlayers()
        {
            var players = new List<Player>();
            players.Add(new Player() { Name = "Player0", Score = 10, Id = "0" });
            players.Add(new Player() { Name = "Player1", Score = 20, Id = "1" });
            players.Add(new Player() { Name = "Player2", Score = 30, Id = "2" });

            return players;
        }
    }
}
