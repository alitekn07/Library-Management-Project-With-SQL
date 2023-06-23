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
    /// Interaction logic for BookRetrievalPanel.xaml
    /// </summary>
    public partial class BookRetrievalPanel : Window
    {
        public BookRetrievalPanel()
        {
            InitializeComponent();
        }

        OleDbClass oledbb;

        string selectedID = " ";

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Üst Tarafta Kütüphanedeki Kitapları Gösteriyor

        private void showdata()
        {
            SqlConnectionClass.connect.Open();

            SqlCommand commandshow = new SqlCommand("Select *from LibraryBookTable", SqlConnectionClass.connect);

            SqlDataAdapter da = new SqlDataAdapter(commandshow);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dg1.ItemsSource = dt.DefaultView;

            SqlConnectionClass.connect.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Kitapların Adedini Gösteriyor

        private void showdata2()
        {
            SqlConnectionClass.connect.Open();

            SqlCommand commandshow = new SqlCommand("Select *from LibraryBookTable where NumberofBooks!=0", SqlConnectionClass.connect);

            SqlDataAdapter da = new SqlDataAdapter(commandshow);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dg1.ItemsSource = dt.DefaultView;

            SqlConnectionClass.connect.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada İstenilen Kitabı Database'de Arıyor

        private void datasearch()
        {

            SqlConnectionClass.connect.Open();

            SqlCommand commandsearch = new SqlCommand("Select *from LibraryBookTable where BookName like '%" + txtboxname.Text + "%' and Category like '%" + txtboxcateg.Text + "%' and Writer like '%" + txtboxauthor.Text + "%' and  BookName like '%" + txtboxchar.Text + "%' ", SqlConnectionClass.connect);

            SqlDataAdapter da = new SqlDataAdapter(commandsearch);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dg1.ItemsSource = dt.DefaultView;

            SqlConnectionClass.connect.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Search Tuşuna Bastığımızda Kitabımızı Arıyoruz

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            datasearch();
            oledbb = SqlConnectionClass.Oledbedit("select * from LibraryBookTable");
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Rent Book Tuşuna Bastığımızda Kitabımızı Kiralıyoruz

        private void btnget_Click(object sender, RoutedEventArgs e)
        {
            getbook();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Back Tuşuna Basarak Student Paneline Gidiyoruz

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            StudentPanel oop = new StudentPanel();
            oop.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Kütüphanedeki Bitirdiğimiz Kitapları Listeye Katıp Katmamızı Sağlıyor

        private void checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            showdata();
            oledbb = SqlConnectionClass.Oledbedit("select * from LibraryBookTable");
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Kütüphanedeki Bitirdiğimiz Kitapları Listeye Katıp Katmamızı Sağlıyor

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            showdata2();
            oledbb = SqlConnectionClass.Oledbedit("select * from LibraryBookTable");
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Üstteki Ekranda Kitaplarımızı Görmemizi Sağlıyoruz

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            showdata();
            oledbb = SqlConnectionClass.Oledbedit("select * from LibraryBookTable");
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Kitapları Gösterme Paneli

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
                selectedID = vRow.Row.ItemArray.FirstOrDefault().ToString();

            }
            catch
            {
                return;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Rent Book Tuşuna Bastığımızda Sırayla Yapılan İşlemi Gösteriyor Hocam

        private void getbook()
        {
            SqlConnectionClass.connect.Open();

            SqlCommand commandreader = new SqlCommand("Select  *from LibraryBookTable where ID=@idi", SqlConnectionClass.connect);

            commandreader.Parameters.AddWithValue("@idi", selectedID);

            SqlDataReader dr = commandreader.ExecuteReader();

            while (dr.Read())
            {
                GlobalVariables.bookname = dr[1].ToString();
                int booknum = Convert.ToInt32(dr[6]);
                if (booknum == 0)
                {
                    MessageBox.Show("The book you requested is not left in the system ");
                    SqlConnectionClass.connect.Close();
                    return;
                }

            }

            dr.Close();



            SqlCommand commandreadbooknum = new SqlCommand("Select *from ReceivedBookTable where BookTakerUser=@user", SqlConnectionClass.connect);

            commandreadbooknum.Parameters.AddWithValue("@user", GlobalVariables.loggedUN);

            SqlDataAdapter da = new SqlDataAdapter(commandreadbooknum);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (Convert.ToInt32(dt.Rows.Count) >= GlobalVariables.booknum && Convert.ToInt32(GlobalVariables.loggedRank) == 3)
            {
                MessageBox.Show($"A user can buy a maximum of {GlobalVariables.booknum} books");
                SqlConnectionClass.connect.Close();
                return;
            }

            SqlCommand commandsubs = new SqlCommand("Update LibraryBookTable set NumberofBooks-=1 where BookName=@adi", SqlConnectionClass.connect);

            commandsubs.Parameters.AddWithValue("@adi", GlobalVariables.bookname);



            SqlCommand commandadd = new SqlCommand("Insert into ReceivedBookTable (BookReceiptDate,BookTakerUser,ReceivedBookName) values (@date,@user,@book)", SqlConnectionClass.connect);

            commandadd.Parameters.AddWithValue("@date", DateTime.Now);

            commandadd.Parameters.AddWithValue("@user", GlobalVariables.loggedUN);

            commandadd.Parameters.AddWithValue("@book", GlobalVariables.bookname);

            commandadd.ExecuteNonQuery();

            commandsubs.ExecuteNonQuery();

            SqlConnectionClass.connect.Close();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//
    }
}
