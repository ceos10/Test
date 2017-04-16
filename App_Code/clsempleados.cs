using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Descripción breve de clsempleados
/// </summary>
public class clsempleados: conexionregistro    
{
    //declaracion de variables
    string tabla = "empleado";
    string cedula, nombre, tipo, salario, horas;
    string salariobruto, deducciones, salarioneto;
	public clsempleados(string cedula, string nombre, string tipo, string salario, string horas, string salariobruto, string deducciones, string salarioneto)
	{
        this.cedula = cedula;
        this.nombre = nombre;
        this.tipo = tipo;
        this.salario = salario;
        this.horas = horas;
        this.salariobruto = salariobruto;
        this.deducciones = deducciones;
        this.salarioneto = salarioneto;
	}

    public string Cedula 
    {
        set { cedula = value; }
        get { return cedula; }
    }
    public string Nombre
    {
        set { nombre = value; }
        get { return nombre; }
    }
    public string Tipo
    {
        set { tipo = value; }
        get { return tipo; }
    }
    public string Salario
    {
        set { salario = value; }
        get { return salario; }
    }
    public string Horas
    {
        set { horas = value; }
        get { return horas; }
    }
    public string Salariobruto
    {
        set { salariobruto = value; }
        get { return salariobruto; }
    }
    public string Deducciones
    {
        set { deducciones = value; }
        get { return deducciones; }
    }
    public string Salarioneto
    {
        set { salarioneto = value; }
        get { return salarioneto; }
    }

    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["cedula"] = Cedula;
        fila["nombre"] = Nombre;
        fila["tipo"] = Tipo;
        fila["salario_hora"] = int.Parse(Salario);
        fila["horas"] = int.Parse(Horas);

        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDatos.Update(Data, tabla);
    }
    public Double calculoSalarioBruto(int salario, int horas) {
        double resultado = salario * horas;
        return resultado;
    }
    public Double calculoDeducciones(int salarioBruto)
    {
        Double resultado = salarioBruto * 0.09;
        return resultado;
    }
    public Double calculoSalarioNeto(int salarioBruto, int deducciones)
    {
        Double resultado = salarioBruto - deducciones;
        return resultado;
    }
}