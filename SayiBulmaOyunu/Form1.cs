using System.Text;
using System.Windows.Forms;

namespace SayiBulmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gizliSayi = 0;
        int kalanHak = 0;
        int sayac = 0;
        int bildi = 0;



        private void button1_Click(object sender, EventArgs e)
        {
            gizliSayi = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < gizliSayi.ToString().Length; i++)
            {
                for (int j = 0; j < gizliSayi.ToString().Length; j++)
                {

                    if (gizliSayi.ToString()[j] == gizliSayi.ToString()[i] && i != j)
                    {
                        MessageBox.Show("Girdiðniz sayýnýn rakamlarý birbirinden farklý olmalýdýr.", "Hata!");
                        return;
                    }
                }
            }




            kalanHak = Convert.ToInt32(numericUpDown1.Value);

            if (kalanHak == 0)
            {
                MessageBox.Show("Hak sayýsý girmeden geçemezsiniz..", "Hata");
                return;
            }
            sayac = Convert.ToInt32(numericUpDown2.Value);
            if (sayac == 0)
            {
                MessageBox.Show("Süre girmeden geçemezsiniz", "Hata");
                return;
            }
            label9.Text += " " + kalanHak;

            timer1.Interval = 1000;
            timer1.Start();
            button1.Enabled = false;
            textBox2.MaxLength = gizliSayi.ToString().Length;

            label5.Text += " " + gizliSayi.ToString().Length;
            tableLayoutPanel1.ColumnCount = gizliSayi.ToString().Length;
            tableLayoutPanel1.RowCount = 1;
            for (int i = 0; i < gizliSayi.ToString().Length; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0F));
                tableLayoutPanel1.Controls.Add(new Panel() { BackColor = Color.White });

            }
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0F));




        }

        private void button2_Click(object sender, EventArgs e)
        {

            int tahmin = Convert.ToInt32(textBox2.Text);

            if (textBox2.Text.Length != gizliSayi.ToString().Length)
            {
                MessageBox.Show("Basamak Sayýsý Uzunluðunda Girmelisiniz", "Hata");
                return;
            }

            kalanHak--;
            label9.Text = "Kalan Hak Sayýsý: " + kalanHak;
            Tahminler.Items.Add(tahmin);








            for (int i = 0; i < gizliSayi.ToString().Length; i++)
            {

                if (gizliSayi.ToString()[i].ToString().Contains(tahmin.ToString()[i]))
                {
                    if (tableLayoutPanel1.Controls[i].BackColor != Color.Green)
                    {
                        tableLayoutPanel1.Controls[i].BackColor = Color.Green;
                        bildi++;

                    }
                }
                else
                {
                    if (tableLayoutPanel1.Controls[i].BackColor != Color.Green)
                    {
                        tableLayoutPanel1.Controls[i].BackColor = Color.Red;
                    }
                }
            }



            if (bildi == gizliSayi.ToString().Length)
            {
                oyunBitti("Kazandýnýz", "Bitti");
                return;
            }

            if (kalanHak == 0)
            {
                oyunBitti("Tahmin hakkýnýz kalmadýðý için oyun bitti...", "Oyun Bitti!");
                return;
            }

            if (tahmin == gizliSayi)
            {
                oyunBitti("KAZANDINIZ!", "Oyun Bitti!");
                return;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label10.Text = sayac.ToString() + " saniye kaldý";

            if (sayac == 0)
            {
                oyunBitti("Süre bittiði için oyun sona erdi...", "Oyun Bitti!");

            }

        }

        private void oyunBitti(String baslik, String mesaj)
        {
            Sonuçlar.Items.Add("Süre: " + sayac + " | Tahmin Hakký: " + kalanHak);

            StreamWriter sw = new StreamWriter("C:\\Users\\Eray\\Desktop\\test.txt", true, Encoding.ASCII);
            sw.WriteLineAsync("Sure: " + sayac + " | Tahmin Hakki: " + kalanHak);
            sw.Close();
            timer1.Stop();
            label10.Text = "Kalan Süre :";
            MessageBox.Show(baslik, mesaj);
            gizliSayi = 0;
            kalanHak = 0;
            label9.Text = "Kalan Hak Sayýsý: " + kalanHak;
            label5.Text = "Basamak Sayýsý: ";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Enabled = true;
            Tahminler.Items.Clear();
            tableLayoutPanel1.Controls.Clear();
        }
    }
}