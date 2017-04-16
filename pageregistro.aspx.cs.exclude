using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageregistro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btncalcular_Click(object sender, EventArgs e)
    {
        try
        {
            clsempleados emp = new clsempleados("", "", "", "", "", "", "", "");
            emp.Cedula = txtcedula.Text;
            emp.Nombre = txtnombre.Text;
            emp.Salario = txtsalariohora.Text;
            emp.Horas = txthoras.Text;
            emp.Salariobruto = emp.calculoSalarioBruto(int.Parse(emp.Salario), int.Parse(emp.Horas)).ToString();
            emp.Deducciones = emp.calculoDeducciones(int.Parse(emp.Salariobruto)).ToString();
            emp.Salarioneto = emp.calculoSalarioNeto(int.Parse(emp.Salariobruto), int.Parse(emp.Deducciones)).ToString();

            lblcedula.Text = emp.Cedula;
            lblempleado.Text = emp.Nombre;
            txtsalariobruto.Text = emp.Salariobruto;
            txtdeduccion.Text = emp.Deducciones;
            txtsalarioneto.Text = emp.Salarioneto;
        }
        catch { lblestado.Text = "no debe dejar espacios en blanco"; }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedValue.Trim() == "2"){
            txthoras.Text = "80";
        }else{
            if (DropDownList1.SelectedValue.Trim() == "1")
            {
                txthoras.Text = "";
            }
        }
    }
    protected void btnguardar_Click(object sender, EventArgs e)
    {
        try
        {
            clsempleados emp = new clsempleados("", "", "", "", "", "", "", "");
            emp.Cedula = txtcedula.Text;
            emp.Nombre = txtnombre.Text;
            emp.Tipo = DropDownList1.SelectedValue;
            emp.Salario = txtsalariohora.Text;
            emp.Horas = txthoras.Text;
            emp.agregar();
            lblestado.Text =  "Registro Guardado";
        }
        catch { 
            lblestado.Text = "Registro no Guardado";
        }
    }
}