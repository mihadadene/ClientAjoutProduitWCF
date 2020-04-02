using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAjoutProduitWCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            if (tbNom.Text == "" || tbPrix.Text == "" || tbPrix.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs ");
            }
            else
            {
                               
                ServiceReference.ConsommerProduitWebServiceClient client = new ServiceReference.ConsommerProduitWebServiceClient();
                ServiceReference.produit pr = new ServiceReference.produit();


                
                pr.nomProd= tbNom.Text;
                pr.qtyProd = Convert.ToInt32( tbQty.Text);
                pr.prixProd =Convert.ToDouble( tbPrix.Text);

                if (client.inscrireProduit(pr)) 
                {
                    MessageBox.Show("Votre produit a été ajouté avec succè");
                }
                else
                {
                    MessageBox.Show("Votre demande n'a pu etre ajouté");
                }
            }
        }
        }
    }

