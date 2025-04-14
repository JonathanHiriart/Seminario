namespace Practica5;
class Cuadrado{
    private double _lado;
    public double Lado{

        get{
            return _lado;
        }
        set{
            _lado= value;
        }
    }
    public double Area {
        get{
            return _lado *_lado;
        }
    }
}