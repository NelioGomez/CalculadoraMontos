// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** CONTROL DE VENTAS ***");
Console.WriteLine();

//variables 
double ic, id, ipp;
int u;

//Entrada
Console.WriteLine("Ingrese el valor del producto ");
ic = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de unidades a comprar: ");
u = int.Parse(Console.ReadLine());

//calculo
id = ic * 0.11;
ipp = ic - id;

//Salida
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("El importe de compra es de: "+ ic.ToString("0.00"));
Console.WriteLine("El importe con reduccion es de: "+ id.ToString("0.00"));
Console.WriteLine("El importe total a pagar es de: " + ipp.ToString("0.00"));