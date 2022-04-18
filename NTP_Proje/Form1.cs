using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int animasyonKare;
        int yercekimi = 15;
        int boruHizi = 8;
        int puan = 0;
        Random rnd = new Random();
        SoundPlayer olmeEfekti = new SoundPlayer(Properties.Resources.sfx_die);
        SoundPlayer kanatEfekti = new SoundPlayer(Properties.Resources.sfx_wing);
        SoundPlayer carpmaEfekti = new SoundPlayer(Properties.Resources.sfx_hit);
        SoundPlayer puanArtmaEfekti = new SoundPlayer(Properties.Resources.sfx_point);
        SoundPlayer dusmeEfekti = new SoundPlayer(Properties.Resources.sfx_swooshing);

        private void TusBirakildi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yercekimi = 10;
            }
        }

        private void TusBasildi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                switch (OyunTimer.Tag)
                {
                    case "Bitti":
                        {
                            oyunBasladi();
                            OyunTimer.Tag = null;
                            puan = 0;
                            boruHizi = 8;
                            animasyonKare = 0;
                            break;
                        }

                    default:
                        if (!OyunTimer.Enabled)
                        {
                            OyunTimer.Start();
                            kusAnimasyon.Start();
                        }
                        kanatEfekti.Play();
                        yercekimi = -15;
                        break;
                }
            }
        }

        private void oyunBasladi()
        {
            for (int i = 1; i <= 4; i++)
            {
                this.Controls.Remove(this.Controls["Zemin" + i]);
                this.Controls.Add(Olustur.Zemin(i, (i - 1) * 336));
            }

            for (int i = 1; i <= 3; i++)
            {
                this.Controls.Remove(this.Controls["YukariBoru" + i]);
                this.Controls.Remove(this.Controls["AsagiBoru" + i]);
                this.Controls.Add(Olustur.YukariBoru(i, 185 + (i - 1) * 400, rnd.Next(-178, 0)));
                this.Controls.Add(Olustur.AsagiBoru(i, 185 + (i - 1) * 400, this.Controls["YukariBoru" + i].Bottom + 117));
            }
            
            puanText.Tag = "0";
            puanText.Text = "Puan: 0";

            kus.Location = new Point(35, 222);
            kus.SendToBack();
        }

        private void oyunBitti()
        {
            olmeEfekti.Play();
            kusAnimasyon.Stop();
            OyunTimer.Stop();
            OyunTimer.Tag = "Bitti";
            puanText.TextAlign = ContentAlignment.MiddleCenter;
            puanText.Text = "Oyun Bitti!";
        }

        private void OyunTick(object sender, EventArgs e)
        {
            kus.Top += yercekimi;
            puanText.Text = "Puan: " + puan;

            for (int i = 1; i <= 4; i++)
            {
                Control Zemin = this.Controls["Zemin" + i];
                Zemin.Left -= boruHizi;

                if (Zemin.Right <= 0)
                {
                    Zemin.Left = Zemin.Left + 4 * 336;
                }

                if (kus.Bounds.IntersectsWith(Zemin.Bounds))
                {
                    oyunBitti();
                }
            }

            for (int i = 1; i <= 3; i++)
            {
                Control YukariB = this.Controls["YukariBoru" + i];
                Control AsagiB = this.Controls["AsagiBoru" + i];

                YukariB.Left -= boruHizi;
                AsagiB.Left -= boruHizi;

                if (YukariB.Right <= 0)
                {
                    int right = YukariB.Right;
                    this.Controls.Remove(YukariB);
                    this.Controls.Remove(AsagiB);
                    this.Controls.Add(Olustur.YukariBoru(i, right + 1097, rnd.Next(-178, 0)));
                    this.Controls.Add(Olustur.AsagiBoru(i, right + 1097, this.Controls["YukariBoru" + i].Bottom + 117));
                    puan++;
                    puanArtmaEfekti.Play();
                }

                if (kus.Bounds.IntersectsWith(YukariB.Bounds) ||
                    kus.Bounds.IntersectsWith(AsagiB.Bounds))
                {
                    oyunBitti();
                }
            }

            if (puan < 15 && puanText.Tag.ToString() != puan.ToString())
            {
                boruHizi++;
            }
            puanText.Tag = puan.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            oyunBasladi();
            Olustur.Font(puanText);
            

        }

        private void kusAnimasyon_Tick(object sender, EventArgs e)
        {
            Bitmap resim = (Bitmap)Properties.Birds.ResourceManager.GetObject("_"+animasyonKare);
            animasyonKare = (animasyonKare + 1) % 58;
            kus.Image = resim;
        }
    }
}
