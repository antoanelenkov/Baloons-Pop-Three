﻿namespace BalloonsPop.Contexts
{
    using BalloonsPop.Contexts.Contracts;
    using BalloonsPop.Data.Contracts;
    using LogicProviders.Contracts;
    using BalloonsPop.Mementos;
    using BalloonsPop.Printer;
    using BalloonsPop.Reader;
    using BalloonsPop.TopScoreBoard;
    using Controllers;

    internal class Context : IContext
    {
        public Context(IBalloonsData data, IGameLogicProvider logic, IGamePrinter printer, IReader reader, ITopScoreController topScore,IGamesController gamesController)
        {
            this.DataBase = data;
            this.GameLogic = logic;
            this.Printer = printer;
            this.Reader = reader;
            this.TopScoreController = topScore;
            this.GamesController = gamesController;

            this.Memory = new GameStateMemory();
        }

        public IBalloonsData DataBase { get; private set; }

        public IGameLogicProvider GameLogic { get; private set; }

        public IGamePrinter Printer { get; private set; }

        public IReader Reader { get; private set; }

        public ITopScoreController TopScoreController { get; private set; }

        public IGamesController GamesController { get; private set; }

        public GameStateMemory Memory { get; set; }
    }
}