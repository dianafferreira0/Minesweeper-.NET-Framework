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
using DemoCommon.Classes;

namespace DemoWF.Views
{
    public partial class ViewTop1 : Form
    {
        //Eventos
        public event MetodosSemParametros PedidoVoltarMenuP;

        public ViewTop1()
        {
            InitializeComponent();
        }

        private void buttonMenuTop1_Click(object sender, EventArgs e)
        {
            PedidoVoltarMenuP();
        }

    }

}
