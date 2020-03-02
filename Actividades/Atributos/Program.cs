using System;

class Program
{
static void Main(string[] args)
{
    Aprendiz apSena = new Aprendiz();
    apSena.NombresAprendiz = " Maria del Rosario ";
    apSena.ApellidosAprendiz = " Zuñiga Sampablo ";
    apSena.Direccion= " Calle 19sur";
    apSena.MunicipioResidencia = " Pitalito ";
     
    Saludo(apSena);
}
private static void Saludo(Aprendiz ApSena)
    {
        Console.WriteLine(" Bienvenido Sr(a): "+ ApSena.NombresAprendiz +
                          " Su apellido es: " + ApSena.ApellidosAprendiz +
                          " Su direccion es: " + ApSena.Direccion +                
                          " Su ciudad de residencia es: " + ApSena.MunicipioResidencia);
        Console.ReadLine();
    }
}

