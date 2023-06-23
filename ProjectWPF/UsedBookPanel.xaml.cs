using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace ProjectWPF
{
    /// <summary>
    /// Interaction logic for UsedBookPanel.xaml
    /// </summary>
    public partial class UsedBookPanel : Window
    {
        public UsedBookPanel()
        {
            InitializeComponent();
            showdata();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Kiralanmış Kitapları SQL'den Getiriyor

        private void showdata()
        {
            SqlConnectionClass.connect.Open();

            SqlCommand commandshow = new SqlCommand("Select *from ReceivedBookTable", SqlConnectionClass.connect);

            SqlDataAdapter da = new SqlDataAdapter(commandshow);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dg.ItemsSource = dt.DefaultView;

            SqlConnectionClass.connect.Close();

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada İse Back Tuşuna Basınca Geri Gİtmemizi Sağlıyor

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel amp = new AdminPanel();
            amp.Show();
            this.Hide();
        }
    }
}
