using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows.Navigation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Data.SqlClient;
using System.Windows.Shapes;
using System.Data;



namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            updatebookdn();
        }

        private DateTime downTime;
        private object downSender;

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kodlar Çarpıya Basılınca Uygulamadan Çıkış İşlemini Gerçekleştiriyor (İnternette WPF Mouse Click Bulamadığım İçin Böyle Yaptım Hocam)

        private void btnClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.downSender = sender;
                this.downTime = DateTime.Now;
            }
        }

        private void btnClose_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released &&
            sender == this.downSender)
            {
                TimeSpan timeSinceDown = DateTime.Now - this.downTime;
                if (timeSinceDown.TotalMilliseconds < 500)
                {
                    Environment.Exit(0);
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kodlar Username ve Password Box'a 2 Kere Tıklanınca Varsayılan Yazıları Siliyor

        private void txtUsername_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (txtboxLogUN.Text == "Username") // Yandaki kod eğer textbox da "Username" yazıyorsa tıklandığı zaman sil komutunu gösteriyor.
            {
                txtboxLogUN.Clear();
            }
        }

        private void PasswordBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (pboxlogin.Password == "*********") // Yandaki kod eğer PasswordBox da "*********" yazıyorsa tıklandığı zaman sil komutunu gösteriyor.
            {
                pboxlogin.Clear();
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kodlar Image Dosyasına Tıklandığı Zaman Url Adreslerini Açmayı Sağlar

        private void ImageInstagram_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string url = "https://www.instagram.com/alitekn07/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void ImageTwitter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string url = "https://twitter.com/alitekn07";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void ImageGithub_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string url = "https://github.com/alitekn07";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void ImageLinkedIn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string url = "https://www.linkedin.com/in/alitekn07/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//


        // Buradaki Kod Register Tuşuna Basılınca Register Sayfasını Açmayı Sağlar

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow rw = new RegisterWindow();
            this.Hide();
            rw.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kod Kitapları Güncellemeyi Sağlıyor
        private void updatebookdn()
        {
            SqlConnectionClass.connect.Open();

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

        // Buradaki Kod Panele Kim Olarak Giriş Yaptığımızı Gösteriyor
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string UN = txtboxLogUN.Text.Trim();
            string password = Encode.ComputeSha256Hash(pboxlogin.Password.Trim());
            logcontrol(UN, password);
            if (GlobalVariables.loggedRank == "1")
            {
                MessageBox.Show("Signed In As A Admin");
                AdminPanel ap = new AdminPanel();
                ap.Show();
                this.Hide();
            }
            else if (GlobalVariables.loggedRank == "3")
            {
                MessageBox.Show("Signed In As A student");
                StudentPanel oop = new StudentPanel();
                oop.Show();
                this.Hide();
            }
            else if (GlobalVariables.loggedRank == "2")
            {
                MessageBox.Show("Signed In As A Teacher");
                StudentPanel oop = new StudentPanel();
                oop.Show();
                this.Hide();
            }
            else if (GlobalVariables.loggedRank == null)
            {
                MessageBox.Show("User Not Found");
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kod Log Kayıtlarını Tutmamızı Sağlıyor

        private void logcontrol(string tempUN, string temppas)
        {

            SqlConnectionClass.connect.Open();
            string commandtask = "Select *from LibraryUserTable where LoginInfo=@gbi and Password=@sifi";
            SqlCommand commandlog = new SqlCommand(commandtask, SqlConnectionClass.connect);
            commandlog.Parameters.AddWithValue("@gbi", tempUN);
            commandlog.Parameters.AddWithValue("@sifi", temppas);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandlog);
            da.Fill(dt);


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Incorrect Entry");
                GlobalVariables.loggedUN = null;
                GlobalVariables.loggedRank = null;

                SqlConnectionClass.connect.Close();
                return;
            }
            else
            {
                DataRow dr = dt.Rows[0];
                MessageBox.Show("Login Successful");
                GlobalVariables.loggedUN = tempUN;
                GlobalVariables.loggedRank = dr["Rank"].ToString();

            }



            SqlConnectionClass.connect.Close();



        }
    }
}
