using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;



namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for SettingsPanel.xaml
    /// </summary>
    public partial class SettingsPanel : Window
    {
        public SettingsPanel()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Yapılan Değişiklikleri SQL'den Değiştiriyor
        private void editdays()
        {
            SqlConnectionClass.connect.Open();

            SqlCommand commandedit = new SqlCommand("Update Settings set NumberofBooks=@num,BookDuration=@time where ID=0", SqlConnectionClass.connect);

            commandedit.Parameters.AddWithValue("@num", txtboxnum.Text);
            commandedit.Parameters.AddWithValue("@time", txtboxday.Text);

            commandedit.ExecuteNonQuery();

            SqlCommand commandreader = new SqlCommand("Select *from Settings", SqlConnectionClass.connect);

            SqlDataReader dr = commandreader.ExecuteReader();

            while (dr.Read())
            {
                GlobalVariables.booknum = Convert.ToInt32(dr[1]);
                GlobalVariables.bookday = Convert.ToInt32(dr[2]);
            }

            dr.Close();

            SqlConnectionClass.connect.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buraya Tıklayınca Yapılan Değişiklikler Kaydediliyor

        private void btnedit_Click(object sender, RoutedEventArgs e)
        {
            editdays();
            MessageBox.Show("Settings saved successfully");
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buna Basınca İse Geriye Gidiyor

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel amp = new AdminPanel();
            amp.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//
    }
}
