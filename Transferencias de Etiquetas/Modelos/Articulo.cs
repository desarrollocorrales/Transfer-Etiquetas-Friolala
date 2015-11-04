
namespace Transferencias_de_Etiquetas.Modelos
{
    public class Articulo
    {
        public string clave { set; get; }
        public int id_bodega { set; get; }

        public Articulo(string clave, int id_bodega)
        {
            this.clave = clave;
            this.id_bodega = id_bodega;
        }
    }
}
