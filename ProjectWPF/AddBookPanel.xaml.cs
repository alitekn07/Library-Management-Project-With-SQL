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
    /// Interaction logic for AddBookPanel.xaml
    /// </summary>
    public partial class AddBookPanel : Window
    {
        public AddBookPanel()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Kitabı SQL'e Kaydediyor
        private void adddata()
        {
            try
            {

                SqlConnectionClass.connect.Open();

                SqlCommand commandadd = new SqlCommand("Insert into LibraryBookTable (BookName,BookPage,Category,Writer,BookYear,NumberofBooks) values (@adi,@nosu,@categ,@author,@year,@numu)", SqlConnectionClass.connect);

                commandadd.Parameters.AddWithValue("@adi", txtboxname.Text);
                commandadd.Parameters.AddWithValue("@nosu", txtboxps.Text);
                commandadd.Parameters.AddWithValue("@categ", txtboxcateg.Text);
                commandadd.Parameters.AddWithValue("@author", txtboxauthor.Text);
                commandadd.Parameters.AddWithValue("@year", txtboxyear.Text);
                commandadd.Parameters.AddWithValue("@numu", txtboxnumbook.Text);
                commandadd.ExecuteNonQuery();

                SqlConnectionClass.connect.Close();

                MessageBox.Show("Book successfully added");
            }
            catch
            {
                MessageBox.Show("The book could not be added!");
            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Save Dediğimiz Zaman Kitabı Kaydediyor

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            adddata();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Open Book Tuşuna Bastığımız Zaman Listeyi Açıyor

        private void btnopenlist_Click(object sender, RoutedEventArgs e)
        {
            BookDisplayPanel kpm = new BookDisplayPanel();
            kpm.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Back Tuşuna Basınca Admin Paneline Götürüyor

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel apm = new AdminPanel();
            apm.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//
    }
}
