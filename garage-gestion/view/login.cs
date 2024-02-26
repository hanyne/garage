using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace garage_gestion.view
{
    public partial class login : Form
    {
        private dbGarage db;
        private Form frmenu;
        classe.Cls_connexion C = new classe.Cls_connexion();
        public login(menu menu)
        {
            InitializeComponent();
            this.frmenu = Menu;
            //Initialiser base de donné
            db = new dbGarage();
        }

        string testobligatoire()
        {
            if (textNom.Text == "" || textNom.Text == "Nom d'utilisateur")
            {
                return "Enter votre Nom ";
            }
            if (textMdp.Text == "" || textMdp.Text == "Mot de passe")
            {
                return "Enter votre Mot de passe";
            }
            return null;

        }
        private void textNom_Enter(object sender, EventArgs e)
        {
            if (textNom.Text == "Nom d'utilisateur")
            {
                textNom.Text = "";
                textNom.ForeColor = Color.Silver;
            }
        }

        private void textMdp_Enter(object sender, EventArgs e)
        {
            if (textMdp.Text == "Mot de passe")
            {
                textMdp.Text = "";
                textMdp.UseSystemPasswordChar = false;
                textMdp.PasswordChar = '*';
                textMdp.ForeColor = Color.Silver;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testobligatoire() == null)
            {
                if (C.ConnexionValide(db, textNom.Text, textMdp.Text))
                {
                    MessageBox.Show("connexion a réussi", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmenu as menu).activerForm();
                    this.Close();//quitter formulaire connexion baad login 
                }
                else //n'existe pas 
                {
                    MessageBox.Show("connexion a échoué", "connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textNom_Leave(object sender, EventArgs e)
        {
            if (textNom.Text == "")
            {
                textNom.Text = "Nom d'utilisateur";
                textNom.ForeColor = Color.Silver;
            }
        }

        private void textMdp_Leave(object sender, EventArgs e)
        {
            if (textMdp.Text == "")
            {
                textMdp.Text = "Mot de passe";
                textMdp.UseSystemPasswordChar = true; // deactiver passwordchar
                textMdp.ForeColor = Color.Silver;
            }
        }
    }
}
