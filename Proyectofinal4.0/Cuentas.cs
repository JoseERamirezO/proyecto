using System;
using System.Collections.Generic;

public class Cuentas
{
    public List<Cuenta> ListadeCuentas { get; set; }
    public Cuentas()
    {
        ListadeCuentas = new List<Cuenta>();

        Cuenta a = new Cuenta("001", "Deudas    ", 4000);
        Cuenta b = new Cuenta("002", "Pagos     ", 2300);
        Cuenta c = new Cuenta("003", "Inventario", 12000);
        Cuenta d = new Cuenta("004", "Utilidades", 3000);
        Cuenta e = new Cuenta("005", "Otros     ", 4000);
        

        ListadeCuentas.Add(a);
        ListadeCuentas.Add(b);
        ListadeCuentas.Add(c);
        ListadeCuentas.Add(d);
        ListadeCuentas.Add(e);
    }

    
    public void listarCuentas() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo, Descripcion y Existencia");

        foreach (var cuenta in ListadeCuentas)
        {
            Console.WriteLine(cuenta.Codigo + " | " + cuenta.Descripcion );
        }

        Console.ReadLine();
    }

    private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
        foreach (var cuenta in ListadeCuentas)
        {
            if (cuenta.Codigo == codigo) {
                if (tipoMovimiento == "+") {
                    cuenta.Efectivo = cuenta.Efectivo + cantidad;
                } else {
                    cuenta.Efectivo = cuenta.Efectivo - cantidad;
                }
            }         
        }
    }

    public void ingresoDeEfectivo()
     {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }


    public void Pagoenefectivo()
     {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("**********************************");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }
    public void Estadofinanciero() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo, Descripcion y Existencia");

        foreach (var cuenta in ListadeCuentas)
        {
            Console.WriteLine(cuenta.Codigo + " | " + cuenta.Descripcion + " | " + cuenta.Efectivo.ToString());
        }

        Console.ReadLine();
    }
    
}

    