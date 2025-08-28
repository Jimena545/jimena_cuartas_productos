// See https://aka.ms/new-console-template for more information
using System.Security.Claims;

Console.WriteLine("Hello, World!");

Productos Producto = new Productos();
Producto.idP = 111;
Producto.nombreP = "uniforme";
Producto.precio = 40000;
Producto.cantidad = 6;


Console.WriteLine(Producto.idP);
Console.WriteLine(Producto.nombreP);
Console.WriteLine(Producto.precio);
Console.WriteLine(Producto.cantidad);
public class Productos()
{
    public int idP;
    public string? nombreP;
    public decimal precio;
    public int cantidad;
    public List<Clientes>?Clientes;
}

public class Balones() : Productos
{
    public string? tipo;
    public decimal tamano;

}

public class Raquetas() : Productos
{
    public string? color;

}

public class Clientes()
{
    public int idC;
    public string? nomC;
    public string? dirC;
    public bool activo;
    public List<Productos>? Productos;
}

