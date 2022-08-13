using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using ContaBancaria.Models;

namespace ContaBancaria.Controllers
{
    internal class Database
    {
        SQLiteConnection conn = new SQLiteConnection("Data source=db.db");
        public SQLiteConnection OpenConection()
        {
            using (SQLiteConnection c = new SQLiteConnection(ConnectionString))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                    }
                }
            }
            conn.Open();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS conta(numero int, titular Varchar(50), primeiro_deposito Boolean, saldo Decimal)";
                cmd.ExecuteNonQuery();
            }
            return conn;
        }

        public DataSet GetAccounts(SQLiteConnection conn)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM conta", conn);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "info");
            return dset;
        }

        public Account GetAccountByAccountNumber(SQLiteConnection conn, int accounNumber)
        {
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM conta where numero = {accounNumber}", conn);
            SQLiteDataReader reader = command.ExecuteReader();
 
            while (reader.Read())
            {
                Account account = new Account();
                account.Titular = reader[1].ToString();
                account.Deposit = Decimal.Parse(reader[3].ToString());

                return account;
            }

            return null;
        }

        public string PostAccount(SQLiteConnection conn, Account account)
        {
            if (account.Titular != null)
            {
                SQLiteCommand command = new SQLiteCommand($"INSERT or IGNORE conta (numero, titular) VALUES ({account.Number}, '{account.Titular}')", conn);
                try
                {
                    command.ExecuteNonQuery();
                    return "Titular inserido com sucesso!";
                }
                catch (SQLiteException ex)
                {
                    return $"Erro ao atualizar o Titular - {ex.Message}";
                }
            }
            return "Nome do Titular não foi inserido!";
        }

        public string PutAccount(SQLiteConnection conn, Account account)
        {
            if (account.Titular != null && account.Deposit == 0) {
                string accountNumber = account.Number == 0 ? "null" : account.Number.ToString();
                SQLiteCommand command = new SQLiteCommand($"INSERT OR REPLACE into conta (numero, titular) VALUES ({accountNumber}, '{account.Titular}')", conn);
                try
                {
                    command.ExecuteNonQuery();
                    return "Titular atualizado com sucesso!";
                }
                catch (SQLiteException ex)
                {
                    return $"Erro ao atualizar o Titular - {ex.Message}";
                }
            }
            if (account.Deposit != 0)
            {
                string accountNumber = account.Number == 0 ? "null" : account.Number.ToString();
                decimal saldo = account.Deposit;
                if (accountNumber != "null") {
                    var readerAccount = GetAccountByAccountNumber(conn, Int32.Parse(accountNumber));
                    if (readerAccount != null)
                    {
                        saldo += readerAccount.Deposit;
                    }
                }
                SQLiteCommand command = new SQLiteCommand($"INSERT OR REPLACE into conta (numero, titular, primeiro_deposito, saldo) VALUES ({accountNumber}, '{account.Titular}', {account.FirstDeposit}, {saldo})", conn);
                try
                {
                    command.ExecuteNonQuery();
                    return "Titular atualizado com sucesso!";
                }
                catch (SQLiteException ex)
                {
                    return $"Erro ao atualizar o Titular - {ex.Message}";
                }
            }
            return "Nome do Titular não foi inserido!";
        }

        public string PutDeposit(SQLiteConnection conn, Account account)
        {
            if (account.Number != 0 && account.Deposit >= 0)
            {
                string queryTitular = $"titular = {account.Titular}";
                SQLiteCommand command = new SQLiteCommand($"UPDATE conta set titular = {queryTitular} where number = {account.Number}", conn);
                try
                {
                    command.ExecuteNonQuery();
                    return "Titular atualizado com sucesso!";
                }
                catch (SQLiteException ex)
                {
                    return $"Erro ao atualizar o Titular - {ex.Message}";
                }
            }
            return "Nome do Titular não foi inserido!";
        }

    }
}
