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
    /// Interaction logic for ReceivedBookPanel.xaml
    /// </summary>
    public partial class ReceivedBookPanel : Window
    {
        public ReceivedBookPanel()
        {
            InitializeComponent();
            showdata();
        }

        string selectedid = " ";
        OleDbClass oledbb;

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        //Burada Data Dosyalarını Gösteriyor
        private void showdata()
        {
            oledbb = SqlConnectionClass.Oledbedit("Select * from ReceivedBookTable where BookTakerUser='" + GlobalVariables.loggedUN + "' ");
            dg1.ItemsSource = oledbb.dataset.Tables[0].DefaultView;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Back Tuşuna Basınca Student Paneline Götürüyor
        private void btnbback_Click(object sender, RoutedEventArgs e)
        {
            StudentPanel ssp = new StudentPanel();
            ssp.Show();
            this.Hide();
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        //Burada Kitabı İade Ediyor
        private void btnrebate_Click(object sender, RoutedEventArgs e)
        {
            rebate();
            GlobalVariables.bookname = null;
            MessageBox.Show("Book successfully returned");
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        //Burada Kitabı İade Ediyor SQL Kodları

        private void rebate()
        {
            try
            {
                SqlConnectionClass.connect.Open();

                SqlCommand commanddelete = new SqlCommand("Delete from ReceivedBookTable where ID=@idi and BookTakerUser=@user", SqlConnectionClass.connect);
                SqlCommand commandadd = new SqlCommand("Insert into ReturnTable (BookReturn,PersonReturn) values  (@book,@user)", SqlConnectionClass.connect);
                SqlCommand commandread = new SqlCommand("Select ReceivedBookName from ReceivedBookTable where ID=@idi", SqlConnectionClass.connect);

                commandread.Parameters.AddWithValue("@idi", selectedid);

                SqlDataReader dr = commandread.ExecuteReader();

                while (dr.Read())
                {
                    GlobalVariables.bookname = dr[0].ToString();
                }


                commandadd.Parameters.AddWithValue("@book", GlobalVariables.bookname);
                commandadd.Parameters.AddWithValue("@user", GlobalVariables.loggedUN);
                commanddelete.Parameters.AddWithValue("@idi", selectedid);
                commanddelete.Parameters.AddWithValue("@user", GlobalVariables.loggedUN);

                dr.Close();

                commandadd.ExecuteNonQuery();
                commanddelete.ExecuteNonQuery();
                SqlConnectionClass.connect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Click on the book you want to return");
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        // Burada Menüden Gösteriyor Kitabları Tablodan
        private void dg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var vr1 = dg1.SelectedItem;

                System.Data.DataRowView vRow = (System.Data.DataRowView)vr1;
                selectedid = vRow.Row.ItemArray.FirstOrDefault().ToString();
            }
            catch
            {
                return;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------//
    }
}
