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
using System.Data;


namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Sql'den Tabloyu Dolduruyor

        private void showrebates()
        {
            SqlConnectionClass.connect.Open();

            SqlCommand commadnshowrebates = new SqlCommand("Select *from ReturnTable", SqlConnectionClass.connect);

            SqlDataAdapter da = new SqlDataAdapter(commadnshowrebates);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dg.ItemsSource = dt.DefaultView;

            SqlConnectionClass.connect.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Sql'den Tabloyu Dolduruyor. Tabloda Gösteriyor

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblLogged.Text = GlobalVariables.loggedUN;
            showrebates();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Add Book Dendiği Zaman Kitabı Ekliyor

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            AddBookPanel abp = new AddBookPanel();
            this.Hide();
            abp.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Kitapları Gösteriyor

        private void btnshow_Click(object sender, RoutedEventArgs e)
        {
            BookDisplayPanel abp = new BookDisplayPanel();
            abp.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Mevcut Kullanılan Kitaplar Gösteriliyor

        private void btntook_Click(object sender, RoutedEventArgs e)
        {
            UsedBookPanel ubp = new UsedBookPanel();
            ubp.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Öğretmen Onayına Geçiş Yapıyor

        private void btnaccept_Click(object sender, RoutedEventArgs e)
        {
            TeacherApprovalPanel tap = new TeacherApprovalPanel();
            tap.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Exit Tuşuna Basınca MainWindowu Açıyor

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            GlobalVariables.loggedUN = null;
            GlobalVariables.loggedRank = null;
            lblLogged.Text = "";
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada İse Ayarlar SEkmesini Açıyor

        private void btnsettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsPanel sp = new SettingsPanel();
            sp.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada İse İadeyi Onaylıyor

        private void btnrebate_Click(object sender, RoutedEventArgs e)
        {
            ReturnConfirmationPanel rcp = new ReturnConfirmationPanel();
            rcp.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//


    }
}
