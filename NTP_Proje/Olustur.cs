using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace NTP_Proje
{
    public static class Olustur
    {
        public static PictureBox YukariBoru(int Ad, int x, int y)
        {
            return new PictureBox
            {
                Image = Properties.Resources.pipedown,
                Location = new Point(x, y),
                Name = "YukariBoru" + Ad,
                Size = new Size(58, 232),
                SizeMode = PictureBoxSizeMode.StretchImage,
        };
        }
        public static PictureBox AsagiBoru(int Ad, int x, int y)
        {
            return new PictureBox
            {
                Image = Properties.Resources.pipe,
                Location = new Point(x, y),
                Name = "AsagiBoru" + Ad,
                Size = new Size(58, 232),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
        }

        public static PictureBox Zemin(int Ad, int x)
        {
            return new PictureBox
            {
                Image = Properties.Resources.ground,
                Location = new Point(x, 397),
                Name = "Zemin" + Ad,
                SizeMode = PictureBoxSizeMode.AutoSize,
            };
        }

        public static void Font(Control kontrol)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            int fontLength = Properties.Resources.PoetsenOne_Regular.Length;
            byte[] fontdata = Properties.Resources.PoetsenOne_Regular;
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            
            kontrol.Font = new Font(pfc.Families[0], kontrol.Font.Size);
        }
    }
}
