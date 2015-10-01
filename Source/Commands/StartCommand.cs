﻿namespace BalloonsPop.Commands
{
    using Common.Enums;
    using Contexts;

    internal class StartCommand : ICommand
    {
        public StartCommand(ICommandContext context)
        {
            this.Context = context;
        }

        public ICommandContext Context { get; private set; }

        public void Execute()
        {
            this.Context.Printer.PrintMessage("How dificult do you want it: Your options are:\neasy\nmedium\nhard\ntorture");
            var input = this.Context.Reader.ReadInput();
            GameField gamefield;

            var validator = new CommandValidator<GameDifficulty>();

            if (validator.IsValidCommand(input))
            {
                if (validator.GetType(input) == GameDifficulty.Easy)
                {
                    gamefield = new GameField(5, 5);
                    this.Context.GameLogic.Game = new Game(gamefield);
                }
                else if (validator.GetType(input) == GameDifficulty.Medium)
                {
                    gamefield = new GameField(8, 8);
                    this.Context.GameLogic.Game = new Game(gamefield);
                }
                else if (validator.GetType(input) == GameDifficulty.Hard)
                {
                    gamefield = new GameField(10, 10);
                    this.Context.GameLogic.Game = new Game(gamefield);
                }
                else if (validator.GetType(input) == GameDifficulty.Torture)
                {
                    gamefield = new GameField(18, 18);
                    this.Context.GameLogic.Game = new Game(gamefield);
                }
            }
            else
            {
                this.Context.Printer.PrintMessage("Invalid dificulty chosen. Default one is genereted.");
            }

            this.Context.Printer.PrintGameBoard(this.Context.GameLogic.Game.Field);
        }
    }
}