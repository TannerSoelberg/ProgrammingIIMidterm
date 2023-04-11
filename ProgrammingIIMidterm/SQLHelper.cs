using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingIIMidterm
{
    public static class SQLHelper
    {
        static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TEMP.WSCCNET.046\Downloads\ProgrammingIIMidterm\ProgrammingIIMidterm\ATMDatabase.mdf;Integrated Security=True";

        //Private Methods
        /// <summary>
        /// This method attaches a CheckingAccount and SavingsAccount to any given ATMUser, assuming they have data.
        /// </summary>
        /// <param name="CurrentUser"> An ATMUser object that should have related database data. </param>
        /// <returns> A CheckingAccount and SavingsAccount that relate to the given CurrentUser. </returns>
        private static (CheckingAccount, SavingsAccount) GetUser(ATMUser CurrentUser)
        {
            string SearchString = String.Format("Account_Number = '{0}' or Account_Number = '{1}'", CurrentUser.CheckingNum, CurrentUser.SavingsNum);

            String Sql = "";

            if (SearchString != "")
            {
                Sql = "Select * from Account where " + SearchString;
            }

            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            SqlCommand Command = new SqlCommand(Sql, Connection);

            SqlDataReader DataReader = Command.ExecuteReader();

            CheckingAccount NewChecking = null;
            SavingsAccount NewSavings = null;

            while (DataReader.Read())
            {
                if (int.Parse(DataReader.GetValue(0).ToString()) == CurrentUser.CheckingNum)
                {
                    NewChecking = new CheckingAccount(decimal.Parse(DataReader.GetValue(1).ToString()),0);
                }
                else if (int.Parse(DataReader.GetValue(0).ToString()) == CurrentUser.SavingsNum)
                {
                    NewSavings = new SavingsAccount(decimal.Parse(DataReader.GetValue(1).ToString()), 0);
                }
            }

            return (NewChecking, NewSavings);
        }

        //Public Methods
        /// <summary> 
        /// This method checks login info to see if it matches database login info. If so, it returns the CurrentUser object to be used further.
        /// </summary>
        /// <param name="CurrentUser"> Inputted CurrentUser object with password dated. </param>
        /// <returns> A CurrentUser object with its assigned Checking and Savings accounts. </returns>
        public static ATMUser CheckLogin(ATMUser CurrentUser)
        {
            string SearchString = String.Format("Customer_Number = '{0}' and PIN = '{1}'", CurrentUser.CustId, CurrentUser.Pin);

            String Sql = "";

            if (SearchString != "")
            {
                Sql = "Select * from BankCustomer where " + SearchString;
            }

            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            SqlCommand Command = new SqlCommand(Sql, Connection);

            SqlDataReader DataReader = Command.ExecuteReader();

            while (DataReader.Read())
            {
                CurrentUser.CheckingNum = int.Parse(DataReader.GetValue(2).ToString());
                CurrentUser.SavingsNum = int.Parse(DataReader.GetValue(3).ToString());

                var Tuple = GetUser(CurrentUser);

                CurrentUser.CheckingAccount = Tuple.Item1;
                CurrentUser.SavingsAccount = Tuple.Item2;

                return (CurrentUser);
            }

            return (null);
        }

        /// <summary>
        /// This method updates the Account database for both the CheckingAccount and SavingsAccount, using data from the passed ATMUser.
        /// </summary>
        /// <param name="CurrentUser"> An ATMUser object with an attached CheckingAccount and SavingsAccount. </param>
        /// <returns> the CurrentUser object. </returns>
        public static ATMUser UpdateUser(ATMUser CurrentUser)
        {
            String Sql = "Update Account set Balance = " + CurrentUser.CheckingAccount.Balance.ToString() + " where Account_Number = " + CurrentUser.CheckingNum.ToString()+ "\nUpdate Account set Balance = " + CurrentUser.SavingsAccount.Balance.ToString() + " where Account_Number = " + CurrentUser.SavingsNum.ToString();

            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            SqlDataAdapter Adapter = new SqlDataAdapter();
            SqlCommand Command = new SqlCommand(Sql, Connection);

            Adapter.UpdateCommand = new SqlCommand(Sql, Connection);
            Adapter.UpdateCommand.ExecuteNonQuery();

            Command.Dispose();
            Connection.Close();

            return (CurrentUser);
        }
    }
}
