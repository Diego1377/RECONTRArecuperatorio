namespace AgenciaDeCambioPOO.Entidades
{
    public interface IMoneda
    {
        string Abreviatura { get; set; }
        decimal Cantidad { get; set; }
        string Nombre { get; set; }

        string MostrarDatos();
        decimal ObtenerValorEnPesos();
    }
}