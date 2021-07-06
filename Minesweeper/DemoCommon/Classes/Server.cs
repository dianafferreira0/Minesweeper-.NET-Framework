using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace DemoCommon.Classes
{
	public class Server
	{
		public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		//Função que serve para efetuar o login
		public XDocument PostLogin(string username, string password)
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/autentica");

				// Com o acesso usa HTTPS e o servidor usar cerificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado. 
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				// prepara os dados do pedido a partir de uma string só com a estrutura do XML (sem dados) 
				XDocument xmlPedido = XDocument.Parse("<credenciais><username></username><password></password></credenciais>");

				xmlPedido.Element("credenciais").Element("username").Value = username;
				xmlPedido.Element("credenciais").Element("password").Value = password;

				string mensagem = xmlPedido.Root.ToString();

				byte[] data = Encoding.Default.GetBytes(mensagem);
				request.Method = "POST";// método usado para enviar o pedido 
				request.ContentType = "application/xml"; // tipo de dados que é enviado com o pedido 
				request.ContentLength = data.Length; // comprimento dos dados enviado no pedido 

				Stream newStream = request.GetRequestStream(); // obtem a referência do stream associado ao pedido... 
				newStream.Write(data, 0, data.Length);// ... que permite escrever os dados a ser enviados ao servidor 
				newStream.Close();

				HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); // obtem o stream associado à resposta. 
				StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8); // Canaliza o stream para um leitor de stream de nível superior com o formato de codificação necessário. 
				string resultado = readStream.ReadToEnd();
				response.Close();
				readStream.Close();

				// converte para objeto XML para facilitar a extração da informação e ... 
				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//Função que serve para efetuar o registo
		public XDocument PostRegisto(string nomeabv, string user, string password, string email, string pais, string foto)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/registo");
			//Com o acesso usa HTTPS e o servidor usar certificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado.

			ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
			//prepara os dados do pedido a partir de uma string só com a estrutura do XML(sem dados)

			XDocument xmlPedido = XDocument.Parse("<registo><nomeabreviado></nomeabreviado><username></username><password></password><email></email><fotografia></fotografia><pais></pais></registo>");

			xmlPedido.Element("registo").Element("nomeabreviado").Value = nomeabv; //Colocar nomeabreviado do utilizador
			xmlPedido.Element("registo").Element("username").Value = user; //Colocar username do utilizador
			xmlPedido.Element("registo").Element("password").Value = password; //Colocar aqui a password do utilizador
			xmlPedido.Element("registo").Element("email").Value = email; //Colocar email do utilizador
			xmlPedido.Element("registo").Element("fotografia").Value = foto; //Colocar fotografia do utilizador
			xmlPedido.Element("registo").Element("pais").Value = pais; //Colocar pais do utilizador

			string mensagem = xmlPedido.Root.ToString();

			byte[] data = Encoding.Default.GetBytes(mensagem); //Note: choose appropriate encoding
			request.Method = "POST"; //Método usado para enviar o pedido
			request.ContentType = "text/xml;charset=utf-8"; //Tipo de dados que é enviado com o pedido
			request.ContentLength = data.Length; //Comprimento dos dados enviado no pedido

			Stream newStream = request.GetRequestStream(); //Obtem a referência da stream associada ao pedido...
			newStream.Write(data, 0, data.Length); // ...Que permite escrever os dados a ser enviados ao servidor
			newStream.Close();

			HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //Faz o envio do pedido
			Stream receiveStream = response.GetResponseStream(); //Obtem a stream associada à resposta
			StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8); //Canaliza a stream para um leitor da stream de nivel superior

			string resultado = readStream.ReadToEnd();
			response.Close();
			readStream.Close();

			//Converte para objeto XML para facilitar a extração da informação
			XDocument xmlResposta = XDocument.Parse(resultado);
			return xmlResposta;
		}

		//Função para obter o perfil
		public XDocument GetPerfil(string username)
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/perfil/" + username);

				//Com o acesso usa HTTPS e o servidor usar certificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado.
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				request.Method = "GET";
				HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //Faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); //Obtem o stream associado à resposta
				StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8); //Canaliza a stream para um leitor de stream de nivel superior com o formato de codificação necessário

				string resultado = reader.ReadToEnd();
				response.Close();
				reader.Close();

				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//Função para obter o Top10
		public XDocument GetTop10()
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/top10");

				//Com o acesso usa HTTPS e o servidor usar certificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado.
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				request.Method = "GET";
				HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); //obtem o stream associado à resposta
				StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8); //Canalizaa stream para um leitor de stream de nivel superior com o formato de codificação necessário

				string resultado = reader.ReadToEnd();
				response.Close();
				reader.Close();

				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//Função para obter um jogo novo
		public XDocument GetJogoNovo(string nivel, string id)
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/novo/" + nivel + "/" + id);

				//Com o acesso usa HTTPS e o servidor usar certificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado.
				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

				request.Method = "GET";
				HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //faz o envio do pedido

				Stream receiveStream = response.GetResponseStream(); //obtem o stream associado à resposta
				StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8); //Canalizaa stream para um leitor de stream de nivel superior com o formato de codificação necessário

				string resultado = reader.ReadToEnd();
				response.Close();
				reader.Close();

				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//Função que serve para mostrar resultado
		public XDocument PostResultado(string nivel, string tempo, string vitoria, string id)
		{
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://prateleira.utad.priv:1234/LPDSW/2019-2020/resultado/" + id);
				//Com o acesso usa HTTPS e o servidor usar certificados autoassinados, temos de configurar o cliente para aceitar sempre o certificado.

				ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
				//prepara os dados do pedido a partir de uma string só com a estrutura do XML(sem dados)

				XDocument xmlPedido = XDocument.Parse("<resultado_jogo><nivel></nivel><tempo></tempo><vitoria></vitoria></resultado_jogo>");

				xmlPedido.Element("resultado_jogo").Element("nivel").Value = nivel; // Colocar o nivel do jogo
				xmlPedido.Element("resultado_jogo").Element("tempo").Value = tempo; // Colocar o tempo de duração do jogo
				xmlPedido.Element("resultado_jogo").Element("vitoria").Value = vitoria; // Colocar a vitoria

				string mensagem = xmlPedido.Root.ToString();

				byte[] data = Encoding.Default.GetBytes(mensagem); //Note: choose appropriate encoding
				request.Method = "POST"; //Método usado para enviar o pedido
				request.ContentType = "text/xml;charset=utf-8"; //Tipo de dados que é enviado com o pedido //text/xml;charset=utf-8
				request.ContentLength = mensagem.Length; //Comprimento dos dados enviado no pedido

				Stream newStream = request.GetRequestStream(); //Obtem a referência da stream associada ao pedido...
				newStream.Write(data, 0, data.Length); // ...Que permite escrever os dados a ser enviados ao servidor
				newStream.Close();

				HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //Faz o envio do pedido
				Stream receiveStream = response.GetResponseStream(); //Obtem a stream associada à resposta
				StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8); //Canaliza a stream para um leitor da stream de nivel superior

				string resultado = readStream.ReadToEnd();
				response.Close();
				readStream.Close();

				XDocument xmlResposta = XDocument.Parse(resultado);

				return xmlResposta;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}


