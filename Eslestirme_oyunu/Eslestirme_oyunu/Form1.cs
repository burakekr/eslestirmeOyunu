using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Eslestirme_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sorular = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] cevaplar = { 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        Random rst = new Random();
        int sayi, sayi2,kontrol,bulunan=0;
        int sayac=10;
        Button ebtn;
        private void Form1_Load(object sender, EventArgs e)
        {
            Dagit();
            panel1.Enabled = false;
            panel2.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Dagit();
            yeniden();
            panel1.Enabled = true;
            kontrol = 0;
            bulunan = 0;
        }

        private void basildi(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (kontrol == 0)
            {
                btn.BackgroundImage = Image.FromFile("Resimler\\" + btn.TabIndex + ".jpg");
                kontrol++;
                panel1.Enabled = false;
                panel2.Enabled = true;
                ebtn = btn;
            }
            else if (kontrol == 1)
            {
                btn.BackgroundImage = Image.FromFile("Resimler\\" + btn.TabIndex + ".jpg");
                if (btn.TabIndex == ebtn.TabIndex+9)
                {
                    bulunan++;
                    btn.Enabled = false;
                    ebtn.Enabled = false;
                    panel2.Enabled = false;
                    panel1.Enabled = true;
                    kontrol = 0;
                }
                else
                {
                    panel2.Enabled = false;
                    panel1.Enabled = true;
                    kontrol = 0;
                    Thread.Sleep(1000);
                    ebtn.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
                    btn.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
                }
                if (bulunan==9)
                {
                    MessageBox.Show("Oyun Bitti");
                }
            }
        }

        private void Dagit()
        {
            sayac = 10;
            for (int i = 1; i <= 9; i++)
            {
                listBox1.Items.Add(i);
                listBox2.Items.Add(sayac);
                sayac++;
            }
            for (int i = 0; i < 9; i++)
            {
                sayi = rst.Next(0, listBox1.Items.Count);
                sayi2 = rst.Next(0, listBox2.Items.Count);
                sorular[i] = Convert.ToInt32(listBox1.Items[sayi]);
                listBox1.Items.RemoveAt(sayi);
                cevaplar[i] = Convert.ToInt32(listBox2.Items[sayi2]);
                listBox2.Items.RemoveAt(sayi2);
            }
            button1.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
            button1.TabIndex = sorular[0];
            button2.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
            button2.TabIndex = sorular[1];
            button3.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
            button3.TabIndex = sorular[2];
            button4.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
            button4.TabIndex = sorular[3];
            button5.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
            button5.TabIndex = sorular[4];
            button6.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
            button6.TabIndex = sorular[5];
            button7.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
            button7.TabIndex = sorular[6];
            button8.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
            button8.TabIndex = sorular[7];
            button9.BackgroundImage = Image.FromFile("Resimler\\Soru_.jpeg");
            button9.TabIndex = sorular[8];
            button10.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
            button10.TabIndex = cevaplar[0];
            button11.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
            button11.TabIndex = cevaplar[1];
            button12.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
            button12.TabIndex = cevaplar[2];
            button13.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
            button13.TabIndex = cevaplar[3];
            button14.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
            button14.TabIndex = cevaplar[4];
            button15.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
            button15.TabIndex = cevaplar[5];
            button16.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
            button16.TabIndex = cevaplar[6];
            button17.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
            button17.TabIndex = cevaplar[7];
            button18.BackgroundImage = Image.FromFile("Resimler\\Answer.jpg");
            button18.TabIndex = cevaplar[8];
        }
        private void yeniden()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
        }
    }
}
