using Newtonsoft.Json.Linq;
using PRACTICA__4.modelo;
using System.Text.Json;

namespace PRACTICA__4.servicio
{
    public class PaisesServicios : IAccciones
    {


        public List<Paises> pssp() {

            string jsonfile = File.ReadAllText("C:\\Users\\adria\\OneDrive\\Escritorio\\curso poo c#\\PRACTICA #4\\Practica4.json");
            List<Paises> paises = JsonSerializer.Deserialize<List<Paises>>(jsonfile)!;

            return paises;
        }
        public List<Paises> getpaises()
        {


            return pssp().ToList();
        }

        public string NombreYapellido(string nombre, string apellido)
        {
            string[] nombres = nombre.Split(' ');
            string nomb = nombres[0];
            string[] apellidos = apellido.Split(' ');
            string ape = apellidos[0];
            return nomb + " " + ape;
        }

        public List<string> pais(string continente)
        {
            List<string> result = new List<string>();
            foreach (Paises item in pssp())
            {
                if (item.Continente == continente)
                {
                    result.Add(item.Pais);

                }
            }

            return result;

        }

        public List<Paises> paisM(int cantidadP)
        {

            var paisesOrdenados = pssp().OrderByDescending(p => p.Poblacion).ToList();


            return paisesOrdenados.Take(cantidadP).ToList();
        //
        }

    }
}
