using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

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
        /// Méthode qui permet d'effacer le contenu et reinitialiser les varialbes
        private void btn_Effacer_Click(object sender, EventArgs e)
        {
            // Defini les valeurs par defaut de chaque variables utilisees
            lbl_Ecran.Text = "0";
            lbl_Operation.Text = "";
            isOperation = false; 
            operation = "";
            nbr1 = 0; nbr2 = 0; result = 0;
        }

        /// Méthode qui permet d'afficher le chiffre 1 dans le label 'lbl_Ecran'
        private void btn_Un_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                lbl_Ecran.Text = "1"; // Affiche le chiffre 1
            }
            else
            {
                if (isOperation) // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "1"; // Affiche le chiffre 1
                    isOperation = false; // Defini la valeur par defaut de la variable
                }
                else
                {
                    lbl_Ecran.Text += "1"; // Concatene le chiffre 1 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'afficher le chiffre 2 dans le label 'lbl_Ecran'
        private void btn_Deux_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                 lbl_Ecran.Text = "2"; // Affiche le chiffre 2
            }
            else
            {
                if (isOperation)  // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "2"; // Affiche le chiffre 2
                    isOperation = false; // Defini la valeur par defaut de la variable
                }
                else
                {
                    lbl_Ecran.Text += "2"; // Concatene le chiffre 2 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'afficher le chiffre 3 dans le label 'lbl_Ecran'
        private void btn_Trois_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                lbl_Ecran.Text = "3"; // Affiche le chiffre 3
            }
            else
            {
                if (isOperation)  // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "3"; // Affiche le chiffre 3
                    isOperation = false; // Defini la valeur par defaut de la variable
                }
                else
                {
                    lbl_Ecran.Text += "3"; // Concatene le chiffre 3 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'afficher le chiffre 4 dans le label 'lbl_Ecran'
        private void btn_Quatre_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                lbl_Ecran.Text = "4"; // Affiche le chiffre 4
            }
            else
            {
                if (isOperation)  // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "4"; // Affiche le chiffre 4
                    isOperation = false; // Defini la valeur par defaut de la variable
                }
                else
                {
                    lbl_Ecran.Text += "4"; // Concatene le chiffre 4 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'afficher le chiffre 5 dans le label 'lbl_Ecran'
        private void btn_Cinq_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                lbl_Ecran.Text = "5"; // Affiche le chiffre 5
            }
            else
            {
                if (isOperation)  // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "5"; // Affiche le chiffre 5
                    isOperation = false; // Defini la valeur par defaut de la variable
                }
                else
                {
                    lbl_Ecran.Text += "5"; // Concatene le chiffre 5 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'afficher le chiffre 6 dans le label 'lbl_Ecran'
        private void btn_Six_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                lbl_Ecran.Text = "6"; // Affiche le chiffre 6
            }
            else
            {
                if (isOperation)  // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "6"; // Affiche le chiffre 6
                    isOperation = false; // Defini la valeur par defaut de la variable
                }
                else
                {
                    lbl_Ecran.Text += "6"; // Concatene le chiffre 6 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'afficher le chiffre 7 dans le label 'lbl_Ecran'
        private void btn_Sept_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                lbl_Ecran.Text = "7"; // Affiche le chiffre 7
            }
            else
            {
                if(isOperation)  // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "7"; // Affiche le chiffre 7
                    isOperation = false; // Defini la valeur par defaut de la variable
                } else
                {
                    lbl_Ecran.Text += "7"; // Concatene le chiffre 7 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'afficher le chiffre 8 dans le label 'lbl_Ecran'
        private void btn_Huit_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                lbl_Ecran.Text = "8"; // Affiche le chiffre 8
            }
            else
            {
                if (isOperation)  // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "8"; // Affiche le chiffre 8
                    isOperation = false; // Defini la valeur par defaut de la variable
                }
                else
                {
                    lbl_Ecran.Text += "8"; // Concatene le chiffre 8 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'afficher le chiffre 9 dans le label 'lbl_Ecran'
        private void btn_Neuf_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                lbl_Ecran.Text = "9"; // Affiche le chiffre 9
            }
            else
            {
                if (isOperation)  // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "9"; // Affiche le chiffre 9
                    isOperation = false; // Defini la valeur par defaut de la variable
                }
                else
                {
                    lbl_Ecran.Text += "9"; // Concatene le chiffre 9 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'afficher le chiffre 0 dans le label 'lbl_Ecran'
        private void btn_Zero_Click(object sender, EventArgs e)
        {
            if(lbl_Ecran.Text == "Impossible de diviser par zero" || lbl_Ecran.Text == "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                lbl_Ecran.ResetText(); lbl_Operation.ResetText(); // Permet de reinitialiser les labels avec les valeurs par defaut
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran
            }
            if (lbl_Ecran.Text == "0" || lbl_Operation.Text.Contains("=")) // Controle la presence du signe egale dans le lablel lbl_Operation et du contenu du label lbl_Ecran
            {
                lbl_Ecran.Text = "0"; // Affiche le chiffre 0
            } else
            {
                if (isOperation)  // Verifie qu'une operation est en cours
                {
                    lbl_Ecran.Text = "0"; // Affiche le chiffre 0
                    isOperation = false; // Defini la valeur par defaut de la variable
                }
                else
                {
                    lbl_Ecran.Text += "0"; // Concatene le chiffre 0 au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'effectuer l'inverse du nombre present dans le label 'lbl_Ecran'
        private void btn_Inverse_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text != "Impossible de diviser par zero" || lbl_Ecran.Text != "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                double value = double.Parse(lbl_Ecran.Text); // Recupere et convertit en double la valeur du texte present dans le label lbl_Ecran
                if (value == 0)
                {
                    lbl_Operation.Text = "1 / (0)"; // Affiche le texte representant l'inverse de 0 dans le label lbl_Operation 
                    lbl_Ecran.Text = "Impossible de diviser par zero"; // Affiche le message d'erreur
                    lbl_Ecran.Font = new Font("Calibri", 13); // Defini la police et la taille du message d'erreur
                }
                else
                {
                    lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du contenu du label lbl_Ecran
                    if (lbl_Operation.Text == "") // Controle si le label lbl_Operation est vide
                    {
                        lbl_Operation.Text = " 1 / (" + value + ")"; // Affiche le texte representant l'inverse de contenu du lable lbl_Ecran dans le label lbl_Operation
                        double r = 1 / value; // Calcul de l'inverse du nombre
                        nbr1 = r; // Affecte le resultat de l'inverse dans la variable nbr1
                        lbl_Ecran.Text = r.ToString(); // Affiche le resultat
                    }
                    else
                    {
                        if (operation != "" && !lbl_Operation.Text.Contains("=")) // Controle s'il y'a une operation en cours et que le label lbl_Operation ne contient pas le signe '='
                        {
                            lbl_Operation.Text += " 1 / (" + value + ")"; // Concatene le texte representant l'inverse du contenu du lable lbl_Ecran au contenu du label lbl_Operation
                            lbl_Ecran.Text = ((1 / value).ToString()); // Affiche le resultat de l'inverse
                        }
                        else if (lbl_Operation.Text.Contains("=")) // Verifie que le label lbl_Operation contient le signe '='
                        {
                            lbl_Operation.Text = " 1 / (" + value + ")"; // Affiche le texte representant l'inverse du contenu du lable lbl_Ecran dans le label lbl_Operation
                            double r = 1 / value; // Calcul de l'inverse du nombre
                            nbr1 = r; // Affecte le resultat de l'inverse dans la variable nbr1
                            lbl_Ecran.Text = r.ToString(); // Affiche le resultat
                        }
                        else
                        {
                            lbl_Operation.Text = " 1 / (" + value + ")"; // Affiche le texte representant l'inverse du contenu du lable lbl_Ecran dans le label lbl_Operation
                            double r = 1 / value; // Calcul de l'inverse du nombre
                            nbr1 = r; // Affecte le resultat de l'inverse dans la variable nbr1
                            lbl_Ecran.Text = r.ToString(); // Affiche le resultat
                        }
                    }
                }
            }
        }

        /// Méthode qui permet de calculer le modulo d'un nombre
        private void btn_Modulo_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text != "Impossible de diviser par zero" || lbl_Ecran.Text != "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                if (lbl_Operation.Text == "") // Controle si le label lbl_Operation est vide
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " % "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe %
                    nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                }
                else
                {
                    if (!lbl_Operation.Text.Contains("=")) // Controle que le signe '=' n'est pas present dans le contenu du label lbl_Operation
                    {
                        if (operation != "") // Controle s'il y'a une operation en cours
                        {
                            nbr2 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr2
                            result = calculate(nbr1, nbr2, operation); // Appel la fonction 'calculate()' pour effectuer l'operation en cours
                            lbl_Operation.Text = " " + result.ToString() + " % "; // Affiche dans le label lbl_Operation le resultat de l'operation concatene au signe %
                            lbl_Ecran.Text = result.ToString(); // Affiche le resultat dans le label lbl_Ecran
                            nbr1 = result; // Affecte le resultat de l'operation a la variable nbr1 pour une eventuelle operation
                        }
                        else
                        {
                            lbl_Operation.Text += " % "; // Concatene le signe '%' au contenu du label lbl_Operation
                            nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                        }
                    }
                    else
                    {
                        lbl_Operation.Text = " " + lbl_Ecran.Text + " % "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe %
                        nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                    }
                }
                isOperation = true; // Affecte a la variable isOperation la valeur true
                operation = "%"; // Affecte a la variable operation le signe '%' comme etant l'operation en cours
            }
        }

        /// Méthode qui permet d'ajouter la virgule (,) dans le label 'lbl_Ecran'
        private void btn_Virgule_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text != "Impossible de diviser par zero" || lbl_Ecran.Text != "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                if(!lbl_Ecran.Text.Contains(",")) // Verifie que le label lbl_Ecran ne contient pas deja le signe ','
                {
                    lbl_Ecran.Text = lbl_Ecran.Text + ','; // Concatene le signe ',' au contenu du label lbl_Ecran
                }
            }
        }

        /// Méthode qui permet d'effectuer la division de deux nombres
        private void btn_Division_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text != "Impossible de diviser par zero" || lbl_Ecran.Text != "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                if (lbl_Operation.Text == "") // Controle si le label lbl_Operation est vide
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " / "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe /
                    nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                }
                else
                {
                    if (!lbl_Operation.Text.Contains("=")) // Controle que le signe '=' n'est pas present dans le contenu du label lbl_Operation
                    {
                        if (operation != "") // Controle s'il y'a une operation en cours
                        {
                            nbr2 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr2
                            result = calculate(nbr1, nbr2, operation); // Appel la fonction 'calculate()' pour effectuer l'operation en cours
                            lbl_Operation.Text = " " + result.ToString() + " / ";  // Affiche dans le label lbl_Operation le resultat de l'operation concatene au signe /
                            lbl_Ecran.Text = result.ToString(); // Affiche le resultat dans le label lbl_Ecran
                            nbr1 = result; // Affecte le resultat de l'operation a la variable nbr1 pour une eventuelle operation
                        }
                        else
                        {
                            lbl_Operation.Text += " / "; // Concatene le signe '/' au contenu du label lbl_Operation
                            nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                        }
                    }
                    else
                    {
                        lbl_Operation.Text = " " + lbl_Ecran.Text + " / "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe /
                        nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                    }

                }
                isOperation = true; // Affecte a la variable isOperation la valeur true
                operation = "/"; // Affecte a la variable operation le signe '/' comme etant l'operation en cours
            }
        }

        /// Méthode qui permet d'effectuer le produit de deux nombres
        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text != "Impossible de diviser par zero" || lbl_Ecran.Text != "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                if (lbl_Operation.Text == "") // Controle si le label lbl_Operation est vide
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " * "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe *
                    nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                }
                else
                {
                    if (!lbl_Operation.Text.Contains("=")) // Controle que le signe '=' n'est pas present dans le contenu du label lbl_Operation
                    {
                        if (operation != "") // Controle s'il y'a une operation en cours
                        {
                            nbr2 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr2
                            result = calculate(nbr1, nbr2, operation); // Appel la fonction 'calculate()' pour effectuer l'operation en cours
                            lbl_Operation.Text = " " + result.ToString() + " * "; // Affiche dans le label lbl_Operation le resultat de l'operation concatene au signe *
                            lbl_Ecran.Text = result.ToString(); // Affiche le resultat dans le label lbl_Ecran
                            nbr1 = result; // Affecte le resultat de l'operation a la variable nbr1 pour une eventuelle operation
                        }
                        else
                        {
                            lbl_Operation.Text += " * "; // Concatene le signe '*' au contenu du label lbl_Operation
                            nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                        }
                    }
                    else
                    {
                        lbl_Operation.Text = " " + lbl_Ecran.Text + " * "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe *
                        nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                    }
                }
                isOperation = true; // Affecte a la variable isOperation la valeur true
                operation = "*"; // Affecte a la variable operation le signe '*' comme etant l'operation en cours
            }
        }

        /// Méthode qui permet d'effectuer la soustraction de deux nombres
        private void btn_Moins_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text != "Impossible de diviser par zero" || lbl_Ecran.Text != "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                if (lbl_Operation.Text == "") // Controle si le label lbl_Operation est vide
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " - "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe -
                    nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                }
                else
                {
                    if (!lbl_Operation.Text.Contains("=")) // Controle que le signe '=' n'est pas present dans le contenu du label lbl_Operation
                    {
                        if (operation != "") // Controle s'il y'a une operation en cours
                        {
                            nbr2 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr2
                            result = calculate(nbr1, nbr2, operation); // Appel la fonction 'calculate()' pour effectuer l'operation en cours
                            lbl_Operation.Text = " " + result.ToString() + " - "; // Affiche dans le label lbl_Operation le resultat de l'operation concatene au signe -
                            lbl_Ecran.Text = result.ToString(); // Affiche le resultat dans le label lbl_Ecran
                            nbr1 = result; // Affecte le resultat de l'operation a la variable nbr1 pour une eventuelle operation
                        }
                        else
                        {
                            lbl_Operation.Text += " - "; // Concatene le signe '-' au contenu du label lbl_Operation
                            nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                        }
                    }
                    else
                    {
                        lbl_Operation.Text = " " + lbl_Ecran.Text + " - "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe -
                        nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                    }
                }
                isOperation = true; // Affecte a la variable isOperation la valeur true
                operation = "-"; // Affecte a la variable operation le signe '-' comme etant l'operation en cours
            }
        }

        /// Méthode qui permet d'effectuer la somme de deux nombres
        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text != "Impossible de diviser par zero" || lbl_Ecran.Text != "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                if (lbl_Operation.Text == "") // Controle si le label lbl_Operation est vide
                {
                    lbl_Operation.Text = " " + lbl_Ecran.Text + " + "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe +
                    nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                }
                else
                {
                    if (!lbl_Operation.Text.Contains("=")) // Controle que le signe '=' n'est pas present dans le contenu du label lbl_Operation
                    {
                        if (operation != "") // Controle s'il y'a une operation en cours
                        {
                            nbr2 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr2
                            result = calculate(nbr1, nbr2, operation); // Appel la fonction 'calculate()' pour effectuer l'operation en cours
                            lbl_Operation.Text = " " + result.ToString() + " + "; // Affiche dans le label lbl_Operation le resultat de l'operation concatene au signe +
                            lbl_Ecran.Text = result.ToString(); // Affiche le resultat dans le label lbl_Ecran
                            nbr1 = result; // Affecte le resultat de l'operation a la variable nbr1 pour une eventuelle operation
                        }
                        else
                        {
                            lbl_Operation.Text += " + "; // Concatene le signe '+' au contenu du label lbl_Operation
                            nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                        }
                    }
                    else
                    {
                        lbl_Operation.Text = " " + lbl_Ecran.Text + " + "; // Affiche dans le label lbl_Operation la valeur du label lbl_Ecran concatene au signe +
                        nbr1 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr1
                    }
                }
                isOperation = true; // Affecte a la variable isOperation la valeur true
                operation = "+"; // Affecte a la variable operation le signe '+' comme etant l'operation en cours
            }
        }

        /// Méthode qui permet d'effectuer les operations arithmetiques de base (Addition, Soustraction, Produit, Division, Modulo) entre deux nombres et retourne le resultat
        private double calculate(double nb1, double nb2, string op)
        { 
            switch (op)
            {
                case "+": return nb1 + nb2; // calcul de la somme
                case "-": return nb1 - nb2; // calcul de la difference
                case "*": return nb1 * nb2; // calcul du produit
                case "/": return nb1 / nb2; // calcul de la division
                case "%": return nb1 % nb2; // calcul du modulo
                default: break;
            }
            return double.NaN; // retourne un double qui n'est pas un nombre dans le cas ou l'operateur n'existe pas
        }

        /// Méthode qui permet de calculer et d'afficher le resultat d'une operation
        private void btn_Egal_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text != "Impossible de diviser par zero" || lbl_Ecran.Text != "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                if (lbl_Operation.Text != "") // Controle si le label lbl_Operation contient une valeur
                {
                    if (operation != "") // Controle s'il y'a une operation en cours
                    {
                        nbr2 = double.Parse(lbl_Ecran.Text); // Convertit le contenu du label lbl_Ecran en double et affecte a la variable nbr2
                        result = calculate(nbr1, nbr2, operation); // Appel la fonction 'calculate()' pour effectuer l'operation en cours
                        lbl_Operation.Text = nbr1.ToString() + " " + operation + " " + nbr2.ToString() + " = "; // Affiche dans le label lbl_Operation l'operation effectuee
                        lbl_Ecran.Text = result.ToString(); // Affiche le resultat dans le label lbl_Ecran
                    }
                }
            }
            else
            {
                lbl_Ecran.Text = "0"; lbl_Operation.ResetText(); // Reinitialise les differents labels
                lbl_Ecran.Font = new Font("Calibri", 20); // Defini la police et la taille du texte du label lbl_Ecran 
            }
        }

        /// Méthode qui permet d'effectuer le calcul du factoriel d'un nombre et retourne le resultat
        private long CalculerFactoriel(long nb)
        {
            if (nb < 0) // Verifie si le nombre entre est negatif
            {
                return -1; // Retourne -1 si le nombre est negatif
            }

            if (nb == 0 || nb == 1) // Verifie si le nombre est egale a '0' ou a '1'
            {
                return 1; // Retourne 1 si le nombre est egale a '0' ou a '1'
            }

            // Calcul du factoriel pour un nombre positif strictement superieur a '1'
            long resultat = 1; // Intitialisation de la variable resultat a 1
            for (int i = 2; i <= nb; i++)
            {
                resultat *= i; // Effectue les produits successifs des entiers a partir de 2 jusqu'au nombre entre afin d'obtenir le factoriel
            }

            return resultat; // Retourne la valeur de la variable resultat sorti de la bouble 'for'
        }

        /// Méthode qui permet de calculer le factoriel d'un nombre
        private void btn_Factoriel_Click(object sender, EventArgs e)
        {
            if (lbl_Ecran.Text != "Impossible de diviser par zero" || lbl_Ecran.Text != "Calcul du factoriel impossible") // Controler que le label lbl_Ecran contient des chaines de caracteres specifiques differents d'un nombre afin d'eviter une exception
            {
                long value = 0; // Creation et initialisation de la variable value
                try
                {
                    value = long.Parse(lbl_Ecran.Text); // Recupere et convertit la valeur contenu dans le label lbl_Ecran en entier et affecte a la variable value
                }
                catch
                {
                    value = (long)double.Parse(lbl_Ecran.Text); // En cas d'exception, du a la presence d'un nombre avec virgule, on convertit en double puis en entier pour recuperer la partie entiere du nombre et on affecte a la variable value 
                }

                long nb = CalculerFactoriel(value); // Appel de la fonction 'CalculerFactoriel()' pour le calcul du factoriel et le resultat est affecte a la variable 'nb'
                if (nb == -1) // Controle si le factoriel a retourner -1
                {
                    lbl_Operation.Text = " fact(" + value + ")"; // Affiche le texte representant le factoriel du contenu du lable lbl_Ecran dans le label lbl_Operation
                    lbl_Ecran.Text = "Calcul du factoriel impossible"; // Affiche le message d'erreur dans le label lbl_Ecran
                    lbl_Ecran.Font = new Font("Calibri", 13); // Modifie la police et la taille du texte du label lbl_Ecran
                }
                else
                {
                    // Le resultat du factoriel est different de -1

                    lbl_Ecran.Font = new Font("Calibri", 20); // Modifie la police et la taille du texte du label lbl_Ecran
                    if (lbl_Operation.Text == "") // Controle si le signe '=' est present dans le label lbl_Operatioin
                    {
                        lbl_Operation.Text = " fact(" + value + ") "; // Affiche le texte representant le factoriel du contenu du lable lbl_Ecran dans le label lbl_Operation
                        nbr1 = nb; // Affecte le resultat du factoriel a la variable nbr1
                        lbl_Ecran.Text = nb.ToString(); // Affiche dans le label lbl_Ecran le resultat du factoriel
                    }
                    else
                    {
                        if (operation != "" && !lbl_Operation.Text.Contains("=")) // Controle que la variable operation est different de vide et que le label lbl_Operation ne contient pas le signe '='
                        {
                            lbl_Operation.Text += " fact(" + value + ") "; // Concatene le texte representant le factoriel du contenu du lable lbl_Ecran au contenu du label lbl_Operation
                            lbl_Ecran.Text = nb.ToString(); // Affiche dans le label lbl_Ecran le resultat du factoriel
                        }
                        else if (lbl_Operation.Text.Contains("=")) // Controle que le label lbl_Operation contient le signe '='
                        {
                            lbl_Operation.Text = " fact(" + value + ") "; // Affiche le texte representant le factoriel du contenu du lable lbl_Ecran dans le label lbl_Operation
                            nbr1 = nb; // Affecte le resultat du factoriel a la variable nbr1
                            lbl_Ecran.Text = nb.ToString(); // Affiche dans le label lbl_Ecran le resultat du factoriel
                        }
                        else
                        {
                            lbl_Operation.Text = " fact(" + value + ") "; // Affiche le texte representant le factoriel du contenu du lable lbl_Ecran dans le label lbl_Operation
                            nbr1 = nb; // Affecte le resultat du factoriel a la variable nbr1
                            lbl_Ecran.Text = nb.ToString(); // Affiche dans le label lbl_Ecran le resultat du factoriel
                        }
                    }
                }
            }
        }
    }
}
