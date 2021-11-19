using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CombatClientSocketNaIn.Classes;


namespace CombatClientSocketNaIn
{
    public partial class frmClienSocketNain : Form
    {
        Random m_r;
        Elfe m_elfe;
        Nain m_nain;
        public frmClienSocketNain()
        {
            InitializeComponent();
            m_r = new Random();
            btnReset.Enabled = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            btnFrappe.Enabled = true;
            btnReset.Enabled = true;
            MessageBox.Show("Cliquez sur RESET avant d'attaquer la première fois");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            btnFrappe.Enabled = true;
            Reset();
        }
        private void btnFrappe_Click(object sender, EventArgs e)
        {
            /* déclaration de variables */
            string envoie = m_nain.Vie.ToString() + ";" + m_nain.Force.ToString() + ";" + m_nain.Arme+";";
            string reponse = "aucune";
            int nbrOctetReception;
            byte[] tByteReception = new byte[50];
            ASCIIEncoding textByte = new ASCIIEncoding();
            byte[] tByteEnvoie = textByte.GetBytes(envoie);
            try
            {
                // initialisation et connection du socket au serveur TCP
                Socket m_client = null;
                m_client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                m_client.Connect(IPAddress.Parse("127.0.0.1"), 7025);
                //MessageBox.Show("assurez-vous que le serveur est en attente d'un client");
                // vérification que la connection à fonctionné et traitement de transmission/réception
                if (m_client.Connected)
                {
                    lstReception.Items.Add("Transmet " + envoie + " au serveur");
                    lstReception.Update();
                    // transmission
                    m_client.Send(tByteEnvoie);
                    Thread.Sleep(500);
                    // reception
                    nbrOctetReception = m_client.Receive(tByteReception); // reception parametre reference sera remplit par le receive n<est pas utile dans le contexte
                    reponse = Encoding.ASCII.GetString(tByteReception);
                    lstReception.Items.Add("Attaque de l'elfe: "+ reponse);
                    lstReception.Update();
                   // Thread m_thread = new Thread(traitementAttaque);
                    //m_thread.Start(reponse);
                    traitementAttaque(reponse); // met à jour le nain et l'elfe
                }
                // fermeture du socket
                m_client.Close();
                lstReception.Items.Add(Environment.NewLine + "Assurez-vous que le serveur est connecté");
                lstReception.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void traitementAttaque(string attaque)
        {
            string[] tRecup;
            tRecup = attaque.Split(';');
            int vieNain = Convert.ToInt32(tRecup[0]);
            int forceNain = Convert.ToInt32(tRecup[1]);
            int vieElfe = Convert.ToInt32(tRecup[2]);
            int forceElfe = Convert.ToInt32(tRecup[3]);
            int sortElfe = Convert.ToInt32(tRecup[4]);
            m_nain.Vie = vieNain;
            m_nain.Force = forceNain;
            m_elfe.Vie = vieElfe;
            m_elfe.Force = forceElfe;
            m_elfe.Sort = sortElfe;
            AfficheNain();
            AfficheElfe();
            if (m_nain.Vie == 0 && m_elfe.Vie > 0)
            {
                //MessageBox.Show("le gagnant est l'elfe");
                picNain.Image = m_elfe.Avatar;
                lstReception.Items.Add("le gagnant est l'elfe!");
                lstReception.Update();
                txtGagnant.Text = "le gagnant est l'elfe!";
                txtGagnant.Update();
            }
            else if (m_elfe.Vie == 0 && m_nain.Vie > 0)
            {
                picElfe.Image = m_nain.Avatar;
                //MessageBox.Show("le gagnant est le nain");
                lstReception.Items.Add("le gagnant est le nain!");
                lstReception.Update();
                txtGagnant.Text = "le gagnant est le nain!";
                txtGagnant.Update();
            }
            else if (m_elfe.Vie == 0 && m_nain.Vie == 0)
            {
               // MessageBox.Show("Il y a égalité, les deux sont morts en même temps");
                lstReception.Items.Add("Il y a égalité, les deux sont morts en même temps!");
                lstReception.Update();
                txtGagnant.Text = "Il y a égalité, les deux sont morts en même temps!";
                txtGagnant.Update();
            }
        }
        public void AfficheNain()
        {
            lblVieNain.Text = "Vies du nain " + m_nain.Vie;
            lblForceNain.Text = "Forces du nain " + m_nain.Force;
            lblArmeNain.Text = "son arme est: " + m_nain.Arme;
        }
        public void AfficheElfe()
        {
            lblVieElfe.Text = "Vies de l'elfe: " + m_elfe.Vie;
            lblForceElfe.Text = "Forces de l'elfe: " + m_elfe.Force;
            lblSortElfe.Text = "Sorts de l'elfe: " + m_elfe.Sort;
        }
        void Reset()
        {
            m_nain = new Nain(m_r.Next(10, 20), m_r.Next(2, 6), m_r.Next(0, 3));
            picNain.Image = m_nain.Avatar;
            lblVieNain.Text = "Vie: " + m_nain.Vie.ToString(); ;
            lblForceNain.Text = "Force: " + m_nain.Force.ToString();
            lblArmeNain.Text = "Arme: " + m_nain.Arme;
            m_elfe = new Elfe(1, 0, 0);
            picElfe.Image = m_elfe.Avatar;
            lblVieElfe.Text = "Vie: " + m_elfe.Vie.ToString();
            lblForceElfe.Text = "Force: " + m_elfe.Force.ToString();
            lblSortElfe.Text = "Sort: " + m_elfe.Sort.ToString();
            lstReception.Items.Clear();
            txtGagnant.Text = "";
            txtGagnant.Update();
        }
    }
}
