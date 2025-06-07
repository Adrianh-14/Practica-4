
using PRACTICA__4.modelo;

public interface IAccciones
{
    public List<Paises> getpaises();

    public List<string> pais(string continente);
    public List<Paises> paisM(int cantidadP);

    public string NombreYapellido(string nombre, string apellido);

}

