﻿
namespace BalloonsPop.TopScoreBoard
{
    using System.Collections.Generic;

    using BalloonsPop.Data;

    // TODO: Implement ITopScore
    interface ITopScore
    {
        IGenericRepository<Player> HighScores { set;get; }

        IEnumerable<Player> GetTop(int count);

        void AddPlayer(Player player);
    }
}
