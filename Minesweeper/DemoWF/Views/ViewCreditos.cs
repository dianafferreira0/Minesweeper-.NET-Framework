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
    public partial class ViewCreditos : Form
    {
        //Eventos
        public event MetodosSemParametros PedidoVoltarMenuCr;

        public ViewCreditos()
        {
            InitializeComponent();
        }

        private void buttonMenuCr_Click(object sender, EventArgs e)
        {
            PedidoVoltarMenuCr();
        }
    }
}
