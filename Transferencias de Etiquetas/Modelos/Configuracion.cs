using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transferencias_de_Etiquetas.Modelos
{
    public enum TipoParametro
    {
        Servidor = 1,
        Usuario = 2,
        Contraseña = 3,
        Puerto = 4,
        BaseDeDatos = 5,
        UrlWebService = 6
    }

    public class Configuracion
    {
        public TipoParametro _TipoParametro { set; get; }
        public string _Parametro { set; get; }
        public string _Valor { set; get; }

        public Configuracion(TipoParametro tipoParametro, string Parametro, string Valor)
        {
            this._TipoParametro = tipoParametro;
            this._Parametro = Parametro;
            this._Valor = Valor;
        }
    }
}
