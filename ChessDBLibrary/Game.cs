using ChessDBLibrary.ChessDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDBLibrary
{
    class Game
    {
        ChessDataSet.GamesDataTable gamesTable;
        GamesTableAdapter gamesAdapter;

        public Game()
        {
            gamesTable = new ChessDataSet.GamesDataTable();
            gamesAdapter = new GamesTableAdapter();
        }

        public void AddNewGame(int blackPlayerID, int whitePlayerID, int creatorID, System.DateTime startDateTime, int timeControl, int gameStatus,
                                    string movesHistory, string boardState, int whiteRestTime, int blackRestTime)
        {
            try
            {
                ChessDataSet.GamesRow newRow = gamesTable.NewGamesRow();

                newRow.BlackPlayerID = blackPlayerID;
                newRow.WhitePlayerID = whitePlayerID;
                newRow.CreatorID = creatorID;
                newRow.StartDateTime = startDateTime;
                newRow.TimeControl = timeControl;
                newRow.GameStatus = gameStatus;
                newRow.MovesHistory = movesHistory;
                newRow.BoardState = boardState;
                newRow.WhiteRestTime = whiteRestTime;
                newRow.BlackRestTime = blackRestTime;

                gamesTable.AddGamesRow(newRow);
                gamesAdapter.Update(gamesTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RemoveGameByID(int id)
        {
            try
            {
                gamesAdapter.Fill(gamesTable);
                ChessDataSet.GamesRow rowToDelete = gamesTable.FindByGameID(id);
                gamesAdapter.Delete(rowToDelete.GameID, rowToDelete.WhitePlayerID, rowToDelete.BlackPlayerID, rowToDelete.CreatorID,
                                        rowToDelete.StartDateTime, rowToDelete.TimeControl, rowToDelete.GameStatus, rowToDelete.WhiteRestTime, rowToDelete.BlackRestTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
