using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKE_GAME
{
    public partial class Form1 : Form
    {
        private Label _yem;
        private int _yilanparcasisayisi = 2;
        private Label _yilankafasi;
        private int _yilanParcasiSayisi;
        private int _yilanboyutu = 20;
        private int _yemboyutu = 20;
        private Random _rdn;
        private HareketYonu _yon;

        public Form1()
        {
            InitializeComponent();
            _rdn = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sifirla();
           
        }
        private void YenidenBaslatma()
        {
            lblpuan.Text = "0";
            lblsure.Text = "0";
            sifirla();
           
        }

        private void sifirla()
        {
            this.pnl.Controls.Clear();
            _yilanParcasiSayisi = 0;
            Yemolustur();
            YeminYerinidegistir();
            YilanYerlestir();
            timer1.Enabled = true;
            _yon = HareketYonu.Saga;
            timersaat.Enabled = true;
        }

        private Label YilanParcasiOlustur(int locationX, int locationY)
        {
            _yilanParcasiSayisi++;
            Label lbl = new Label()
            {
                Name = "yilanParca" + _yilanParcasiSayisi,
                BackColor = Color.Red,
                Width = _yilanboyutu,
                Height = _yilanboyutu,
                Location = new Point(locationX, locationY)

            };
            this.pnl.Controls.Add(lbl);
            return lbl;
        }
        private void YilanYerlestir()
        {
            _yilankafasi = YilanParcasiOlustur(0, 0);
            _yilankafasi.Text = ":";
            _yilankafasi.TextAlign = ContentAlignment.MiddleCenter;
            _yilankafasi.ForeColor = Color.White;
            var locationX = (pnl.Width / 2) - (_yilankafasi.Width / 2);
            var locationY = (pnl.Height / 2) - (_yilankafasi.Height / 2);
            _yilankafasi.Location = new Point(locationX, locationY);
        }
     private void Yemolustur()
        {
            Label lbl = new Label()
            {
                Name = "yem",
                BackColor = Color.Yellow,
                Width = _yemboyutu,
                Height = _yemboyutu

            };
            _yem = lbl;
            this.pnl.Controls.Add(lbl);
           
        }
          private void YeminYerinidegistir()
       {
           var locationX = 0;
           var locationY = 0;
           bool durum;
           do
           {
               durum = false;
               locationX = _rdn.Next(0, pnl.Width - _yemboyutu);
               locationY = _rdn.Next(0, pnl.Height - _yemboyutu);
               var rect1 = new Rectangle(new Point(locationX, locationY), _yem.Size);
               foreach (Control control in pnl.Controls)
               {
                   if (control is Label && control.Name.Contains("yilanParca"))
                   {
                       var rect2 = new Rectangle(control.Location, control.Size);
                       if (rect1.IntersectsWith(rect2))
                       {
                           durum = true;
                           break;
                       }
                   }
               }
           } while (durum);
           _yem.Location = new Point(locationX, locationY);

       }
       private enum HareketYonu
       {
           Asagı,
           Yukarı,
           Saga,
           Sola
       }

       private void Form1_KeyDown(object sender, KeyEventArgs e)
       {
           var keyCode = e.KeyCode;

            if (_yon == HareketYonu.Sola && keyCode == Keys.D
                ||_yon == HareketYonu.Saga &&keyCode==Keys.A
                    ||_yon == HareketYonu.Yukarı && keyCode == Keys.S
                    ||_yon == HareketYonu.Asagı && keyCode == Keys.W)
            {
                return;
            }
           switch (keyCode)
           {
               case Keys.W:
                   _yon = HareketYonu.Yukarı;
                   break;
               case Keys.S:
                   _yon = HareketYonu.Asagı;
                   break;
               case Keys.A:
                   _yon = HareketYonu.Sola;
                   break;
               case Keys.D:
                   _yon = HareketYonu.Saga;
                   break;
               default:
                   break;
           }
       }

        private void timer1_Tick(object sender, EventArgs e)
        {
            YilanKafasiniTakipEt();
            YilaniYurut();
            OyunBittimi();
            YlanYemiYedimi();
            
        }

        private void YilaniYurut()
        {
            var locationX = _yilankafasi.Location.X;
            var locationY = _yilankafasi.Location.Y;
            switch (_yon)
            {
                case HareketYonu.Asagı:
                    _yilankafasi.Location = new Point(locationX, locationY + (_yilankafasi.Width + _yilanparcasisayisi));
                    break;
                case HareketYonu.Yukarı:
                    _yilankafasi.Location = new Point(locationX, locationY - (_yilankafasi.Width + _yilanparcasisayisi));
                    break;
                case HareketYonu.Saga:
                    _yilankafasi.Location = new Point(locationX + (_yilankafasi.Width + _yilanparcasisayisi), locationY);
                    break;
                case HareketYonu.Sola:
                    _yilankafasi.Location = new Point(locationX - (_yilankafasi.Width + _yilanparcasisayisi), locationY);
                    break;
                default:
                    break;
            }
        }

        private void YlanYemiYedimi()
        {
            var rect1 =new Rectangle (_yilankafasi.Location,_yilankafasi.Size);
            var rect2 = new Rectangle(_yem.Location, _yem.Size);
            if (rect1.IntersectsWith(rect2))
            {
                lblpuan.Text = (Convert.ToInt32(lblpuan.Text) + 10).ToString();
                YeminYerinidegistir();
                YilanParcasiOlustur(-_yilanboyutu, -_yilanboyutu);
            }

        }

        private void YilanKafasiniTakipEt()
        {
            if (_yilanparcasisayisi<=1)
            {
                return;
            }
            for (int i=_yilanParcasiSayisi; i>1; i--)
            {
                var sonrakiparca = (Label)pnl.Controls[i];
                var oncekiparca = (Label)pnl.Controls[i - 1];
                sonrakiparca.Location = oncekiparca.Location;

            }
        }

        private void OyunBittimi()
        {
            bool gameover = false;
            var rect1= new Rectangle(_yilankafasi.Location, _yilankafasi.Size);
            foreach (Control control in pnl.Controls)
            {
            if(control is Label && control.Name.Contains("yilanParca") &&control.Name!=_yilankafasi.Name)
                {
                    var rect2 = new Rectangle(control.Location, control.Size);
                    if (rect1.IntersectsWith(rect2))
                    {
                        gameover = true;
                        break;

                    }
                    
                }
            }
            if (gameover)
            {
                timer1.Enabled= false;
                DialogResult sonuc = MessageBox.Show("Puanınız:" + lblpuan.Text, "Oyun Bitti!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (sonuc==DialogResult.OK)
                {
                    YenidenBaslatma();
                }
            }
        }

        private void timersaat_Tick(object sender, EventArgs e)
        {
            lblsure.Text= (Convert.ToInt32(lblsure.Text) + 1).ToString();
        }
    }
}