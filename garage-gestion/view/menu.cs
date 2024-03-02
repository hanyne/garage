using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garage_gestion.view
{
    public partial class menu : Form
    {
        public void DisconnectUser()
        {
            // Your logic to disable buttons, etc.
            // For example:
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            // ... Disable other buttons

            // Show the login form
            connexion connexion = new connexion(this); // Pass 'this' (menu form) to handle returning to this form after login
            connexion.ShowDialog();
        }


        public menu()
        {
            InitializeComponent();
            panel1.Size = new Size(229, 612);
            pnlparametre.Visible = false;

        }

        // to show subform form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlafficher.Controls.Add(childForm);
            pnlafficher.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //desactiver  formulaire
        void desactiverForm()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncommande.Enabled = false;
            btnfournisseur.Enabled = false;
            copie.Enabled = false;
            restaurercopie.Enabled = false;
            deconnecter.Enabled = false;
            pnlBut.Enabled = false;
            // kan button connecter
            connecter.Enabled = true;
        }
        //active Formulaire
        public void activerForm()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncommande.Enabled = true;
            btnfournisseur.Enabled = true;
            copie.Enabled = true;
            restaurercopie.Enabled = true;
            deconnecter.Enabled = true;
            pnlBut.Enabled = true;
            // connecter msakra
            connecter.Enabled = false;
            pnlparametre.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 229)
            {
                panel1.Size = new Size(82, 612);
            }
            else
            {
                panel1.Size = new Size(229, 612);
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;


            /*if(!pnlafficher.Controls.Contains(User_Liste_Client.Instance))
            {
                pnlafficher.Controls.Add(User_Liste_Client.Instance);   
                User_Liste_Client.Instance.Dock = DockStyle.Fill;
                User_Liste_Client.Instance.BringToFront();
            }else
            {
                User_Liste_Client.Instance.BringToFront(); 
            }*/
        }

        private void btncommande_Click(object sender, EventArgs e)
        {
      
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
       
        }

        private void btnutilisateur_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnparametre_Click(object sender, EventArgs e)
        {
            pnlparametre.Size = new Size(250, 178);
            pnlparametre.Visible = !pnlparametre.Visible;
        }

        private void connecter_Click(object sender, EventArgs e)
        {
            connexion cnx = new connexion(this);// this = menu
            cnx.ShowDialog();
        }

        private void deconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();
            DisconnectUser();
        }

        private void pnlafficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlparametre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void restaurercopie_Click(object sender, EventArgs e)
        {

        }

        private void copie_Click(object sender, EventArgs e)
        {

        }

        private void btncategorie_Click_1(object sender, EventArgs e)
        {

        }

        private void btnproduit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
