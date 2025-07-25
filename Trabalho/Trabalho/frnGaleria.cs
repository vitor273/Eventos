using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Policy;

namespace Trabalho
{
    public partial class frnGaleria : Form
    {
        public frnGaleria()
        {
            InitializeComponent();
        }

        private void frnGaleria_Load(object sender, EventArgs e)
        {
            CarregarImagens();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Load("https://cdn2.thecatapi.com/images/4o.jpg");
        }

        private void pictureBox5_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }

        private void frnGaleria_Layout(object sender, LayoutEventArgs e)
        {
            //PictureBox pic = (PictureBox)sender;
            //pic.Load("https://cdn2.thecatapi.com/images/4o.jpg");
        }

        private async void CarregarImagens()
        {
            PictureBox[] array = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24 };
            List<int> valores = new List<int>();
            Random aleatorio = new Random();
            Cursor = Cursors.WaitCursor;
            foreach (var item in array)
            {
                int numero = 0;
                bool _loc_ = true;
                while (_loc_)
                {
                    _loc_ = false;
                    numero = (int)aleatorio.NextInt64(1, 100);
                    foreach (var item1 in valores)
                    {
                        if (item1 == numero)
                        {
                            _loc_ = true;
                        }
                    }
                }
                
                switch (aleatorio.NextInt64(1, 3))
                {
                    case 1:
                        item.Load("https://random-d.uk/api/" + numero + ".jpg");
                        break;
                    case 2:
                        item.Load("https://randomfox.ca/images/" + numero + ".jpg");
                        break;
                    case 3:
                        try
                        {
                            string jsonResponse = await FetchDataAsync("https://api.thecatapi.com/v1/images/search");
                            string data = DisplayImage(jsonResponse);
                            item.Load(data);
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show($"Erro: {er.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
                valores.Add(numero);
            }
            Cursor = Cursors.Default;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregarImagens();
        }

        private async Task<string> FetchDataAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException($"Falha. Não consegui recuperar os dados! Código{response.StatusCode}");
                }
            }
        }

        private string DisplayImage(string jsonResponse)
        {
           JObject data = JObject.Parse(jsonResponse);
           //string url = data["url"].ToString();
           string url = "https://cdn2.thecatapi.com/images/bp5.jpg";
           return url;
        }

    }
}
