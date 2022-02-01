using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;



namespace _01_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBaixar_Click(object sender, EventArgs e)
        {
            string endereco = txtSite.Text;

            WebClient web = new WebClient();

            //Baixar a estrtura html de uma pagina web
            //string html = web.DownloadString(endereco); Forma Sync

            string html = await web.DownloadStringTaskAsync(new Uri(endereco)); //Forma Assync

            txtResultado.Text = html;

        }
    }
}
