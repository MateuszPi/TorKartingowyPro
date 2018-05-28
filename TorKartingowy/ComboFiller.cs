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
    class ComboFiller
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

        public void DajTypyKartow(ComboBox TypKartow)
        {
            SqlConnection con1 = new SqlConnection("Data Source=L-412-PC03;Initial Catalog=MPTor;Integrated Security=True");
            //connectToDatabase();
            SqlCommand cmd = new SqlCommand("SELECT * FROM KartType", con1);
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dT = new DataSet();
            con1.Open();
            dA.Fill(dT);
            TypKartow.ItemsSource = dT.Tables[0].DefaultView;
            TypKartow.DisplayMemberPath = dT.Tables[0].Columns["KartType"].ToString();
            TypKartow.SelectedValuePath = dT.Tables[0].Columns["ID_KartType"].ToString();
        }

        public void DajTypBiletu(ComboBox TypBiletu)
        {
            SqlConnection con1 = new SqlConnection("Data Source=L-412-PC03;Initial Catalog=MPTor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM PriceList", con1);
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dT = new DataSet();
            con1.Open();
            dA.Fill(dT);
            TypBiletu.ItemsSource = dT.Tables[0].DefaultView;
            TypBiletu.DisplayMemberPath = dT.Tables[0].Columns["PriceName"].ToString();
            TypBiletu.SelectedValuePath = dT.Tables[0].Columns["ID_Price"].ToString();
        }

        public void DajKart(ComboBox Kart, int IdKartType)
        {
            SqlConnection con1 = new SqlConnection("Data Source=L-412-PC03;Initial Catalog=MPTor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Kart WHERE ID_KartType = {IdKartType}", con1);
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dT = new DataSet();
            con1.Open();
            dA.Fill(dT);
            Kart.ItemsSource = dT.Tables[0].DefaultView;
            Kart.DisplayMemberPath = dT.Tables[0].Columns["ID_Kart"].ToString();
            Kart.SelectedValuePath = dT.Tables[0].Columns["ID_Kart"].ToString();
        }

        public void DajLayout(ComboBox Kart, int IdKartType)
        {
            SqlConnection con1 = new SqlConnection("Data Source=L-412-PC03;Initial Catalog=MPTor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Layout WHERE ID_KartType = {IdKartType}", con1);
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            DataSet dT = new DataSet();
            con1.Open();
            dA.Fill(dT);
            Kart.ItemsSource = dT.Tables[0].DefaultView;
            Kart.DisplayMemberPath = dT.Tables[0].Columns["ID_Kart"].ToString();
            Kart.SelectedValuePath = dT.Tables[0].Columns["ID_Kart"].ToString();
        }


    }
}
