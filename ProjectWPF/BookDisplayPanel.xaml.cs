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
    /// Interaction logic for BookDisplayPanel.xaml
    /// </summary>
    public partial class BookDisplayPanel : Window
    {
        public BookDisplayPanel()
        {
            InitializeComponent();
            datashow();
        }

        string selectedid = " ";

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Verileri SQL'den Alıyor

        private void datashow()
        {
            oledbb = SqlConnectionClass.Oledbedit("Select *from LibraryBookTable");
            dg1.ItemsSource = oledbb.dataset.Tables[0].DefaultView;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Edit Book Kitabına Tıkladığımızda Kitabı Düzenliyor

        private void btnedit_Click(object sender, RoutedEventArgs e)
        {
            oledbb.adaptor.UpdateCommand = oledbb.builder.GetUpdateCommand();
            oledbb.adaptor.Update(oledbb.dataset);
            oledbb.dataset.AcceptChanges();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Delete Tuşuna Bastığımızda Kitabı Siliyor

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnectionClass.connect.Open();

                SqlCommand commanddelete = new SqlCommand("Delete from LibraryBookTable where ID=@id", SqlConnectionClass.connect);

                commanddelete.Parameters.AddWithValue("@id", selectedid);

                commanddelete.ExecuteNonQuery();

                SqlConnectionClass.connect.Close();

                MessageBox.Show("The book has been deleted");

                datashow();
            }
            catch
            {
                MessageBox.Show("Could not delete book");
            }


        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Back Tuşuna Bastığımızda Admin Paneline Geçiş Yapıyor

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel adm = new AdminPanel();
            adm.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Seçtiğimiz ID'nin(Kitabın) Değişmesini Sağlıyor

        private void dg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var vr1 = dg1.SelectedItem;

                System.Data.DataRowView vRow = (System.Data.DataRowView)vr1;
                if (vRow == null)
                {
                    return;
                }
                selectedid = vRow.Row.ItemArray.FirstOrDefault().ToString();

            }
            catch
            {
                return;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        OleDbClass oledbb;
    }

   
}

