using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoWF
{
    public class ControllerTop1
    {
        private readonly List<string> Listadif; //Lista dificuldade
        public string Nomejg { get; set; } //Vai servir para o nome do jogador
        public string Dificuldade { get; set; } //Vai serir para a dificuldade
        public double Tempoperc { get; set; } //Vai servir para o tempo
        private readonly string diretorio;

        //Construtor do controller
        public ControllerTop1()
        {
            diretorio = AppDomain.CurrentDomain.BaseDirectory;
            Listadif = new List<string>
            {
                "Facil",
                "Medio"
            };
        }

        public void FicheiroXml(XmlDocument doc)
        {
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null); //Declaração
            XmlElement root = doc.DocumentElement; //Cria a raiz
            doc.InsertBefore(xmlDeclaration, root); //Insere o root antes da declaração

            XmlElement principal = doc.CreateElement(string.Empty, "Scores", string.Empty); //Elemento principal
            doc.AppendChild(principal);

            Listadif.ForEach(dif =>
            {
                XmlElement elemento = doc.CreateElement(string.Empty, dif, string.Empty);

                XmlElement nome = doc.CreateElement(string.Empty, "Nome", string.Empty);
                nome.AppendChild(doc.CreateTextNode(""));
                elemento.AppendChild(nome);

                XmlElement tempoo = doc.CreateElement(string.Empty, "Tempo", string.Empty);
                tempoo.AppendChild(
                doc.CreateTextNode(""));
                elemento.AppendChild(tempoo);
                principal.AppendChild(elemento);
            });
        }

        public void GuardarTempo()
        {
            XmlDocument doc = new XmlDocument(); //Cria novo documento

            //Se o ficheiro não existir ent ele cria um novo ficheiro e volta a repetir o código
            try
            {
                doc.Load(Path.Combine(diretorio, "../..") + "\\Top1.xml"); //Tenta abrir o ficheiro
            }
            catch (FileNotFoundException)
            {
                FicheiroXml(doc);
                GuardarTempo(); //Volta a repetir a função
            }

            AtualizaFicheiro(doc); //Faz uma atualização no melhor tempo

            doc.Save(Path.Combine(diretorio, "../..") + "\\Top1.xml");
        }

        private void AtualizaFicheiro(XmlDocument doc) //Serve para atualizar o ficheiro sempre que ele tem um melhor tempo
        {
            XmlNodeList nodes = doc.GetElementsByTagName(Dificuldade);

            if (nodes.Count == 0)
            {
                //throw some exception
                return;
            }

            if (ObteveMelhorTmp(nodes)) //Se existir um tempo maior
            {
                XmlNode dif = nodes[0];

                dif.ChildNodes[0].InnerText = Nomejg; //Na primeira posição do nó mete o nome do jogador
                dif.ChildNodes[1].InnerText = Convert.ToString(Tempoperc) + " " + "seconds"; //Na segunda posição do nó mete o tempo
            }
        }

        public bool ObteveMelhorTmp(XmlNodeList nodes)
        {
            XmlNode dif = nodes[0];

            string tmpatual = dif.ChildNodes[1].InnerText;

            //Se o tempo ainda não for registado
            if (tmpatual == "")
            {
                return true;
            }

            double Melhortmpatual = Convert.ToDouble(tmpatual.Split(' ')[0]);

            return Melhortmpatual > Tempoperc; //Se o tempo atual for maior que o tempo q já estava lá no ficheiro
        }
    }
}
