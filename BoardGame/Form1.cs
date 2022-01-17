using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //wait(1000) komutunu kullanabilmek için. Bu komutu kullandığınızda parantez içerisindeki milisaniye kadar bekleme olur.
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            //Taşların tahtaya gelmesi.
            pictureBox65.Location = new Point(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            pictureBox66.Location = new Point(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            pictureBox67.Location = new Point(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            pictureBox68.Location = new Point(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
            pictureBox69.Location = new Point(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text));
            pictureBox70.Location = new Point(Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox12.Text));
            pictureBox71.Location = new Point(Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox14.Text));
            pictureBox72.Location = new Point(Convert.ToInt32(textBox15.Text), Convert.ToInt32(textBox16.Text));
            pictureBox73.Location = new Point(Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox18.Text));
            pictureBox74.Location = new Point(Convert.ToInt32(textBox19.Text), Convert.ToInt32(textBox20.Text));

            //Siyah taşların yerine gelmesi
            pictureBox75.Location = new Point(869, 31);
            pictureBox76.Location = new Point(999, 31);
            pictureBox77.Location = new Point(1138, 31);
            pictureBox78.Location = new Point(869, 130);
            pictureBox79.Location = new Point(999, 130);
            pictureBox80.Location = new Point(1138, 130);
            pictureBox81.Location = new Point(869, 230);
            pictureBox82.Location = new Point(999, 230);
            pictureBox83.Location = new Point(1138, 230);
            pictureBox84.Location = new Point(999, 330);

            //Siyah taşların Görünmesi
            pictureBox75.Visible = true;
            pictureBox76.Visible = true;
            pictureBox77.Visible = true;
            pictureBox78.Visible = true;
            pictureBox79.Visible = true;
            pictureBox80.Visible = true;
            pictureBox81.Visible = true;
            pictureBox82.Visible = true;
            pictureBox83.Visible = true;
            pictureBox84.Visible = true;


        }



        //Textbox'lara sadece sayı girilmesi için.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        //Buraya kadar.
        private void button2_Click(object sender, EventArgs e)
        {
            int xekseniAnatas, yekseniAnatas;
            int[] xekseniTaslar = new int[6], xsagSol = new int[6], yekseniTaslar = new int[6], yasagiYukari = new int [6];
            int[] xekseniBlok = new int[3], yekseniBlok = new int[6], toplam = new int[6];

            //Kırmızı taşların x eksenindeki kordinatlarını alıyorum
            xekseniTaslar[0] = pictureBox65.Location.X;
            xekseniTaslar[1] = pictureBox66.Location.X;
            xekseniTaslar[2] = pictureBox67.Location.X;
            xekseniTaslar[3] = pictureBox68.Location.X;
            xekseniTaslar[4] = pictureBox69.Location.X;
            xekseniTaslar[5] = pictureBox70.Location.X;

            //Kırmızı taşların y eksenindeki kordinatlarını alıyorum.
            yekseniTaslar[0] = pictureBox65.Location.Y;
            yekseniTaslar[1] = pictureBox66.Location.Y;
            yekseniTaslar[2] = pictureBox67.Location.Y;
            yekseniTaslar[3] = pictureBox68.Location.Y;
            yekseniTaslar[4] = pictureBox69.Location.Y;
            yekseniTaslar[5] = pictureBox70.Location.Y;
            
            //Ana taşın x ve y kordinatlarını alıyorum.
            xekseniAnatas = pictureBox74.Location.X;
            yekseniAnatas = pictureBox74.Location.Y;

            //Blokların x eksenindeki kordinatları alıyorum
            xekseniBlok[0] = pictureBox71.Location.X;
            xekseniBlok[1] = pictureBox72.Location.X;
            xekseniBlok[2] = pictureBox73.Location.X;

            //Blokların y eksenindeki kordinatları alıyorum
            yekseniBlok[0] = pictureBox71.Location.Y;
            yekseniBlok[1] = pictureBox72.Location.Y;
            yekseniBlok[2] = pictureBox73.Location.Y;


            //Çıkan sonuca göre (- veya +) sağa ya da sola gidecek. Bunun için gereken kare hesaplaması.
            for (int i =0; i<6; i++)
            {
                if(xekseniAnatas > xekseniTaslar[i])
                {
                    xsagSol[i] = (xekseniAnatas - xekseniTaslar[i] ) / 100;
                }
                else
                {
                    xsagSol[i] = -((xekseniTaslar[i] - xekseniAnatas) / 100);
                }
            }
            //Çıkan sonucu göre (- veya +) yukarı ya da aşağı gidecek. Bunun içib kare hesaplaması.
            for(int y=0; y<6; y++)
            {
                if(yekseniAnatas > xekseniTaslar[y])
                {
                    yasagiYukari[y] = (yekseniAnatas - yekseniTaslar[y]) / 100;
                }
                else
                {
                    yasagiYukari[y] = -((yekseniTaslar[y] - yekseniAnatas) / 100);
                }
            }

            //Label'lara yazacağımız sayıları topluyoruz.
            for(int i = 0; i < 6; i++)
            {
                if(xsagSol[i] >= 0)
                {
                    toplam[i] = xsagSol[i];
                }
                else
                {
                    toplam[i] = xsagSol[i]*(-1);
                }
                if (yasagiYukari[i] >= 0)
                {
                    toplam[i] += yasagiYukari[i];
                }
                else
                {
                    toplam[i] = (yasagiYukari[i] * (-1))+ toplam[i];
                }
            }

            //Label'ların pozisyonunu taşların üstüne getiriyor 
            label17.Location = new Point(xekseniTaslar[0], yekseniTaslar[0]);
            label17.Text = Convert.ToString(toplam[0]);
            label17.Visible = true;
            label18.Location = new Point(xekseniTaslar[1], yekseniTaslar[1]);
            label18.Text = Convert.ToString(toplam[1]);
            label18.Visible = true;
            label19.Location = new Point(xekseniTaslar[2], yekseniTaslar[2]);
            label19.Text = Convert.ToString(toplam[2]);
            label19.Visible = true;
            label20.Location = new Point(xekseniTaslar[3], yekseniTaslar[3]);
            label20.Text = Convert.ToString(toplam[3]);
            label20.Visible = true;
            label21.Location = new Point(xekseniTaslar[4], yekseniTaslar[4]);
            label21.Text = Convert.ToString(toplam[4]);
            label21.Visible = true;
            label22.Location = new Point(xekseniTaslar[5], yekseniTaslar[5]);
            label22.Text = Convert.ToString(toplam[5]);
            label22.Visible = true;

            button2.Enabled = false;
            button3.Enabled = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Oyna butonuna basıldığında yazılar kaybolsun.
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            
            button3.Enabled = false;
            button4.Visible = true;
            button4.Enabled = true;

            //Timer ı aktif hale geiriyoruz ve saniyede bir hareket etmesi için 1000 veriyoruz.
            timer1.Enabled = true;
            timer1.Interval = 2000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int anatasX = pictureBox74.Location.X, anatasY = pictureBox74.Location.Y;
            int[] xekseniTaslar = new int[6], yekseniTaslar = new int[6];

            //Kırmızı taşların x eksenindeki kordinatlarını alıyorum
            xekseniTaslar[0] = pictureBox65.Location.X;
            xekseniTaslar[1] = pictureBox66.Location.X;
            xekseniTaslar[2] = pictureBox67.Location.X;
            xekseniTaslar[3] = pictureBox68.Location.X;
            xekseniTaslar[4] = pictureBox69.Location.X;
            xekseniTaslar[5] = pictureBox70.Location.X;

            //Kırmızı taşların y eksenindeki kordinatlarını alıyorum.
            yekseniTaslar[0] = pictureBox65.Location.Y;
            yekseniTaslar[1] = pictureBox66.Location.Y;
            yekseniTaslar[2] = pictureBox67.Location.Y;
            yekseniTaslar[3] = pictureBox68.Location.Y;
            yekseniTaslar[4] = pictureBox69.Location.Y;
            yekseniTaslar[5] = pictureBox70.Location.Y;

            // Birinci taş için x ekseninde hareket ettirme.
            for(int i = 0; i<7; i++)
            {
                if (xekseniTaslar[0] == anatasX) break;
                if (xekseniTaslar[0] < anatasX)
                {
                    if (xekseniTaslar[0] != anatasX)
                    {
                        xekseniTaslar[0] += 100;
                        pictureBox65.Location = new Point(xekseniTaslar[0], yekseniTaslar[0]);
                        wait(200);
                    }
                    
                }
                
                if (anatasX < xekseniTaslar[0])
                {
                    if (xekseniTaslar[0] != anatasX)
                    {
                        xekseniTaslar[0] -= 100;
                        pictureBox65.Location = new Point(xekseniTaslar[0], yekseniTaslar[0]);
                        wait(200);
                    }
                    
                }
                
            }
            // Birinci taş için y ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (yekseniTaslar[0] == anatasY) break;
                if (yekseniTaslar[0] < anatasY)
                {
                    if (yekseniTaslar[0] != anatasY)
                    {
                        yekseniTaslar[0] += 100;
                        pictureBox65.Location = new Point(xekseniTaslar[0], yekseniTaslar[0]);
                        wait(200);
                    }
                    
                }
                
                if (anatasY < yekseniTaslar[0])
                {
                    if (yekseniTaslar[0] != anatasY)
                    {
                        yekseniTaslar[0] -= 100;
                        pictureBox65.Location = new Point(xekseniTaslar[0], yekseniTaslar[0]);
                        wait(200);
                    }
                    
                }
                
            }
            // İkinci taş için x ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (xekseniTaslar[1] == anatasX) break;
                if (xekseniTaslar[1] < anatasX)
                {
                    if (xekseniTaslar[1] != anatasX)
                    {
                        xekseniTaslar[1] += 100;
                        pictureBox66.Location = new Point(xekseniTaslar[1], yekseniTaslar[1]);
                        wait(200);
                    }
                    
                }
                
                if (anatasX < xekseniTaslar[1])
                {
                    if (xekseniTaslar[1] != anatasX)
                    {
                        xekseniTaslar[1] -= 100;
                        pictureBox66.Location = new Point(xekseniTaslar[1], yekseniTaslar[1]);
                        wait(200);
                    }
                    
                }
                
            }
            // İkinci taş için y ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (yekseniTaslar[1] == anatasY) break;
                if (yekseniTaslar[1] < anatasY)
                {
                    if (yekseniTaslar[1] != anatasY)
                    {
                        yekseniTaslar[1] += 100;
                        pictureBox66.Location = new Point(xekseniTaslar[1], yekseniTaslar[1]);
                        wait(200);
                    }
                    
                }
                
                if (anatasY < yekseniTaslar[1])
                {
                    if (yekseniTaslar[1] != anatasY)
                    {
                        yekseniTaslar[1] -= 100;
                        pictureBox66.Location = new Point(xekseniTaslar[1], yekseniTaslar[1]);
                        wait(200);
                    }
                    
                }
                
            }
            // Üçüncü taş için x ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (xekseniTaslar[2] == anatasX) break;
                if (xekseniTaslar[2] < anatasX)
                {
                    if (xekseniTaslar[2] != anatasX)
                    {
                        xekseniTaslar[2] += 100;
                        pictureBox67.Location = new Point(xekseniTaslar[2], yekseniTaslar[2]);
                        wait(200);
                    }
                    
                }
                
                if (anatasX < xekseniTaslar[2])
                {
                    if (xekseniTaslar[2] != anatasX)
                    {
                        xekseniTaslar[2] -= 100;
                        pictureBox67.Location = new Point(xekseniTaslar[2], yekseniTaslar[2]);
                        wait(200);
                    }
                    
                }
                
            }
            // Üçüncü taş için y ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (yekseniTaslar[2] == anatasY) break;
                if (yekseniTaslar[2] < anatasY)
                {
                    if (yekseniTaslar[2] != anatasY)
                    {
                        yekseniTaslar[2] += 100;
                        pictureBox67.Location = new Point(xekseniTaslar[2], yekseniTaslar[2]);
                        wait(200);
                    }
                    
                }
                
                if (anatasY < yekseniTaslar[2])
                {
                    if (yekseniTaslar[2] != anatasY)
                    {
                        yekseniTaslar[2] -= 100;
                        pictureBox67.Location = new Point(xekseniTaslar[2], yekseniTaslar[2]);
                        wait(200);
                    }
                    
                }
                
            }
            // Dördüncü taş için x ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (xekseniTaslar[3] == anatasX) break;
                if (xekseniTaslar[3] < anatasX)
                {
                    if (xekseniTaslar[3] != anatasX)
                    {
                        xekseniTaslar[3] += 100;
                        pictureBox68.Location = new Point(xekseniTaslar[3], yekseniTaslar[3]);
                        wait(200);
                    }
                    
                }
                
                if (anatasX < xekseniTaslar[3])
                {
                    if (xekseniTaslar[3] != anatasX)
                    {
                        xekseniTaslar[3] -= 100;
                        pictureBox68.Location = new Point(xekseniTaslar[3], yekseniTaslar[3]);
                        wait(200);
                    }
                    
                }
                
            }
            // Dördüncü taş için y ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (yekseniTaslar[3] == anatasY) break;
                if (yekseniTaslar[3] < anatasY)
                {
                    if (yekseniTaslar[3] != anatasY)
                    {
                        yekseniTaslar[3] += 100;
                        pictureBox68.Location = new Point(xekseniTaslar[3], yekseniTaslar[3]);
                        wait(200);
                    }
                    
                }
                
                if (anatasY < yekseniTaslar[3])
                {
                    if (yekseniTaslar[3] != anatasY)
                    {
                        yekseniTaslar[3] -= 100;
                        pictureBox68.Location = new Point(xekseniTaslar[3], yekseniTaslar[3]);
                        wait(200);
                    }
                    
                }
                
            }
            // Beşinci taş için x ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (xekseniTaslar[4] == anatasX) break;
                if (xekseniTaslar[4] < anatasX)
                {
                    if (xekseniTaslar[4] != anatasX)
                    {
                        xekseniTaslar[4] += 100;
                        pictureBox69.Location = new Point(xekseniTaslar[4], yekseniTaslar[4]);
                        wait(200);
                    }
                    
                }
                
                if (anatasX < xekseniTaslar[4])
                {
                    if (xekseniTaslar[4] != anatasX)
                    {
                        xekseniTaslar[4] -= 100;
                        pictureBox69.Location = new Point(xekseniTaslar[4], yekseniTaslar[4]);
                        wait(200);
                    }
                    
                }
                
            }
            // Beşinci taş için y ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (yekseniTaslar[4] == anatasY) break;
                if (yekseniTaslar[4] < anatasY)
                {
                    if (yekseniTaslar[4] != anatasY)
                    {
                        yekseniTaslar[4] += 100;
                        pictureBox69.Location = new Point(xekseniTaslar[4], yekseniTaslar[4]);
                        wait(200);
                    }
                    
                }
                
                if (anatasY < yekseniTaslar[4])
                {
                    if (yekseniTaslar[4] != anatasY)
                    {
                        yekseniTaslar[4] -= 100;
                        pictureBox69.Location = new Point(xekseniTaslar[4], yekseniTaslar[4]);
                        wait(200);
                    }
                    
                }
                
            }
            // Altıncı taş için x ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (xekseniTaslar[5] == anatasX) break;
                if (xekseniTaslar[5] < anatasX)
                {
                    if (xekseniTaslar[5] != anatasX)
                    {
                        xekseniTaslar[5] += 100;
                        pictureBox70.Location = new Point(xekseniTaslar[5], yekseniTaslar[5]);
                        wait(200);
                    }
                    
                }
                
                if (anatasX < xekseniTaslar[5])
                {
                    if (xekseniTaslar[5] != anatasX)
                    {
                        xekseniTaslar[5] -= 100;
                        pictureBox70.Location = new Point(xekseniTaslar[5], yekseniTaslar[5]);
                        wait(200);
                    }
                    
                }
                
            }
            // Altıncı taş için y ekseninde hareket ettirme.
            for (int i = 0; i < 7; i++)
            {
                if (yekseniTaslar[5] == anatasY) break;
                if (yekseniTaslar[5] < anatasY)
                {
                    if (yekseniTaslar[5] != anatasY)
                    {
                        yekseniTaslar[5] += 100;
                        pictureBox70.Location = new Point(xekseniTaslar[5], yekseniTaslar[5]);
                        wait(200);
                    }
                    
                }
                
                if (anatasY < yekseniTaslar[5])
                {
                    if (yekseniTaslar[5] != anatasY)
                    {
                        yekseniTaslar[5] -= 100;
                        pictureBox70.Location = new Point(xekseniTaslar[5], yekseniTaslar[5]);
                        wait(200);
                    }
                    
                }
                
            }
            //İlem bittikten sonra tahta üzerinde bi tur daha atıyor bunu engellemek için.
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            
            timer1.Enabled = false;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
