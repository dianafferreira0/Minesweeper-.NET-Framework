using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DemoCommon.Diversos;
using System.Xml.Linq;

namespace DemoWF.Views
{
    public partial class ViewPerfil : Form
    {
        //Eventos
        public event MetodosSemParametros PedidoVoltarMenuP;

        public ViewPerfil()
        {
            InitializeComponent();
        }

        public void ApresentaPerfil(string user)
        {
            XDocument xmlResposta = Program.S_Server.GetPerfil(user);

            if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
            {
                //Apresenta mensagem de erro
                MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //'Apresenta' nas textbox os valores da xmlResposta
                textBoxNome.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("nomeabreviado").Value;
                textBoxEmail.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("email").Value;
                textBoxPais.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("pais").Value;
                textBoxTempoFacil.Text = (string)xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("facil");
                textBoxTempoMedio.Text = (string)xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("tempos").Element("medio");
                textBoxDerrotas.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("perdidos").Value;
                textBoxVitorias.Text = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("jogos").Element("ganhos").Value;
                string base64Imagem = xmlResposta.Element("resultado").Element("objeto").Element("perfil").Element("fotografia").Value;

                try
                {
                    string base64 = base64Imagem.Split(',')[0]; //Retira a parte da string correspondente aos bytes da imagem
                    byte[] bytes = Convert.FromBase64String(base64);
                    Image image = Image.FromStream(new MemoryStream(bytes));

                    pictureBoxFoto.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxFoto.BackgroundImage = image; //Apresenta a imagem na picturebox
                }
                catch
                {
                    string base64 = base64Imagem.Split(',')[1];
                    byte[] bytes = Convert.FromBase64String(base64);
                    Image image = Image.FromStream(new MemoryStream(bytes));

                    pictureBoxFoto.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBoxFoto.BackgroundImage = image;
                }
            }
        }
        public void ApagarDadosPerfil()
        {
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            textBoxPais.Text = "";
            textBoxDerrotas.Text = "";
            textBoxVitorias.Text = "";
            textBoxTempoFacil.Text = "";
            textBoxTempoMedio.Text = "";
            pictureBoxFoto.BackgroundImage = null;
        }

        private void ViewPerfil_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                ApresentaPerfil(Program.J_JogadorCons.Username);
            }
            else
            {
                ApagarDadosPerfil();
            }        
        }

        private void ViewPerfil_Load_1(object sender, EventArgs e)
        {
            ApresentaPerfil(Program.J_Jogador.Username); //Apresenta os dados no perfil quando se chama a ViewPerfil
        }

        private void buttonMenuP_Click(object sender, EventArgs e)
        {
            PedidoVoltarMenuP();
        }

        /*private void buttonConsulta_Click(object sender, EventArgs e)
        {
            buttonConsultar.Hide();
            buttonProcurar.Show();
            textBoxUsername.Show();
            this.AcceptButton = buttonProcurar;
            ApagarDadosPerfil();
        }*/
    }
}
