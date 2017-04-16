using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de clscalculos
/// </summary>
public class clscalculos
{
    private double suma, resta, producto;
	public clscalculos(double suma, double resta, double producto)
	{
        this.suma = suma;
        this.resta = resta;
        this.producto = producto;
	}

    public double Suma(double val1, double val2) {
        suma = val1 + val2;
        return suma;
    }
    public double Resta(double val1, double val2)
    {
        resta = val1 - val2;
        return resta;
    }
    public double Producto(double val1, double val2)
    {
        producto = val1 * val2;
        return producto;
    }
}