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
    public partial class ViewRegras : Form
    {
        //Eventos
        public event MetodosSemParametros PedidoVoltarMenuR;

        public ViewRegras()
        {
            InitializeComponent();
        }

        private void buttonMenuR_Click(object sender, EventArgs e)
        {
            PedidoVoltarMenuR();
        }
    }
}
