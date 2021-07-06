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
    public partial class ViewPrincipal : Form
    {
        //Eventos
        public event MetodosSemParametros PedidoSairApp;
        public event MetodosSemParametros PedidoRegras;
        public event MetodosSemParametros PedidoCreditos;
        public event MetodosSemParametros PedidoOnline;
        public event MetodosSemParametros PedidoOffline;
        public event MetodosSemParametros PedidoTop1; 

        public ViewPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PedidoCreditos();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            PedidoOnline();
        }

        private void buttonRegras_Click(object sender, EventArgs e)
        {
            PedidoRegras();
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            PedidoOffline();
        }

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            PedidoSairApp();
        }

        private void buttonTop1_Click(object sender, EventArgs e)
        {
            PedidoTop1();
        }
    }
}
