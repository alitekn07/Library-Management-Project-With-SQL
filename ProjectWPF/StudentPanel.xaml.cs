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
    /// Interaction logic for StudentPanel.xaml
    /// </summary>
    public partial class StudentPanel : Window
    {
        public StudentPanel()
        {
            InitializeComponent();
            bookcontrol();
            lblLogged.Text = GlobalVariables.loggedUN;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Back Tuşuna Bastığımızda Önceki Sayfaya Gitmemizi Sağlıyor Hocam (Bu Sayfayı Gizliyor MainWindow'u Yani Anasayfamızı Açıyor)
        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada İse Return The Book'a Tıkladığımızda Kitabımızı İade Ediyoruz

        private void btnrebate_Click(object sender, RoutedEventArgs e)
        {
            ReceivedBookPanel ood = new ReceivedBookPanel();
            ood.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Kiraladığımız Kitapları Gösteriyor
        private void btntookbooks_Click(object sender, RoutedEventArgs e)
        {
            ReceivedBookPanel aap = new ReceivedBookPanel();

            aap.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Son Olarak Burada Rent Book Tuşuna Bastığımızda Kitap Kiralamamızı Sağlıyor

        private void btngetbook_Click(object sender, RoutedEventArgs e)
        {
            BookRetrievalPanel ktp = new BookRetrievalPanel();
            ktp.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Kitap Hakkında Bilgileri Görmemize Olanak Sağlıyor. Ne Zaman Kiralandı Ne Kadar Zamanı Kaldı..vs

        private void bookcontrol()
        {
            SqlConnectionClass.connect.Open();

            SqlCommand commandcontrol = new SqlCommand("Select *from ReceivedBookTable where BookTakerUser=@user", SqlConnectionClass.connect);

            commandcontrol.Parameters.AddWithValue("@user", GlobalVariables.loggedUN);

            SqlDataAdapter da = new SqlDataAdapter(commandcontrol);

            DataTable dt = new DataTable();

            da.Fill(dt);



            System.TimeSpan timedifference;

            if (dt.Rows.Count > 0 && Convert.ToInt32(GlobalVariables.loggedRank) == 3)
            {
                int MyCounter = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    DateTime dtbook = Convert.ToDateTime(dt.Rows[MyCounter][1]);
                    timedifference = DateTime.Now.Subtract(dtbook);
                    int difference = Convert.ToInt32(timedifference.Days);
                    if (Convert.ToInt32(difference) >= GlobalVariables.bookday)
                    {
                        string tempbookname = dt.Rows[MyCounter][3].ToString().Trim();
                        MessageBox.Show($"{tempbookname} Titled Book has expired, please return it.");
                    }
                    MyCounter += 1;
                }

            }

            SqlConnectionClass.connect.Close();
        }


    }
 }

