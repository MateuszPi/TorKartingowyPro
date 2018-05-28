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

        public void ZmianyZarzadzanie (string CenaN, string CenaU, string CenaNP, string CenaUP, string CenaRH, string CenaRK, int Layout)
        {
            SqlConnection con1 = new SqlConnection("Data Source=L-412-PC03;Initial Catalog=MPTor;Integrated Security=True");
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






    }
}
