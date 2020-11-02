using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculator : Form
    {
        double primero;
        double segundo;
        string operador;
        

        public Calculator()
        {
            InitializeComponent();
        }
        
        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsSubstraction obj2 = new Clases.ClsSubstraction();
        Clases.ClsMultiplication obj3 = new Clases.ClsMultiplication();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();
        Clases.ClsExponent obj5 = new Clases.ClsExponent();
        Clases.ClsSqrt obj6 = new Clases.ClsSqrt();
        Clases.ClsMod obj7 = new Clases.ClsMod();
        Clases.ClsPercentage obj8 = new Clases.ClsPercentage();

        private void btnN0_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "9";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSum_Click(object sender, EventArgs e)
        {
        
            primero = Convert.ToDouble(tbxDisplay.Text);
            tbxDisplay.Clear();
            operador = "+";
              

        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            
            primero = Convert.ToDouble(tbxDisplay.Text);
            tbxDisplay.Clear();
            operador = "-";
            

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operador = "X";
            primero = Convert.ToDouble(tbxDisplay.Text);
            tbxDisplay.Clear();
            
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "÷";
            primero = Convert.ToDouble(tbxDisplay.Text);
            tbxDisplay.Clear();
            
        }
        private void button50_Click(object sender, EventArgs e)
        {
            operador = "^";
            primero = Convert.ToDouble(tbxDisplay.Text);
            tbxDisplay.Clear();
        }
        private void Sqrt_Click(object sender, EventArgs e)
        {
            operador = "√";
            primero = Convert.ToDouble(tbxDisplay.Text); //RECUERDA QUE LA RAÍZ ES x^1/x
            tbxDisplay.Clear();
        }
        private void Mod_Click(object sender, EventArgs e)
        {
            operador = "Mod";
            primero = Convert.ToDouble(tbxDisplay.Text); 
            tbxDisplay.Clear();

        }
        private void Percentage_Click(object sender, EventArgs e)
        {
            operador = "%";
            primero = Convert.ToDouble(tbxDisplay.Text); 
            tbxDisplay.Clear();
        }

        private void btnOutcome_Click(object sender, EventArgs e)
        {
            segundo = Convert.ToDouble(tbxDisplay.Text);
            double Sum;
            double Subs;
            double Mult;
            double Div;
            double Exp;
            double sqrt;
            double Mod;
            double Percentage;

            switch(operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    tbxDisplay.Text = Sum.ToString();
                    break;
                case "-":
                    Subs = obj2.Substraction((primero), (segundo));
                    tbxDisplay.Text = Subs.ToString();
                    break;
                case "X":
                    Mult = obj3.Multiplication((primero), (segundo));
                    tbxDisplay.Text = Mult.ToString();
                    break;
                case "÷":
                    Div = obj4.Division((primero), (segundo));
                    tbxDisplay.Text = Div.ToString();
                    break;
                case "^":
                    Exp = obj5.Exponent((primero), (segundo));
                    tbxDisplay.Text = Exp.ToString();
                    break;
                case "√":
                    sqrt = obj6.Sqrt((primero), (segundo));
                    tbxDisplay.Text = sqrt.ToString();
                    break;
                case "Mod":
                    Mod = obj7.Mod((primero), (segundo));
                    tbxDisplay.Text = Mod.ToString();
                    break;
                case "%":
                    Percentage = obj8.Percentage((primero), (segundo));
                    tbxDisplay.Text = Percentage.ToString();
                    break;
               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxDisplay.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbxDisplay.Text.Length == 1)
                tbxDisplay.Text = "";
            else
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 1);
        }
        //
    }
}
    