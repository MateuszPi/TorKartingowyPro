using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TorKartingowy
{
    class DatabaseInput
    {
        SqlConnection con { get; set; }

        private void connectToDatabase()
        {
            con = new SqlConnection("Data Source=MP-PC1;Initial Catalog=MPTor;Integrated Security=True");
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ZmianyZarzadzanie (string CenaN, string CenaU, string CenaNP, string CenaUP, string CenaRH, string CenaRK, int Layout)
        {
            SqlConnection con1 = new SqlConnection("Data Source=MP-PC1;Initial Catalog=MPTor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"UPDATE [dbo].[PriceList] SET[Price] = {CenaN} WHERE ID_Price = 0" +
                $"UPDATE [dbo].[PriceList] SET[Price] = {CenaU} WHERE ID_Price = 1" +
                $"UPDATE [dbo].[PriceList] SET[Price] = {CenaNP} WHERE ID_Price = 2" +
                $"UPDATE [dbo].[PriceList] SET[Price] = {CenaUP} WHERE ID_Price = 3" +
                $"UPDATE [dbo].[PriceList] SET[Price] = {CenaRH} WHERE ID_Price = 4" +
                $"UPDATE [dbo].[PriceList] SET[Price] = {CenaRK} WHERE ID_Price = 5" +
                $"UPDATE [dbo].[Layout] SET[IsActive] = 0 WHERE IsActive = 1" +
                $"UPDATE[dbo].[Layout] SET[IsActive] = 1 WHERE ID_Layout = {Layout}", con1);
            con1.Open();
            cmd.ExecuteNonQuery();

        }

        public void WydajBilet (string PricePH, string PrePaid, string IdCustomer = "0", string IdKart = "0")
        {
            SqlConnection con1 = new SqlConnection("Data Source=MP-PC1;Initial Catalog=MPTor;Integrated Security=True");
            PricePH = PricePH.Replace(",", ".");
            PrePaid = PrePaid.Replace(",", ".");

            SqlCommand cmd = new SqlCommand($"INSERT INTO [dbo].[Ride] ([PricePH], [PrePaid], [ID_Customer], [OnTrack], [StartingTime])" +
                                            $"VALUES({PricePH}, {PrePaid}, {IdCustomer}, 1, GETDATE());", con1);
            con1.Open();
            cmd.ExecuteNonQuery();
        }

        public int DajIdBiletu()
        {
            SqlConnection con1 = new SqlConnection("Data Source=MP-PC1;Initial Catalog=MPTor;Integrated Security=True");
            SqlDataReader dR;
            string ret = "";
            SqlCommand cmd = new SqlCommand($"SELECT TOP 1 ID_Ride FROM Ride ORDER BY StartingTime DESC", con1);
            con1.Open();
            dR = cmd.ExecuteReader();
            while (dR.Read())
            {
                ret = (dR[$"ID_Ride"].ToString());
            }
            return Convert.ToInt32(ret);
        }

        public bool SprawdzNkk (string NKK)
        {
            if (NKK == "")
            {
                NKK = "0";
            }

            SqlConnection con1 = new SqlConnection("Data Source=MP-PC1;Initial Catalog=MPTor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Customer WHERE ID_Customer = {NKK}", con1);
            con1.Open();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    return true;
                }
            }
            return false;

        }




    }
}
