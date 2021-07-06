using DemoCommon.Diversos;
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

namespace DemoWF.Views
{
    public partial class ViewEstatisticas : Form
    {
        //Evento para consultar perfil de outro jogador
        public event MetodosComString PedidoConsultaPerfil;
        public event MetodosSemParametros PedidoVoltarMenuSec;
        public event MetodosSemParametros PedidoSairAppEst;

        public ViewEstatisticas()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            PedidoSairAppEst();
        }

        private void ViewEstatisticas_Load(object sender, EventArgs e)
        {
            ApresentarTop10();
        }

        //Função que apresentar
        public void ApresentarTop10()
        {
            try
            {
                XDocument xmlResposta = Program.S_Server.GetTop10();

                if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                {
                    //apresenta mensagem de erro
                    MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach(var nivel in xmlResposta.Element("resultado").Element("objeto").Element("top").Descendants("nivel"))
                    {
                        if (string.Compare(nivel.Attribute("dificuldade").Value, "Facil") == 0)
                        {
                            listBoxEstatisticas.Items.Add("\n Nivel" + nivel.Attribute("dificuldade").Value);

                            foreach (var jogador in nivel.Descendants("jogador"))
                            {
                                listBoxEstatisticas.Items.Add(jogador.Attribute("tempo").Value + ";" + jogador.Attribute("username").Value + ";" + jogador.Attribute("quando").Value + "\n\n\n\n");
                            }
                        }
                        else
                        {
                            listBoxEstatisticas.Items.Add("\n\n Nivel" + nivel.Attribute("dificuldade").Value);

                            foreach (var jogador in nivel.Descendants("jogador"))
                            {
                                listBoxEstatisticas.Items.Add(jogador.Attribute("tempo").Value + ";" + jogador.Attribute("username").Value + ";" + jogador.Attribute("quando").Value + "\n\n\n\n");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void listBoxEstatisticas_SelectedIndexChanged(object sender, EventArgs e) //Serve para selecionar uma das linhas da listBox
        {
            if(PedidoConsultaPerfil != null)
            {
                PedidoConsultaPerfil(listBoxEstatisticas.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Obteve um erro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenuES_Click_1(object sender, EventArgs e)
        {
            PedidoVoltarMenuSec();
        }
    }
}
