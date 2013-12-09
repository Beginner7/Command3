using ChessDBLibrary.ChessDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDBLibrary
{
    class Gamer
    {
        ChessDataSet.GamersDataTable gamersTable;
        GamersTableAdapter gamersAdapter;

        public Gamer()
        {
            gamersTable = new ChessDataSet.GamersDataTable();
            gamersAdapter = new GamersTableAdapter();
        }

        public void AddNewGamer(string name, string surname, string nickname, string country, System.DateTime birthday,
                                string eMailAddress, string password, int elo, bool status)
        {
            try
            {
                ChessDataSet.GamersRow newRow = gamersTable.NewGamersRow();

                newRow.Name = name;
                newRow.Surname = surname;
                newRow.Nickname = nickname;
                newRow.Country = country;
                newRow.Birthday = birthday;
                newRow.EMailAddress = eMailAddress;
                newRow.Password = password;
                newRow.Elo = elo;
                newRow.Status = status;

                gamersTable.AddGamersRow(newRow);
                gamersAdapter.Update(gamersTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void RemoveGamerByID(int id)
        {
            try
            {
                gamersAdapter.Fill(gamersTable);
                ChessDataSet.GamersRow rowToDelete = gamersTable.FindByGamerID(id);
                gamersAdapter.Delete(rowToDelete.GamerID, rowToDelete.Name, rowToDelete.Surname, rowToDelete.Nickname, rowToDelete.Country, rowToDelete.Birthday,
                                        rowToDelete.EMailAddress, rowToDelete.Password, rowToDelete.Elo, rowToDelete.Status);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int GamerAuthorization(string nickname, string password)
        {
            gamersTable = gamersAdapter.GetDataByNickname(nickname);

            if (gamersTable.Rows.Count != 0)
            {
                if (password == gamersTable.Rows[0][7].ToString())
                {
                    return 0; //Пароль правильный                   
                }
                else
                {
                    return 1; //Пароль не правильный                   
                }
            }
            else
            {
                return 2; //Запись не найдена              
            }
        }
    }
}
