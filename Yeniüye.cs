using E_Kitap.Models;
using E_Kitap.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace E_Kitap
{
    public partial class Yeniüye : Form
    {
        

        SqlConnection baglanti = new SqlConnection("Server = localhost; Database = EternalOdev4; uid = sa; pwd = 123" );
        SqlCommand komut = new SqlCommand();
        int[] sayılar = new int[10];
        string kitapurl;        
        int kullaniciid;
        public string username { get; set; }
        public object id { get; private set; }

        private UserService _userService;
        private VoteService _voteService;
        private BookService _bookService;
       

        private string KitapResim(int id)
        {

            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;
            SqlDataReader reader;

            connetionString = "Server = localhost; Database = EternalOdev4; uid = sa; pwd = 123";
            sql = $"Select URL from Books where Id='{id}'";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                kitapurl = reader.GetString(0);

            }
            reader.Close();
            cmd.Dispose();
            cnn.Close();
            return kitapurl;
        }

        public int KullaniciID(string kullaniciadi)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            string sql = null;
            SqlDataReader reader;

            connetionString = "Server = localhost; Database = EternalOdev4; uid = sa; pwd = 123" ;
            sql = $"Select Id from Users where Kullaniciadi='{kullaniciadi}'";

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                kullaniciid = reader.GetInt32(0);

            }
            reader.Close();
            cmd.Dispose();
            cnn.Close();
            return kullaniciid;
        }

        

       

        public Yeniüye()
        {
            
            InitializeComponent();            
           _userService = new UserService();
            _voteService = new VoteService();
            _bookService = new BookService();
        }

        private void Yeniüye_Load(object sender, EventArgs e)
        {
            

        #region Rastgele 10 sayı çek
        
            Random rnd = new Random();
            for (int i = 0; i < sayılar.Length; i++) // 10 tane sayı ürettiğimi belirten döngü
            {

                int sayi = rnd.Next(1, 12);

                if (i > 0)
                {
                    for (int j = 0; j <= i; j++) // her sayı ürettiğimde dizinin diğer elemanlarıyla aynı olup olmadığını tümünü kontrol ediyor.
                    {
                        if (sayi == sayılar[j])
                        {
                            i--;
                            break;


                        }
                        else
                        {
                            if (j == i)
                            {
                                sayılar[i] = sayi;
                            }
                        }


                    }
                    
                }
                else
                {
                    sayılar[i] = sayi;
                }
                
            }
            #endregion
            //int olmadığı için kapattım
            KitapResim(sayılar[0]);
            /*     pictureBox1.Load(kitapurl);
                 pictureBox2.Load(KitapResim(sayılar[1]));
                 pictureBox3.Load(KitapResim(sayılar[2]));
                 pictureBox4.Load(KitapResim(sayılar[3]));
                 pictureBox5.Load(KitapResim(sayılar[4]));
                 pictureBox6.Load(KitapResim(sayılar[5]));
                 pictureBox7.Load(KitapResim(sayılar[6]));
                 pictureBox8.Load(KitapResim(sayılar[7]));
                 pictureBox9.Load(KitapResim(sayılar[8]));
                 pictureBox10.Load(KitapResim(sayılar[9]));

         */

        
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e) {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

     

        private User update;
        private Book _bookupdate;
        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) || string.IsNullOrEmpty(textBox2.Text.Trim()) || string.IsNullOrEmpty(textBox3.Text.Trim()) ||
                string.IsNullOrEmpty(textBox4.Text.Trim()) || string.IsNullOrEmpty(textBox5.Text.Trim()) || string.IsNullOrEmpty(textBox6.Text.Trim()) ||
                string.IsNullOrEmpty(textBox7.Text.Trim()) || string.IsNullOrEmpty(textBox8.Text.Trim()) || string.IsNullOrEmpty(textBox9.Text.Trim()) ||
                string.IsNullOrEmpty(textBox10.Text.Trim()))
            {
                MessageBox.Show("Lütfen hepsini doldurunuz");

            }
            else
            {

                kullaniciid = 0;
                KullaniciID(username);

                update = _userService.GetById(kullaniciid);
                update.gereklioylama = 10;

                _userService.Update(update);
                bool result = _userService.Save() > 0;
                if (result)
                {
                    MessageBox.Show("Zorunlu 10 oyu kullandınız");
                    int count = 0;
                    bool result2 = false;
                    foreach (Control item in Controls)
                    {
                        if (item is TextBox)
                        {
                            Vote vote = new Vote();
                            vote.Oypuani = Convert.ToInt32(item.Text);
                            kullaniciid = 0;
                            KullaniciID(username);
                            vote.KullaniciID = kullaniciid;
                            vote.KitapID = sayılar[count];

                            _voteService.Add(vote);
                            result2 = _voteService.Save() > 0;

                            // kitap oyunu updatelediğimiz yer

                            _bookupdate = _bookService.GetById(sayılar[count]);
                            _bookupdate.Oy = _bookupdate.Oy + Convert.ToInt32(item.Text);

                            _bookService.Update(_bookupdate);
                            _bookService.Save();

                            count++;
                        }

                    }

                    if (result2)
                    {
                        MessageBox.Show("Oy puanlarınız kitaba eklenmiştir.");

                        Kullanıcı_Paneli kp = new Kullanıcı_Paneli();
                        kp.Show();
                        this.Hide();

                    }
                }
            }
            }
         // int id = Convert.ToInt32(textBox1);
         
        }

      
    }

