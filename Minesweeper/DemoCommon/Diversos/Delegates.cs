using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCommon.Diversos
{
    //Delegado utilizado para consulta perfil nas estatísticas
    public delegate void MetodosComString(string username);

    //Declaração de delegado que representa métodos que não recebem parâmetros de entrada
    public delegate void MetodosSemParametros();
    
}
