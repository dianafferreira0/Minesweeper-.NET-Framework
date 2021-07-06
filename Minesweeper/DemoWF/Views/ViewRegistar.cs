using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using DemoCommon.Diversos;
using System.Xml.Linq;
using DemoCommon.Classes;
using System.IO;
using System.Reflection;

namespace DemoWF.Views
{
    public partial class ViewRegistar : Form
    {
        //Eventos
        public event MetodosSemParametros PedidoVoltar;

        public ViewRegistar()
        {
            InitializeComponent();
        }

        // Quando inicio o ViewRegistar este deve ter todos os seus campos limpos
        private void ViewRegistar_Load(object sender, EventArgs e)
        {
            textBoxNomeABV.Clear();
            textBoxMailRegistar.Clear();
            textBoxPassRegistar.Clear();
            textBoxUsername.Clear();
            textBoxPais.Clear();
        }

        //Função para converter imagem em string
        public string ImageToString()
        {
            using (Image image = pictureBox1.Image)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    byte[] imageBytes = ms.ToArray();

                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        //string ImagemConvertida;

        //Quando se carrega no button para carregar a imagem
        private void buttonFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPEG|*.JPG;*.JPEG;*.JPE|PNG|*.PNG|Todos os formatos|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(dlg.FileName);
            }

            /*try
            {
                string imagelocation = "";
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpg files|*.jpg|PNG files|*.png|All files|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imagelocation = dlg.FileName;
                    pictureBox1.ImageLocation = imagelocation;
                    byte[] imagearray = System.IO.File.ReadAllBytes(imagelocation);
                    string base64image = Convert.ToBase64String(imagearray);
                    string extension = System.IO.Path.GetExtension(dlg.FileName);
                    ImagemConvertida = "data:Image" + extension + ";base64" + base64image;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }*/
        }

        private void buttonRegistarRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNomeABV.Text) && !string.IsNullOrEmpty(textBoxUsername.Text) && !string.IsNullOrEmpty(textBoxPassRegistar.Text) && !string.IsNullOrEmpty(textBoxMailRegistar.Text) && !string.IsNullOrEmpty(textBoxPais.Text))
                {
                    XDocument xmlResposta = Program.S_Server.PostRegisto(textBoxNomeABV.Text, textBoxUsername.Text, textBoxPassRegistar.Text, textBoxMailRegistar.Text, textBoxPais.Text, ImageToString());

                    if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                    {
                        //Apresenta mensagem de erro
                        MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("O registo foi efetuado com sucesso!");
                        //Após o registo vai para a ViewLogin                     
                        (Program.V_Login as Form).Show();
                        //Esconde a ViewRegistar
                        (Program.V_Registar as Form).Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Os dados não foram todos inseridos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Quando se clica no botao 'seta'
        private void buttonMenuRegistar_Click(object sender, EventArgs e)
        {
            PedidoVoltar();
        }
    }
}
