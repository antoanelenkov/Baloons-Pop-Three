﻿//-----------------------------------------------------------------------
// <copyright file="Context.cs" company="Baloons-Pop-Three">
//    Copyright Baloons-Pop-Three. All rights reserved
// </copyright>
// <summary>This is the Context class.</summary>
//-----------------------------------------------------------------------
namespace BalloonsPop.Contexts
{
    using Contracts;
    using Controllers.Contracts;
    using Data.Contracts;
    using LogicProviders.Contracts;
    using Mementos;
    using Printer.Contracts;
    using Reader.Contracts;

    /// <summary>
    /// Game commands and logic.
    /// </summary>
    internal class Context : IContext
    {
        public Context(IBalloonsData data, IGameLogicProvider logic, IGamePrinter printer, IReader reader, ITopScoreController topScore, IGamesController gamesController)
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