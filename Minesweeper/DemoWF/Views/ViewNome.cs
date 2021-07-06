using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWF.Views
{
    public partial class ViewNome : Form
    {
        private readonly Action<string> acao;

        public ViewNome(Action<string> met)
        {
            InitializeComponent();
            acao = met;
        }

        private void buttonOKNome_Click(object sender, EventArgs e)
        {
            Regex exp = new Regex(@"^[a-zA-Z]+$");

            if (!exp.Match(textBoxFinalNome.Text).Success) //Se for diferente de sucesso
            {
                MessageBox.Show("Erro! Coloque só o primeiro nome! Credenciais erradas!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                acao(textBoxFinalNome.Text);
                MessageBox.Show("Nome registado com sucesso!");
                Dispose();
            }
        }

        private void ViewNome_Load(object sender, EventArgs e)
        {

        }
    }
}
