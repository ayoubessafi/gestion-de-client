using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestion_de_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RDDFPDH; initial catalog=clients; integrated security=true;");
        DataSet DS = new DataSet();
        SqlDataAdapter DA;

        private void Form1_Load(object sender, EventArgs e)
        {
            DA = new SqlDataAdapter("select * from client", cnx);
            DA.Fill(DS,"clt");
            dataGridView1.DataSource = DS.Tables["clt"];
            for (int i = 0; i < DS.Tables["clt"].Rows.Count; i++)
            {
                ville.Items.Add(DS.Tables["clt"].Rows[i][4]);
                nom.Items.Add(DS.Tables["clt"].Rows[i][2]);
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            DataRow Ligne = DS.Tables["clt"].NewRow();
            Ligne[0] = (int.Parse(DS.Tables["clt"].Rows[DS.Tables["clt"].Rows.Count - 1][0].ToString()) + 1).ToString();
            Ligne[1] = prénom.Text;
            Ligne[2] = nom.Text;
            Ligne[3] = adresse.Text;
            Ligne[4] = ville.Text;
            DS.Tables["clt"].Rows.Add(Ligne);
            cleaner();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            int p = -1;
            for (int i = 0; i < DS.Tables["clt"].Rows.Count; i++)
            {
                if (id.Text == DS.Tables["clt"].Rows[i][0].ToString())
                {
                    p = i;
                }
            }
            if (p == -1) { MessageBox.Show("Client introuvale"); }
            else
            {
                DS.Tables["clt"].Rows[p].Delete();
                MessageBox.Show("client suprimer");
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            int p = -1;
            for (int i = 0; i < DS.Tables["clt"].Rows.Count; i++)
            {
                if (id.Text == DS.Tables["clt"].Rows[i][0].ToString())
                {
                    p = i;
                }
            }
            if (p == -1) { MessageBox.Show("Client introuvale"); }
            else
            {
                DS.Tables["clt"].Rows[p][0] = int.Parse(id.Text);
                DS.Tables["clt"].Rows[p][1] = prénom.Text;
                DS.Tables["clt"].Rows[p][2] = nom.Text;
                DS.Tables["clt"].Rows[p][3] = adresse.Text;
                DS.Tables["clt"].Rows[p][4] = ville.Text;
                MessageBox.Show("client modifier");
            }
        }

        private void enrgistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(DA);
            DA.Update(DS, "clt");
            MessageBox.Show("Les données ont été bien Enregistrées");
        }

        private void rechercher_Click(object sender, EventArgs e)
        {

            /*foreach (DataRow item in DS.Tables["clt"].Rows)
            {
                if (item[4].ToString() == ville.Text)
                {
                    MessageBox.Show("le client est trouvé : \n" + item[1] + "\n" + item[2]);
                    return;
                }
                MessageBox.Show("le client introuvable!");
            }*/

            int p = -1;
            for (int i = 0; i < DS.Tables["clt"].Rows.Count; i++)
            {
                if (ville.Text == DS.Tables["clt"].Rows[i][4].ToString())
                {
                    p = i;
                }
            }
            if (p == -1)
            {
                MessageBox.Show("client not found");
            }
            else
            {

                if (DS.Tables["clt"] != null)
                {
                    DS.Tables["clt"].Clear();
                }
                DA = new SqlDataAdapter("Select  * from client where ville = '" + ville.Text + "'", cnx);
                DA.Fill(DS, "clt");
                dataGridView1.DataSource = DS.Tables["clt"];


            }
        }

        private void cleaner()
        {
            id.Text = null;
            prénom.Text = null;
            nom.Text = null;
            adresse.Text = null;
            ville.Text = null;
        }
    }
}
