using Storage_Project.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Storage_Project.Model
{
    public static class ConnectionDBStorage
    {
        public static string Connection { get; set; }
        public static SqlConnection sqlConnection;
        public static SqlDataReader dataReader;
        public static SqlDataAdapter dataAdapter;
        public static SqlCommand sqlCommand;

        public static void OpenConnection()
        {
            sqlConnection = new SqlConnection(Connection);
            sqlConnection.Open();
            sqlCommand = new SqlCommand();
        }
       
        public static void CloseConnection()
        {
            sqlConnection.Close();
        }

        public static void AddGoods(List<Good> goods)
        {
            SqlTransaction sqlTran = sqlConnection.BeginTransaction();
            sqlCommand.Transaction = sqlTran;
            sqlCommand.Connection = sqlConnection;
            try
            {
                for (int i = 0; i < goods.Count; i++)
                {
                    sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = goods[i]._Name;
                    sqlCommand.Parameters.Add("@Trademark", SqlDbType.VarChar).Value = goods[i]._Trademark;
                    sqlCommand.Parameters.Add("@Category", SqlDbType.VarChar).Value = goods[i]._Category;
                    sqlCommand.Parameters.Add("@Amount", SqlDbType.Int).Value = goods[i]._Amount;
                    sqlCommand.Parameters.Add("@Price", SqlDbType.Decimal).Value = goods[i]._Price;
                    sqlCommand.Parameters.Add("@Code", SqlDbType.Int).Value = goods[i]._Code;
                    sqlCommand.CommandText = "INSERT INTO Goods(Name,Trademark,Category,Amount,Price,Code)" +
                        "VALUES (@Name,@Trademark,@Category,@Price,@Amount,@Code)";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlTran.Commit();
            }
            catch(Exception ex)
            {
                sqlTran.Rollback();
                MessageBox.Show(ex.Message);
            }
        }
        public static void AddVendor(List<Vendor> vendors)
        {
            SqlTransaction sqlTran = sqlConnection.BeginTransaction();
            sqlCommand.Transaction = sqlTran;
            sqlCommand.Connection = sqlConnection;
            try
            {
                for (int i = 0; i < vendors.Count; i++)
                {
                    sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = vendors[i].Name;
                    sqlCommand.Parameters.Add("@Trademark", SqlDbType.VarChar).Value = vendors[i].Trademark;
                    sqlCommand.CommandText = "INSERT INTO Vendor(NAME,TRADEMARK)" +
                        "VALUES(@Name,@Trademark)";

                   
                    sqlCommand.ExecuteNonQuery();
                }
                sqlTran.Commit();
            }
            catch (Exception ex)
            {
                sqlTran.Rollback();
                MessageBox.Show(ex.Message);
            }
        }
        public static List<Vendor> GetVendorList()
        {
            List<Vendor> list = new List<Vendor>();
            try
            {
                sqlCommand.CommandText = "SELECT * FROM Vendor";
                sqlCommand.Connection= sqlConnection;
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(new Vendor(dataReader.GetString(1), dataReader.GetString(2)));
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        public static Vendor GetVendor (int index)
        {
            Vendor vendor = new Vendor();
            SqlTransaction sqlTransaction = null;
            try
            {
                sqlCommand.Parameters.Add("@Index2", SqlDbType.Int).Value = index;
                sqlTransaction = sqlConnection.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;
                
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT Vendor.NAME, Vendor.TRADEMARK FROM Vendor WHERE Vendor.ID = @Index2";
                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    vendor.Trademark = dataReader["TRADEMARK"].ToString();
                    vendor.Name = dataReader["NAME"].ToString();
                }
                dataReader.Close();
                
                sqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            return vendor;
        }
        //public static List<Good> GetGoodList()
        //{

        //}
    }
}
