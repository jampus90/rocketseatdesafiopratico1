namespace DesafioPraticoRS1;
public class OperacoesMatematicas
{
    public double SomaDouble(double x, double y)
    {
        return x + y;
    }
    public double SubtraiDouble(double x, double y)
    {
        return x - y;
    }
    public double MultiplicaDouble(double x, double y)
    {
        return x * y;
    }
    public double DivideDouble(double x, double y)
    {
        if (x == 0)
        {
            Console.WriteLine("Y não pode ter valor 0!");
            return 0;
        }

        return x / y;
    }
    public double MediaDouble(double x, double y)
    {
        return (x + y)/2;
    }
}
