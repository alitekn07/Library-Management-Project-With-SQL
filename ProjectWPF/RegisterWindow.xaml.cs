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
using System.Data;
using System.Data.SqlClient;

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kodlar SQL'den Veri Almamızı Sağlıyor

        private void savedata()
        {
            SqlConnectionClass.connect.Open();

            SqlCommand commandsave = new SqlCommand("Insert into LibraryUserTable (LoginInfo,Password,Name,Surname) Values (@gbi,@sifi,@name,@surname)", SqlConnectionClass.connect);
            SqlCommand commandcontrol = new SqlCommand("Select LoginInfo from LibraryUserTable", SqlConnectionClass.connect);

            SqlDataReader dr = commandcontrol.ExecuteReader();

            while (dr.Read())
            {
                if (dr["LoginInfo"].ToString() == txtboxRegUN.Text)
                {
                    MessageBox.Show("There Is Already A Registered User With This Information");
                    SqlConnectionClass.connect.Close();
                    return;
                }
            }

            dr.Close();

            commandsave.Parameters.AddWithValue("@gbi", txtboxRegUN.Text.Trim());
            commandsave.Parameters.AddWithValue("@sifi", Encode.ComputeSha256Hash(pboxreg.Password.Trim()));
            commandsave.Parameters.AddWithValue("@name", txtboxname.Text.Trim());
            commandsave.Parameters.AddWithValue("@surname", txtboxsurname.Text.Trim());

            commandsave.ExecuteNonQuery();

            SqlConnectionClass.connect.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kodlar Eğer Girilen Şifre Doğru İse Kaydımızı Yapıyor Yanlış İse Şifreler Aynı Değil Diye Uyarı Veriyor

        private void btnRegisterwin_Click(object sender, RoutedEventArgs e)
        {
            if (pboxreg.Password != pboxregag.Password)
            {
                MessageBox.Show("Passwords Are Not The Same");
            }
            else
            {
                savedata();
                MessageBox.Show("Your Registration Has Been Successful");
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kod Sağ Üstte Geri Tuşuna Basıldığı Zaman Anasayfaya Gitmemizi Sağlıyor

        private void btnback_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Hide();
            mw.Show();
        }



        //--------------------------------------------------------------------------------------------------------------------------------------------------//
    }
}
