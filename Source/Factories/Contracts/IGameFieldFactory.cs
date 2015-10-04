﻿namespace BalloonsPop.Factories.Contracts
{
    using BalloonsPop.Commands.Contracts;
    using BalloonsPop.Common.Enums;
    using BalloonsPop.Contexts.Contracts;
    using Models;

    internal interface IGameFieldFactory
    {
        IContext Context { get; }

        GameField CreateGame(GameDifficulty input);
    }
}