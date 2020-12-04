using System;
using System.Data;
using System.Data.SqlClient;

namespace VideoRentalSys
{
    //declaring the inerface 
    public interface Insert
    {
        // Declareing the Method in the Interface
        void InsDelUpdt(String qry);
        DataTable Srch(String qry);
    }
    //implements the interface
    public class Database : Insert
    {
        //global declaration of the variable 
        SqlConnection connection;
        String connection_String = @"Data Source=PSINGH-PC\SQLEXPRESS;Initial Catalog=Video_Rental_Sys;Integrated Security=True";
        SqlCommand command;
        SqlDataReader Datareader;

        // implemtneting the method of the interface
        //using the concept of oops define a single method that is used to insert delete and update the record in the table 
        public void InsDelUpdt(String qry)
        {

            connection = new SqlConnection(connection_String);
            connection.Open();
            command = new SqlCommand(qry, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        // user define method that is used to get the record from the table
        public DataTable Srch(String qry)
        {
            DataTable tbl = new DataTable();


            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            Datareader = command.ExecuteReader();

            tbl.Load(Datareader);

            connection.Close();

            return tbl;
        }

    }
}
