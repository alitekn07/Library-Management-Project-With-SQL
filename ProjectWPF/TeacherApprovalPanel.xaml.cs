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
    /// Interaction logic for TeacherApprovalPanel.xaml
    /// </summary>
    public partial class TeacherApprovalPanel : Window
    {
        public TeacherApprovalPanel()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kodlar SQL'deki Rank Seviyelerini Güncellememizi Sağlıyor
        private void editdata()
        {
            SqlConnectionClass.connect.Open();

            SqlCommand commandeditrank = new SqlCommand("Update LibraryUserTable set Rank=2 where LoginInfo=@gbi", SqlConnectionClass.connect);

            commandeditrank.Parameters.AddWithValue("@gbi", txtboxvalue.Text.Trim());

            commandeditrank.ExecuteNonQuery();

            SqlConnectionClass.connect.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kod Edit Tuşuna Basınca Kullanıcıyı Öğretmen Derecesine Yükseltiyor Hocam

        private void btnedit_Click(object sender, RoutedEventArgs e)
        {
            editdata();
            MessageBox.Show("User Successfully Upgraded To Teacher Rank.");
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Buradaki Kod Geri Tuşuna Basınca Geri Gitmemizi Sağlıyor

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel amp = new AdminPanel();
            amp.Show();
            this.Hide();
        }
    }
}
