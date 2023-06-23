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
    /// Interaction logic for ReturnConfirmationPanel.xaml
    /// </summary>
    public partial class ReturnConfirmationPanel : Window
    {
        public ReturnConfirmationPanel()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // İade Edilecek Kitap Bilgilerini SQL'den Çekiyoruz Burada
        private void approval()
        {

            SqlConnectionClass.connect.Open();

            SqlCommand commandagree = new SqlCommand("Delete from ReturnTable where ID=@idi", SqlConnectionClass.connect);
            SqlCommand commandname = new SqlCommand("Select BookReturn from ReturnTable where ID=@idi", SqlConnectionClass.connect);



            commandname.Parameters.AddWithValue("@idi", txtboxId.Text.ToString());
            commandagree.Parameters.AddWithValue("@idi", txtboxId.Text);

            SqlDataReader dr = commandname.ExecuteReader();

            while (dr.Read())
            {
                GlobalVariables.bookname = dr[0].ToString();
            }

            dr.Close();

            SqlCommand commandadd = new SqlCommand("Update LibraryBookTable set NumberofBooks+=1 where BookName=@adi", SqlConnectionClass.connect);

            commandadd.Parameters.AddWithValue("@adi", GlobalVariables.bookname.ToString());
            commandadd.ExecuteNonQuery();
            commandagree.ExecuteNonQuery();

            SqlConnectionClass.connect.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Back Tuşuna Basınca Admin Paneline Gitmemiz Sağlanıyor

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel amp = new AdminPanel();
            amp.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Approve Tuşuna Basılınca Kitabımızı İade Edebiliyoruz

        private void btnagree_Click(object sender, RoutedEventArgs e)
        {
            approval();
            MessageBox.Show("Successfully returned");
            GlobalVariables.bookname = null;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//
    }
}
