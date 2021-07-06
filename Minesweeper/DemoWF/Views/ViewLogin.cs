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
using DemoCommon.Diversos;

namespace DemoWF.Views
{
    public partial class ViewLogin : Form
    {
        //Eventos
        public event MetodosSemParametros PedidoVoltarMenuL;
        public event MetodosSemParametros PedidoRegistar;

        public ViewLogin()
        {
            InitializeComponent();
            
        }

        //Quando iniciamos o ViewLogin, o Campo do jogador e da password têm de estar limpos
        private void ViewLogin_Load(object sender, EventArgs e)
        {
            textBoxJogador.Clear();
            textBoxPassword.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(textBoxJogador.Text) && !string.IsNullOrEmpty(textBoxPassword.Text)) //Verifica se as textbox estão preenchidas
                {
                    XDocument xmlResposta = Program.S_Server.PostLogin(textBoxJogador.Text, textBoxPassword.Text);

                    if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                    {
                        // apresenta mensagem de erro 
                        MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // assume a autenticação e obtem o ID do resultado...para ser usado noutros pedidos 
                        Program.J_Jogador.Id = xmlResposta.Element("resultado").Element("objeto").Element("ID").Value;
                        MessageBox.Show("Login realizado com sucesso! O ID criado : " + Program.J_Jogador.Id); 
                                                                                                             
                        Program.J_Jogador.Username = textBoxJogador.Text;
                        Program.J_JogadorCons.Username = textBoxJogador.Text;

                        //Chama a viewsecundário para apresentar o menu secundário
                        (Program.V_Secundario as Form).Show();
                        (Program.V_Login as Form).Hide(); //Esconde a ViewLogin     

                        //Apaga os dados da textbox sempre que se carregar na ViewLogin
                        textBoxJogador.Clear();
                        textBoxPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Os dados não foram inseridos corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Quando clicamos no botão registo do ViewLogin, mostramos o ViewRegistar
        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            PedidoRegistar();
        }

        private void buttonMenuEL_Click(object sender, EventArgs e)
        {
            PedidoVoltarMenuL();
        }
    }
}
