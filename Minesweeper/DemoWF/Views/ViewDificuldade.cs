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

namespace DemoWF.Views
{
    public partial class ViewDificuldade : Form
    {
        //Eventos
        public MetodosSemParametros PedidoEstatisticas;

        public string dif { get; private set; }
        public ViewDificuldade()
        {
            InitializeComponent();
        }

        //Form da dificuldade, vem após o inicio do jogo
        private void buttonFacil_Click(object sender, EventArgs e)
        {
            string dificuldade = "Facil";
            Program.V_Jogo.InicioJogo(dificuldade);
            dif = dificuldade;

            Close();
        }

        private void buttonMedio_Click(object sender, EventArgs e)
        {
            string dificuldade = "Medio";
            dif = dificuldade;
            Program.V_Jogo.InicioJogo(dificuldade);
          
            Close();
        }

        public string DificuldadeMandar()
        {
            return dif;
        }

    }
}
