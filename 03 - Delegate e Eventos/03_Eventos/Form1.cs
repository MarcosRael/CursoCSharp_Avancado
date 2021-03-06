using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _03_Eventos.Lib;
using _03_Eventos.Lib.Mensageiro;

namespace _03_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVideoEncode.Click += EventDeClick;
        }

        public void EventDeClick(object sender, EventArgs e)
        {
            Videos video = new Videos() { Nome = "video.mp4" };

            VideoEncode vid = new VideoEncode();

            vid.Encoded += new Email().EnviarMensagem;
            vid.Encoded += new SMS().EnviarMensagem;

            vid.Encode(video);
        }

    }
}
