using DemoCommon.Diversos;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoWF.Views
{
    public partial class ViewJogo : Form
    {
        //Eventos
        public event MetodosSemParametros PedidoSairJogo;
        public event MetodosSemParametros PedidoDificuldade;
        public event MetodosSemParametros PedidoVoltarMenuSec;
        public event MetodosSemParametros PedidoVoltarMenuPrin;

        /// </summary>

        //Variaveis e vetores
        int NumMinas, Largura, Altura, X_start = 20, Y_start = 60;
        public Button[,] PanelButton;
        public Label[,] PanelLabel;
        string dificuldade;

        //Selecionar Minas
        bool SelecionaMinas = false;
        //Vencer
        bool Vencer = false;
        //
        int NumMinastext;

        public ViewJogo()
        {
            InitializeComponent();

        }

        //Lida com o botão esquerdo do mouse nas caixas
        public void CliqueEsquerdo(object sender, System.EventArgs e) //Clique esquerdo
        {
            Button CliqueButton = sender as Button; //Cliques no botao

            if (SelecionaMinas) //Selecionar bombas
            {
                if (CliqueButton.Image == DemoWF.Properties.Resources.Flag)
                {
                    CliqueButton.Text = "";
                    NumMinastext++; //Texto sobre bombas
                }
                else
                {
                    CliqueButton.Image = DemoWF.Properties.Resources.Flag;
                    NumMinastext--;
                }
            }

            if (SelecionaMinas == false && CliqueButton.Image != DemoWF.Properties.Resources.Flag)
            {
                CliqueButton.Visible = false;

                if (!TempoDeJogo.Enabled)
                    TempoDeJogo.Enabled = true;

                //Verifica a posição do clique e compara com a posição dos botões e os define como x, y
                int x = 0;
                int y = 0;

                for (int i = 0; i < Largura; i++)
                {
                    for (int j = 0; j < Altura; j++)
                    {
                        if ((CliqueButton.Location.X == PanelButton[i, j].Location.X && CliqueButton.Location.Y == PanelButton[i, j].Location.Y))
                        {
                            x = i;
                            y = j;
                        }
                    }
                }

                //Usa x e y acima para verificar se há uma bomba na qual o jogador clicou
                if (PanelLabel[x, y].Text == "*") //Bombas
                {
                    TempoDeJogo.Enabled = false;
                    for (int i = 0; i < Largura; i++)
                    {
                        for (int j = 0; j < Altura; j++)
                        {
                            PanelButton[i, j].Visible = false;

                        }
                    }

                    Vencer = false;
                    buttonSmile.Image = DemoWF.Properties.Resources.Zangado1; //O Botao Smile passa para triste quando perde o jogo
                    MessageBox.Show("Perdeu!!  " + labelDuracao.Text + "  segundos", "Fim do Jogo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    if (Program.J_Jogador.Id != null)
                    {
                        GuadarResultado();
                        PedidoNovoJogo();
                        Vencer = false;
                        TempoDeJogo.Enabled = false;
                        PanelVazio(); //Plano claro
                        CriaPanel(); //Criar plano
                    }

                }
                LimpaVazio(); //Limpa o espaço em branco 
            }
        }

        //Se uma caixa tem 0 bombas ao redor, remove as caixas ao redor
        public void LimpaVazio()
        {
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    if (PanelLabel[i, j].Text == " " && !PanelButton[i, j].Visible)
                    {
                        Limpar(i, j); //Limpar Ajuda vazia
                    }
                }
            }
        }

        //Facilita a visualização do método acima
        public void Limpar(int x, int y)
        {
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i + x < Largura && j + y < Altura && i + x >= 0 && j + y >= 0)
                    {
                        if (PanelLabel[i + x, j + y].Text != "X")
                        {
                            PanelButton[x + i, y + j].Visible = false;
                        }
                    }
                }
            }
        }

        //Abre uma nova janela para selecionar o nível de dificuldade
        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PedidoDificuldade();
        }

        //Método para gerir a dificuldade selecionada
        public void InicioJogo(string dificuldade)
        {

            Vencer = false;
            PanelVazio();

            if (dificuldade == "Facil")
            {
                Largura = 9;
                Altura = 9;
                NumMinas = 10; //Numero de minas
            }
            if (dificuldade == "Medio")
            {
                Largura = 16;
                Altura = 16;
                NumMinas = 40;
            }

            //Corrige o tamanho da janela
            Width = (X_start + 9) * 2 + Largura * 22;
            Height = Y_start * 2 + Altura * 22;

            CriaPanel(); //Criar plano

        }

        //O modelo para todas as labels
        public Label CriaLabel(int x, int y)
        {
            Label label = new Label();
            Controls.AddRange(new System.Windows.Forms.Control[] { label, });
            label.Size = new System.Drawing.Size(22, 22);
            label.Location = new System.Drawing.Point(x, y);
            label.Text = " ";

            label.TextAlign = ContentAlignment.TopCenter;
            label.AutoSize = false;
            label.Font = new Font("Times new Roman", 13f);

            return label;
        }

        //O modelo para todos os botões
        public Button CriaButton(int x, int y)
        {
            Button btn = new Button();
            Controls.AddRange(new System.Windows.Forms.Control[] { btn, });
            btn.Size = new System.Drawing.Size(22, 22);
            btn.Location = new System.Drawing.Point(x, y);
            btn.BackColor = Color.White;

            btn.Click += new System.EventHandler(CliqueEsquerdo); //Clique esquerdo

            return btn;
        }

        //Este método cria todos os rótulos, botões e bombas
        public void CriaPanel()
        {
            Random random = new Random();

            NumMinastext = NumMinas;
            labelDuracao.Text = ("Duração: 0");
            labelMinas.Text = ("Minas: " + NumMinastext.ToString());
            buttonSmile.Image = DemoWF.Properties.Resources.Feliz44;

            PanelButton = new Button[Largura, Altura];
            PanelLabel = new Label[Largura, Altura];

            tempo = 0;

            buttonSmile.Location = new System.Drawing.Point((Width / 2) - 22, 0);
            buttonBandeira.Location = new System.Drawing.Point((Width / 2) + 25, 0);

            //Corrige botões e labels
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    PanelButton[i, j] = CriaButton(X_start + 22 * i, Y_start + 22 * j);
                    PanelLabel[i, j] = CriaLabel(X_start + 22 * i, Y_start + 22 * j);
                }
            }

            //Corrige bombas -- Dá o numero de minas ao longo do jogo (contador)
            for (int i = 0; i < NumMinas; i++)
            {
                int MinaX = random.Next(0, Largura);
                int MinaY = random.Next(0, Altura);

                if (PanelLabel[MinaX, MinaY].Text == "*")
                {
                    i--;
                }
                if (PanelLabel[MinaX, MinaY].Text != "*")
                {
                    PanelLabel[MinaX, MinaY].Text = "*";
                }
            }
            ContaMinas(Largura, Altura); //conta minas
        }

        public int MinasAoRedor = 0; //Minas ao redor

        //Verifica quantas bombas estão ao redor de cada caixa
        public void ContaMinas(int x, int y) //Contar Minas
        {
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    if (PanelLabel[i, j].Text != "*")
                    {
                        Contar(i, j);
                        if (MinasAoRedor == 1)
                        {
                            PanelLabel[i, j].Text = "1";
                            //PanelLabel[i, j].BackColor = Color.LightBlue;
                            PanelLabel[i, j].ForeColor = Color.Blue;

                        }
                        else
                        {
                            if (MinasAoRedor == 2)
                            {
                                PanelLabel[i, j].Text = "2";
                                //PanelLabel[i, j].BackColor = Color.LightGreen;
                                PanelLabel[i, j].ForeColor = Color.Green;
                            }
                            else
                            {
                                if (MinasAoRedor == 3)
                                {
                                    PanelLabel[i, j].Text = "3";
                                    //PanelLabel[i, j].BackColor = Color.LightCoral;
                                    PanelLabel[i, j].ForeColor = Color.DarkRed;
                                }
                                else
                                {
                                    if (MinasAoRedor == 4)
                                    {
                                        PanelLabel[i, j].Text = "4";
                                        //PanelLabel[i, j].BackColor = Color.Violet;
                                        PanelLabel[i, j].ForeColor = Color.DarkViolet;
                                    }

                                }
                            }
                        }
                        MinasAoRedor = 0;
                    }
                }
            }
        }

        //Serve para contar minas, tornou-se muito código em um só lugar
        public void Contar(int x, int y)
        {
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i + x < Largura && j + y < Altura && i + x >= 0 && j + y >= 0)
                    {
                        if (PanelLabel[x + i, y + j].Text == "*")
                        {
                            MinasAoRedor++;
                        }
                    }
                }
            }
        }

        private int tempo = 0; //Tempo

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoSairJogo();
        }

        //Tempo
        private void TempoDeJogo_Tick(object sender, EventArgs e)
        {

            dificuldade = Program.V_Dificuldade.DificuldadeMandar();


            int qtinicial = 0; //Quantidade inicial é de 0
            tempo++; //Tempo
            labelDuracao.Text = ("Duração: " + tempo.ToString());
            labelMinas.Text = ("Minas: " + NumMinastext.ToString());


            if (NumMinastext == 0)
            {
                for (int i = 0; i < Largura; i++)
                {
                    for (int j = 0; j < Altura; j++)
                    {
                        if (PanelButton[i, j].Text != "*" && !PanelButton[i, j].Visible)
                        {
                            qtinicial++;
                        }
                    }
                }

            }

            if (NumMinastext == 0 && (qtinicial == (Largura * Altura) - NumMinas)) //Quando o numero de minas for igual a 0
            {
                Vencer = true;
                TempoDeJogo.Enabled = false; //O tempo de jogo termina aqui
            }


            if (Vencer) //Se vencer
            {
                MessageBox.Show("Ganhasteeeee!!  " + labelDuracao.Text + "  segundos!", "Vitória!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PanelVazio(); //Limpa o Panel

                if (Program.J_Jogador.Id != null) //Quando o Id != null (quando o login está efetuado)
                {
                    GuadarResultado(); //Guarda o resultado no server
                    PedidoNovoJogo(); //Pedido novo jogo a partir do server
                }
                else //Quando o Id == null (quando o login não está efetuado)
                {
                    //Program.J_Jogador.MelhorTempo = tempo.ToString();  //Guarda o tempo na variavel melhor Tempo do Jogador
                    Program.V_Jogo.Hide();
                    Program.V_Nome.ShowDialog();
                    GuardarTempoOffline();
                }
            }
        }

        //Botão Reiniciar ":)"
        private void button1_Click(object sender, EventArgs e)
        {
            Vencer = false;
            TempoDeJogo.Enabled = false;
            PanelVazio(); //Plano claro
            CriaPanel(); //Criar plano
        }

        //Menu online
        private void menuOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.J_Jogador.Id == null)
            {
                menuOnlineToolStripMenuItem.Enabled = false;
            }
            else
            {
                PedidoVoltarMenuSec();
            }
        }

        //Menu offline
        private void menuOfflineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Program.J_Jogador.Id != null)
            {
                menuOfflineToolStripMenuItem.Enabled = false;
            }
            else
            {
                PedidoVoltarMenuPrin();
            }
        }

        //Exclui todas as caixas
        public void PanelVazio() //Panel vazio
        {
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    Controls.Remove(PanelButton[i, j]);
                    Controls.Remove(PanelLabel[i, j]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SelecionaMinas == false)
                SelecionaMinas = true;
            else
                SelecionaMinas = false;
        }

        public void GuadarResultado()
        {
            try
            {
                XDocument xmlResposta = Program.S_Server.PostResultado(dificuldade, tempo.ToString(), Vencer.ToString(), Program.J_Jogador.Id);

                if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
                {
                    //Apresenta mensagem de erro
                    MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("O resultado foi registado com sucesso!", "Registado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Mostra esta MessageBox sempre que o resultado for registado com sucesso.
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void GuardarTempoOffline()
        {
            void MudarNome(string nome)
            {
                Program.C_Top1.Nomejg = nome;
            }

            ViewNome viewnome = new ViewNome(MudarNome);

            viewnome.Disposed += new EventHandler((object sender, EventArgs e) =>
            {
                Program.C_Top1.Dificuldade = dificuldade;
                Program.C_Top1.Tempoperc = tempo;
                Program.C_Top1.GuardarTempo();
            });

            viewnome.Show();
        }

        public void PedidoNovoJogo() //Pedido novo jogo no servidor
        {
            XDocument xmlResposta = Program.S_Server.GetJogoNovo(Program.V_Jogo.dificuldade, Program.J_Jogador.Id);

            if (xmlResposta.Element("resultado").Element("status").Value == "ERRO")
            {
                //Apresenta mensagem de erro
                MessageBox.Show(xmlResposta.Element("resultado").Element("contexto").Value, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var dif in xmlResposta.Element("resultado").Element("objeto").Descendants("campo"))
                {
                    foreach (var posicao in dif.Descendants("posicao"))
                    {
                        if (int.Parse(posicao.Value) == -1)
                        {
                            int linha = (int.Parse(posicao.Attribute("linha").Value));
                            int coluna = (int.Parse(posicao.Attribute("coluna").Value));
                            PanelButton = new Button[linha, coluna];
                            PanelLabel = new Label[linha, coluna];
                        }
                    }
                }
            }
        }
    }
}
