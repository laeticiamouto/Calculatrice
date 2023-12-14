using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class F_Calculatrice : Form
    {
        bool isOperation = false;
        string operation = "";
        double nbr1 = 0;
        double nbr2 = 0;
        double result = 0;
        public F_Calculatrice()
        {
            InitializeComponent();
        }

        private void btn_Effacer_Click(object sender, EventArgs e)
        {
            lbl_Ecran.Text = "0";
            lbl_Operation.Text = "";
            isOperation = false;
            operation = "";
            nbr1 = 0; nbr2 = 0; result = 0;
        }

        private void btn_Un_Click(object sender, EventArgs e)
        {
            if(double.Parse(lbl_Ecran.Text) == 0)
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "1";
                }
                else
                {
                    lbl_Ecran.Text = "1";
                }
            }
            else
            {
                if (isOperation)
                {
                    lbl_Ecran.Text = "1";
                    isOperation = false;
                }
                else
                {
                    lbl_Ecran.Text += "1";
                }
            }
        }

        private void btn_Deux_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_Ecran.Text) == 0)
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "2";
                }
                else
                {
                    lbl_Ecran.Text = "2";
                }
            }
            else
            {
                if (isOperation)
                {
                    lbl_Ecran.Text = "2";
                    isOperation = false;
                }
                else
                {
                    lbl_Ecran.Text += "2";
                }
            }
        }

        private void btn_Trois_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_Ecran.Text) == 0)
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "3";
                }
                else
                {
                    lbl_Ecran.Text = "3";
                }
            }
            else
            {
                if (isOperation)
                {
                    lbl_Ecran.Text = "3";
                    isOperation = false;
                }
                else
                {
                    lbl_Ecran.Text += "3";
                }
            }
        }

        private void btn_Quatre_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_Ecran.Text) == 0)
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "4";
                }
                else
                {
                    lbl_Ecran.Text = "4";
                }
            }
            else
            {
                if (isOperation)
                {
                    lbl_Ecran.Text = "4";
                    isOperation = false;
                }
                else
                {
                    lbl_Ecran.Text += "4";
                }
            }
        }

        private void btn_Cinq_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_Ecran.Text) == 0)
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "5";
                }
                else
                {
                    lbl_Ecran.Text = "5";
                }
            }
            else
            {
                if (isOperation)
                {
                    lbl_Ecran.Text = "5";
                    isOperation = false;
                }
                else
                {
                    lbl_Ecran.Text += "5";
                }
            }
        }

        private void btn_Six_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_Ecran.Text) == 0)
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "6";
                }
                else
                {
                    lbl_Ecran.Text = "6";
                }
            }
            else
            {
                if (isOperation)
                {
                    lbl_Ecran.Text = "6";
                    isOperation = false;
                }
                else
                {
                    lbl_Ecran.Text += "6";
                }
            }
        }

        private void btn_Sept_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_Ecran.Text) == 0)
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "7";
                }
                else
                {
                    lbl_Ecran.Text = "7";
                }
            }
            else
            {
                if(isOperation)
                {
                    lbl_Ecran.Text = "7";
                    isOperation = false;
                } else
                {
                    lbl_Ecran.Text += "7";
                }
            }
        }

        private void btn_Huit_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_Ecran.Text) == 0)
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "8";
                }
                else
                {
                    lbl_Ecran.Text = "8";
                }
            }
            else
            {
                if (isOperation)
                {
                    lbl_Ecran.Text = "8";
                    isOperation = false;
                }
                else
                {
                    lbl_Ecran.Text += "8";
                }
            }
        }

        private void btn_Neuf_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_Ecran.Text) == 0)
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "9";
                } else
                {
                    lbl_Ecran.Text = "9";
                }
            }
            else
            {
                if (isOperation)
                {
                    lbl_Ecran.Text = "9";
                    isOperation = false;
                }
                else
                {
                    lbl_Ecran.Text += "9";
                }
            }
        }

        private void btn_Zero_Click(object sender, EventArgs e)
        {
            if (double.Parse(lbl_Ecran.Text) != 0)
            {
                if (isOperation)
                {
                    lbl_Ecran.Text = "0";
                    isOperation = false;
                }
                else
                {
                    lbl_Ecran.Text += "0";
                }
            } else
            {
                if (lbl_Ecran.Text.Length>=2 && lbl_Ecran.Text.Substring(0,2) == "0,")
                {
                    lbl_Ecran.Text += "0";
                }
                else
                {
                    lbl_Ecran.Text = "0";
                }
            }
        }

        private void btn_Inverse_Click(object sender, EventArgs e)
        {
            double value = double.Parse(lbl_Ecran.Text);
            if(value == 0)
            {
                lbl_Operation.Text = "1 / (0)";
                lbl_Ecran.Text = "Impossible de diviser par zero";
                lbl_Ecran.Font = new Font("Calibri", 13);
            } else 
            {
                lbl_Ecran.Font = new Font("Calibri", 20);
                if (lbl_Operation.Text == "")
                {
                    lbl_Operation.Text = " 1 / (" + value + ")";
                    double r = 1 / value;
                    nbr1 = r;
                    lbl_Ecran.Text = r.ToString();
                } else
                {
                    if (operation != "" && !lbl_Operation.Text.Contains("="))
                    {
                        lbl_Operation.Text += " 1 / (" + value + ")";
                        lbl_Ecran.Text = ((1 / value).ToString());
                    } else if (lbl_Operation.Text.Contains("="))
                    {
                        lbl_Operation.Text = " 1 / (" + value + ")";
                        double r = 1 / value;
                        nbr1 = r;
                        lbl_Ecran.Text = r.ToString();
                    }
                }
            }
        }

        private void btn_Modulo_Click(object sender, EventArgs e)
        {
            if (lbl_Operation.Text == "")
            {
                lbl_Operation.Text = " " + lbl_Ecran.Text + " % ";
                nbr1 = double.Parse(lbl_Ecran.Text);
            }
            else
            {
                if (!lbl_Operation.Text.Contains("="))
                {
                    if (operation != "")
                    {
                        nbr2 = double.Parse(lbl_Ecran.Text);
                        result = calculate(nbr1, nbr2, operation);
                        lbl_Operation.Text = " " + result.ToString() + " % ";
                        lbl_Ecran.Text = result.ToString();
                        nbr1 = result;
                    }
                    else
                    {
                        lbl_Operation.Text += " % ";
                        nbr1 = double.Parse(lbl_Ecran.Text);
                    }
                }
                else
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " % ";
                    nbr1 = double.Parse(lbl_Ecran.Text);
                }
            }
            isOperation = true;
            operation = "%";
        }

        private void btn_Virgule_Click(object sender, EventArgs e)
        {
            lbl_Ecran.Text = lbl_Ecran.Text + ',';
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            if (lbl_Operation.Text == "")
            {
                lbl_Operation.Text = " " + lbl_Ecran.Text + " / ";
                nbr1 = double.Parse(lbl_Ecran.Text);
            }
            else
            {
                if (!lbl_Operation.Text.Contains("="))
                {
                    if (operation != "")
                    {
                        nbr2 = double.Parse(lbl_Ecran.Text);
                        result = calculate(nbr1, nbr2, operation);
                        lbl_Operation.Text = " " + result.ToString() + " / ";
                        lbl_Ecran.Text = result.ToString();
                        nbr1 = result;
                    }
                    else
                    {
                        lbl_Operation.Text += " / ";
                        nbr1 = double.Parse(lbl_Ecran.Text);
                    }
                }
                else
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " / ";
                    nbr1 = double.Parse(lbl_Ecran.Text);
                }

            }
            isOperation = true;
            operation = "/";
        }

        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
            if (lbl_Operation.Text == "")
            {
                lbl_Operation.Text = " " + lbl_Ecran.Text + " * ";
                nbr1 = double.Parse(lbl_Ecran.Text);
            }
            else
            {
                if (!lbl_Operation.Text.Contains("="))
                {
                    if (operation != "")
                    {
                        nbr2 = double.Parse(lbl_Ecran.Text);
                        result = calculate(nbr1, nbr2, operation);
                        lbl_Operation.Text = " " + result.ToString() + " * ";
                        lbl_Ecran.Text = result.ToString();
                        nbr1 = result;
                    }
                    else
                    {
                        lbl_Operation.Text += " * ";
                        nbr1 = double.Parse(lbl_Ecran.Text);
                    }
                }
                else
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " * ";
                    nbr1 = double.Parse(lbl_Ecran.Text);
                }
            }
            isOperation = true;
            operation = "*";
        }

        private void btn_Moins_Click(object sender, EventArgs e)
        {
            if (lbl_Operation.Text == "")
            {
                lbl_Operation.Text = " " + lbl_Ecran.Text + " - ";
                nbr1 = double.Parse(lbl_Ecran.Text);
            }
            else
            {
                if (!lbl_Operation.Text.Contains("="))
                {
                    if (operation != "")
                    {
                        nbr2 = double.Parse(lbl_Ecran.Text);
                        result = calculate(nbr1, nbr2, operation);
                        lbl_Operation.Text = " " + result.ToString() + " - ";
                        lbl_Ecran.Text = result.ToString();
                        nbr1 = result;
                    }
                    else
                    {
                        lbl_Operation.Text += " - ";
                        nbr1 = double.Parse(lbl_Ecran.Text);
                    }
                } else
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " - ";
                    nbr1 = double.Parse(lbl_Ecran.Text);
                }              
            }
            isOperation = true;
            operation = "-";
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if(lbl_Operation.Text == "")
            {
                lbl_Operation.Text = " " + lbl_Ecran.Text + " + ";
                nbr1 = double.Parse(lbl_Ecran.Text);
            } else
            {
                if (!lbl_Operation.Text.Contains("="))
                {
                    if (operation != "")
                    {
                        nbr2 = double.Parse(lbl_Ecran.Text);
                        result = calculate(nbr1, nbr2, operation);
                        lbl_Operation.Text = " " + result.ToString() + " + ";
                        lbl_Ecran.Text = result.ToString();
                        nbr1 = result;
                    }
                    else
                    {
                        lbl_Operation.Text += " + ";
                        nbr1 = double.Parse(lbl_Ecran.Text);
                    }
                }
                else
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " + ";
                    nbr1 = double.Parse(lbl_Ecran.Text);
                }
            }
            isOperation = true;
            operation = "+";
        }

        private double calculate(double nb1, double nb2, string op)
        { 
            switch (op)
            {
                case "+": return nb1 + nb2;
                case "-": return nb1 - nb2;
                case "*": return nb1 * nb2;
                case "/": return nb1 / nb2;
                case "%": return nb1 % nb2;
                default: break;
            }
            return double.NaN;
        }

        private void btn_Egal_Click(object sender, EventArgs e)
        {
            if(lbl_Operation.Text != "")
            {
                if (operation != "")
                {
                    nbr2 = double.Parse(lbl_Ecran.Text);
                    result = calculate(nbr1, nbr2, operation);
                    lbl_Operation.Text = nbr1.ToString() + " " + operation + " " + nbr2.ToString() + " = ";
                    lbl_Ecran.Text = result.ToString();
                }
            }
        }

        private int CalculerFactoriel(int nb)
        {
            if (nb < 0)
            {
                return -1;
            }

            if (nb == 0 || nb == 1)
            {
                return 1;
            }

            int resultat = 1;
            for (int i = 2; i <= nb; i++)
            {
                resultat *= i;
            }

            return resultat;
        }

        private void btn_Factoriel_Click(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = int.Parse(lbl_Ecran.Text);
            } catch
            {
                value = (int) double.Parse(lbl_Ecran.Text);
            }
            
            int nb = CalculerFactoriel(value);
            if (nb == -1)
            {
                lbl_Operation.Text = " fact(" + value + ")";
                lbl_Ecran.Text = "Calcul du factoriel impossible";
                lbl_Ecran.Font = new Font("Calibri", 13);
            }
            else
            {
                lbl_Ecran.Font = new Font("Calibri", 20);
                if (lbl_Operation.Text == "")
                {
                    lbl_Operation.Text = " fact(" + value + ") ";
                    nbr1 = nb;
                    lbl_Ecran.Text = nb.ToString();
                }
                else
                {
                    if (operation != "" && !lbl_Operation.Text.Contains("="))
                    {
                        lbl_Operation.Text += " fact(" + value + ") ";
                        lbl_Ecran.Text = nb.ToString();
                    } else if (lbl_Operation.Text.Contains("="))
                    {
                        lbl_Operation.Text = " fact(" + value + ") ";
                        nbr1 = nb;
                        lbl_Ecran.Text = nb.ToString();
                    }
                }
            }
        }
    }
}
