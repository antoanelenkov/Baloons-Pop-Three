﻿//-----------------------------------------------------------------------
// <copyright file="GlobalMessages.cs" company="Baloons-Pop-Three">
//    Copyright Baloons-Pop-Three. All rights reserved
// </copyright>
// <summary>This is the GlobalMessages class.</summary>
//-----------------------------------------------------------------------
namespace BalloonsPop.Common.Constants
{
    /// <summary>
    /// Stores all constant massages
    /// </summary>
    public class GlobalMessages
    {
        internal const string AlreadyPoppedBalloonsMsg = "You cannot pop already popped balloon";
        internal const string GreetingMsg = "Welcome to “Balloons Pops” game. Please try to pop the balloons. Write:\n'start' for starting a new game\n'restart' to restart the game\n'save' to save the game\n'restore' to restore saved game\n'undo' to step back once\n'top' to view the top scoreboard\n'exit' to quit the game\n";
        internal const string RowColMsg = "Enter a row and column or valid command: ";
        internal const string InvalidCommandMsg = "Invalid move or command!";
        internal const string AddToTopscoreMsg = "Please enter your name for the top scoreboard: ";
        internal const string SaveGameMsg = "Write the name of your game: ";
        internal const string SavedGameMsg = "Your game has been saved!";
        internal const string AllGamesMsg = "All games are: ";
        internal const string NameOfGameToRestoreMsg = "Write the name of your game";
        internal const string ExitCommandMessageMsg = "Thank you for playing this stupid game :) Welcome back";
        internal const string FinishCommandGreetingMsg = "Congratulations, you popped all balloons with ";
        internal const string InvalidCommandTypeMsg = "Invalid command type. Please try again";
        internal const string StartCommandMsg = "How difficult do you want it: Your options are:\neasy\nmedium\nhard\ntorture";
        internal const string StartCommandInvalidDifficultyMsg = "Invalid difficulty chosen. Default one is generated.";
        internal const string RestoreCommandInvalidGameMsg = "Sorry, game with this name is not found.";
        internal const string NullOrEmptyInput = "Sorry, you hadn't write anything. Press [enter] to continue...";

        internal const string InvalidCoordinatesExceptionMsg = "Invalid coordinates! Please try again";
        internal const string InvalidIndexOfFieldExceptionMsg = "There is no such index!";
        internal const string InvalidEnumerationExceptionMsg = "Should pass enumeration";
        internal const string NullExceptionMsg = " null";
        internal const string NullIdExceptionMsg = " null or whitespace id";
        internal const string ScoreNegativeMsg = " can't be negative";
    }
}