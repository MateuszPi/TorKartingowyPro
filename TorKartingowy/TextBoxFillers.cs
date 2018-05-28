using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TorKartingowy
{
    class TextBoxFillers
    {
        SqlConnection con { get; set; }
        private void connectToDatabase()
        {
            con = new SqlConnection("Data Source=L-412-PC03;Initial Catalog=MPTor;Integrated Security=True");
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void FillTextBox(TextBox textBox, string table, string column, string condition)
        {
            SqlConnection con1 = new SqlConnection("Data Source=L-412-PC03;Initial Catalog=MPTor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {table} {condition}", con1);
            con1.Open();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while(read.Read())
                {
                    textBox.Text = (read[$"{column}"].ToString());
                }
            }
        }

        public void FillTextBlock(TextBlock textBlock, string table, string column, string condition)
        {
            SqlConnection con1 = new SqlConnection("Data Source=L-412-PC03;Initial Catalog=MPTor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {table} {condition}", con1);
            con1.Open();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    textBlock.Text = (read[$"{column}"].ToString());
                }
            }
        }

        public void GetOnTrack (TextBlock textBlock)
        {
            SqlConnection con1 = new SqlConnection("Data Source=L-412-PC03;Initial Catalog=MPTor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(ID_Ride) AS count FROM Ride WHERE OnTrack = 1", con1);
            con1.Open();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    textBlock.Text = (read["count"].ToString());
                }
            }
        }



    }
}
