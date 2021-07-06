using DemoWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoCommon.Diversos;
using DemoWF.Views;
using DemoCommon.Classes;

namespace DemoWF
{
    static class Program
    {
        private static Action<string> met1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //Models
        public static Jogador J_Jogador { get; private set; }
        public static Jogador J_JogadorCons { get; private set; }
        public static Server S_Server { get; private set; }

        //Views
        public static ViewPrincipal V_Principal { get; private set; }
        public static ViewRegras V_Regras { get; private set; }
        public static ViewCreditos V_Creditos { get; private set; }
        public static ViewLogin V_Login { get; private set; }
        public static ViewPerfil V_Perfil { get; private set; }
        public static ViewSecundario V_Secundario { get; private set; }
        public static ViewRegistar V_Registar { get; private set; }
        public static ViewEstatisticas V_Estatisticas { get; private set; }
        public static ViewDificuldade V_Dificuldade { get; private set; }
        public static ViewJogo V_Jogo { get; private set; }
        public static ViewTop1 V_Top1 { get; private set; }
        public static ViewNome V_Nome;

        //Controllers
        public static ControllerWF C_WF { get; private set; }
        public static ControllerTop1 C_Top1 { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Models
            J_Jogador = new Jogador();
            S_Server = new Server();
            J_JogadorCons = new Jogador();

            //Views
            V_Principal = new ViewPrincipal();
            V_Regras = new ViewRegras();
            V_Creditos = new ViewCreditos();
            V_Login = new ViewLogin();
            V_Perfil = new ViewPerfil();
            V_Secundario = new ViewSecundario();
            V_Registar = new ViewRegistar();
            V_Jogo = new ViewJogo();
            V_Estatisticas = new ViewEstatisticas();
            V_Dificuldade = new ViewDificuldade();
            V_Top1 = new ViewTop1();
           // V_Nome = new ViewNome();

            //Controller
            C_WF = new ControllerWF();
            C_Top1 = new ControllerTop1();

            Application.Run(V_Principal);
        }
    }
}
