using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoCommon.Diversos;

namespace DemoWF.Views
{
    public partial class ViewSecundario : Form
    {
        //Eventos
        public event MetodosSemParametros PedidoLogout;
        public event MetodosSemParametros PedidoConsultarPerfil;
        public event MetodosSemParametros PedidoJogo;
        public event MetodosSemParametros PedidoTop10;

        public ViewSecundario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PedidoConsultarPerfil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PedidoLogout();
        }

        private void buttonJogar2_Click(object sender, EventArgs e)
        {
            PedidoJogo();
        }

        private void buttonTop10_Click(object sender, EventArgs e)
        {
            PedidoTop10();
        }
    }
}
