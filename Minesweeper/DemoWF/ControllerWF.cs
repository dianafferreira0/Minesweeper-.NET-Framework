using System;
using System.Windows.Forms;
using DemoWF.Views;

namespace DemoWF
{
    public class ControllerWF
    {
        //Construtor do ControllerJogador
        public ControllerWF()
        {
            //ViewPrincipal
            Program.V_Principal.PedidoSairApp += V_Principal_PedidoSairApp;
            Program.V_Principal.PedidoRegras += V_Principal_PedidoRegras;
            Program.V_Principal.PedidoCreditos += V_Principal_PedidoCreditos;
            Program.V_Principal.PedidoOnline += V_Principal_PedidoOnline;
            Program.V_Principal.PedidoOffline += V_Principal_PedidoOffline;
            Program.V_Principal.PedidoTop1 += V_Principal_PedidoTop1;

            //ViewCreditos
            Program.V_Creditos.PedidoVoltarMenuCr += V_Creditos_PedidoVoltarMenuCr;

            //ViewRegras
            Program.V_Regras.PedidoVoltarMenuR += V_Regras_PedidoVoltarMenuR;

            //ViewJogo
            Program.V_Jogo.PedidoDificuldade += V_Jogo_PedidoDificuldade;
            Program.V_Jogo.PedidoSairJogo += V_Jogo_PedidoSairJogo;
            Program.V_Jogo.PedidoVoltarMenuSec += V_Jogo_PedidoVoltarMenuSec;
            Program.V_Jogo.PedidoVoltarMenuPrin += V_Jogo_PedidoVoltarMenuPrin; 

            //ViewSecundário
            Program.V_Secundario.PedidoConsultarPerfil += V_Secundario_PedidoConsultarPerfil;
            Program.V_Secundario.PedidoLogout += V_Secundario_PedidoLogout;
            Program.V_Secundario.PedidoJogo += V_Secundario_PedidoJogo;
            Program.V_Secundario.PedidoTop10 += V_Secundario_PedidoTop10;

            //ViewEstatisticas
            Program.V_Estatisticas.PedidoConsultaPerfil += V_Estatisticas_PedidoConsultaPerfil;
            Program.V_Estatisticas.PedidoSairAppEst += V_Estatisticas_PedidoSairAppEst;
            Program.V_Estatisticas.PedidoVoltarMenuSec += V_Estatisticas_PedidoVoltarMenuSec;

            //ViewPerfil
            Program.V_Perfil.PedidoVoltarMenuP += V_Perfil_PedidoVoltarMenuP;

            //ViewLogin
            Program.V_Login.PedidoVoltarMenuL += V_Login_PedidoVoltarMenuL;
            Program.V_Login.PedidoRegistar += V_Login_PedidoRegistar;

            //ViewRegistar
            Program.V_Registar.PedidoVoltar += V_Registar_PedidoVoltar;

            //ViewTop1
            Program.V_Top1.PedidoVoltarMenuP += V_Top1_PedidoVoltarMenuP; // <------------------
        }

        //ViewTop1
        private void V_Top1_PedidoVoltarMenuP() //<--------------
        {
            //Mostrar ViewPrincipal
            (Program.V_Principal as Form).Show();

            //Esconde a ViewTop1
            (Program.V_Top1 as Form).Hide();
        }

        //ViewRegistar
        private void V_Registar_PedidoVoltar()
        {
            //Mostrar ViewLogin
            (Program.V_Login as Form).Show();

            //Esconde a ViewRegistar
            (Program.V_Registar as Form).Hide();
        }

        //ViewLogin
        private void V_Login_PedidoVoltarMenuL()
        {
            //Mostrar ViewPrincipal
            (Program.V_Principal as Form).Show();

            //Esconde a ViewLogin
            (Program.V_Login as Form).Hide();
        }

        private void V_Login_PedidoRegistar()
        {
            //Mostrar ViewRegistar
            (Program.V_Registar as Form).Show();

            //Esconde a ViewLogin
            (Program.V_Login as Form).Hide();
        }


        //ViewPerfil
        private void V_Perfil_PedidoVoltarMenuP()
        {
            //Mostrar ViewSecundario
            (Program.V_Secundario as Form).Show();

            //Esconde a ViewPerfil
            (Program.V_Perfil as Form).Hide();
        }


        //ViewSecundario
        private void V_Secundario_PedidoLogout() // <------------------------
        {
            Program.J_Jogador.Id = null; //Coloca o id do Jogador em null
            //Program.J_Jogador.Username = null; //Coloca o username em null;

            //Volta ao menu principal
            (Program.V_Principal as Form).Show();
            //Esconde o menu secundario
            (Program.V_Secundario as Form).Hide();

            //Messagebox
            MessageBox.Show("O logout foi efetuado com sucesso!");
        }

        private void V_Secundario_PedidoTop10()
        {
            //Mostrar ViewEstatisticas
            (Program.V_Estatisticas as Form).Show();

            //Esconde a ViewSecundario
            (Program.V_Secundario as Form).Hide();
        }

        private void V_Secundario_PedidoConsultarPerfil()
        {
            //Mostrar ViewPerfil
            (Program.V_Perfil as Form).Show();

            //Esconde a ViewSecundario
            (Program.V_Secundario as Form).Hide();
        }

        private void V_Secundario_PedidoJogo()
        {
            //Mostrar ViewJogo
            (Program.V_Jogo as Form).Show();

            //Esconde a ViewSecundario
            (Program.V_Secundario as Form).Hide();
        }

        //ViewJogo
        private void V_Jogo_PedidoSairJogo()
        {
            Application.Exit(); //Fecha a app (jogo)
        }

        private void V_Jogo_PedidoDificuldade()
        {
            //Mostrar ViewDificuldade 
            (Program.V_Dificuldade as Form).Show();
        }

        private void V_Jogo_PedidoVoltarMenuPrin()
        {
            //Mostrar ViewPrincipal
            (Program.V_Principal as Form).Show();

            //Esconde a ViewJogo
            (Program.V_Jogo as Form).Hide();
        }

        private void V_Jogo_PedidoVoltarMenuSec() 
        {
            //Mostrar ViewSecundario
            (Program.V_Secundario as Form).Show();

            //Esconde a ViewJogo
            (Program.V_Jogo as Form).Hide();
        }


        //ViewRegras
        private void V_Regras_PedidoVoltarMenuR()
        {
            //Mostrar ViewPrincipal (Menu)
            (Program.V_Principal as Form).Show();

            //Esconde a ViewRegras
            (Program.V_Regras as Form).Hide();
        }


        //ViewCreditos
        private void V_Creditos_PedidoVoltarMenuCr()
        {
            //Mostrar ViePrincipal (Menu)
            (Program.V_Principal as Form).Show();

            //Esconde a ViewCreditos
            (Program.V_Creditos as Form).Hide();
        }


        //ViewPrincipal
        private void V_Principal_PedidoOnline()
        {
            //Mostrar ViewLogin (Modo online)
            (Program.V_Login as Form).Show();

            //Esconde a ViewPrincipal
            (Program.V_Principal as Form).Hide();
        }

        private void V_Principal_PedidoOffline()
        {
            //Mostrar ViewJogo (Modo offline)
            (Program.V_Jogo as Form).Show();

            //Esconde a ViewPrincipal
            (Program.V_Principal as Form).Hide();
        }

        private void V_Principal_PedidoCreditos()
        {
            //Mostrar ViewCreditos
            (Program.V_Creditos as Form).Show();

            //Esconde a ViewPrincipal
            (Program.V_Principal as Form).Hide();
        }

        private void V_Principal_PedidoRegras()
        {
            //Mostrar ViewRegras
            (Program.V_Regras as Form).Show();

            //Esconde a ViewPrincipal
            (Program.V_Principal as Form).Hide();
        }

        private void V_Principal_PedidoTop1()
        {
            //Mostrar ViewTop1
            (Program.V_Top1 as Form).Show();

            //Esconde a ViewPrincipal
            (Program.V_Principal as Form).Hide();
        }

        private void V_Principal_PedidoSairApp()
        {
            Application.Exit();
        }


        //ViewEstatisticas
        private void V_Estatisticas_PedidoConsultaPerfil(string jg)
        {
            //Program.J_JogadorCons.Username = jg;
            //Criamos um jogador só para consulta, para q este não trouxesse o nome do meu username consigo e assim estar null
            //Para ver o perfil da pessoa selecionada na lista (linha)
            string linha = jg.Substring(jg.IndexOf(';') + 1);
            Program.J_JogadorCons.Username = linha.Split(';')[0]; //O split procura o parametro anterior ao ';', ou seja o username
            // Program.S_Server.GetPerfil(Program.J_JogadorCons.Username);
            (Program.V_Perfil as Form).Show();
        }

        private void V_Estatisticas_PedidoSairAppEst()
        {
            Application.Exit();
        }

        private void V_Estatisticas_PedidoVoltarMenuSec()
        {
            //Mostrar ViewSecundario
            (Program.V_Secundario as Form).Show();

            //Esconde a ViewEstatisticas
            (Program.V_Estatisticas as Form).Hide();
        }
    }
}

