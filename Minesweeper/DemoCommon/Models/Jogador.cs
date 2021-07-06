using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCommon.Classes
{
    public class Jogador
    {
        public string Username { set; get; } //username de acesso a conta do utilizador
        public string Password { set; get; } //password de acesso a conta do utilizador 
        public string Email { set; get; } // e-mail do utilizador
        public string Pais { set; get; } //pais do utilizador
        public string Nome { get; set; }
        public string Id { get; set; }
        public string MelhorTempo { get; set; }
        public string Foto { get; set; }
        public string Vitoria { get; set; }
        public string Nivel { get; set; }

        public Jogador()
            : base()
        {
            this.Username = "\0";
            this.Password = "\0";
            this.Email = "\0";
            this.Pais = "\0";
        }
        public Jogador(string Username, string Password, string Email, string Pais, string Nome, string Id, string MelhorTempo, string Foto)
        {
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.Pais = Pais;
            this.Nome = Nome;
            this.Id = Id;
            this.MelhorTempo = MelhorTempo;
            this.Foto = Foto;
        }
        public Jogador(string Nivel, string MelhorTempo, string Vitoria)
        {
            this.Nivel = Nivel;
            this.MelhorTempo = MelhorTempo;
            this.Vitoria = Vitoria;
        }

        public Jogador(string id)
        {
            this.Id = Id;
        }
    }
}
