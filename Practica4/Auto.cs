using System;

namespace Practica4;

public class Auto
{
    private string Marca;
    private int Modelo;
    public Auto(string marca,int modelo){
        Marca=marca;
        Modelo=modelo;
    }
    public Auto()
    {
        Marca= "fiat";
        Modelo=DateTime.Now.Year;
    }
     public Auto(string marca):this()
    {
        Marca=marca;
    }

    public string ObtenerDescripcion(){
        return $"Auto {Marca} {Modelo}";
    }
    
}
