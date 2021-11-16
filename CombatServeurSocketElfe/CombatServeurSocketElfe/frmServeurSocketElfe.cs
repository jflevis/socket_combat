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
using CombatServeurSocketElfe.Classes;

namespace CombatServeurSocketElfe
{
    public partial class frmServeurSocketElfe : Form
    {
        Random m_r;
        Nain m_nain;
        Elfe m_elfe;
        TcpListener m_ServerListener;
        Socket m_client;
        Thread m_thCombat;
        List<Socket> lstSocket;

        public frmServeurSocketElfe()
        {
            InitializeComponent();
            m_r = new Random();

            Reset(); // crée un nain et un Elfe vide
            btnReset.Enabled = false;
            //Démarre un serveur de socket (TcpListener)

            lstReception.Items.Add("Serveur démarré !");
            lstReception.Items.Add("PRESSER : << attendre un client >>");
            lstReception.Update();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnAttente_Click(object sender, EventArgs e)
        {
            // Combat par un thread
            /* Déclaration d'un client */
            Socket m_client = null;
            byte[] tByteReception = new byte[50];
            ASCIIEncoding textByte = new ASCIIEncoding();
            byte[] tByteEnvoie;
            bool receptionClientBool;
            string reponseDuServeurAuClient = "";
            string receptionClient = "";
            string reponseServeur = "";
            int nbrOctetReceptionClient = 0;
            string[] tRecup;

            try
            {
                // ThreadStart m_treadstart = new ThreadStart(Combat);
                //hread m_tread = new Thread(m_treadstart);
                //m_tread.Start(0);
                //Thread.Sleep(500);
                Combat();
            }
            catch (Exception ex)
            {
                lstReception.Items.Add("Server not not ready! CATCH exception");
                lstReception.Items.Add(ex.Message);
                lstReception.Update();
            }
        }
        public void Combat()
        {
            // déclarations de variables locales 
            string reponseServeur = "";
            string receptionClient = "";
            int nbOctetReception;
            int vie = 0, force = 0, noArme = 0;
            string arme = "";
            byte[] tByteReception = new byte[50];
            byte[] tByteEnvoie = new byte[50];
            ASCIIEncoding textByte = new ASCIIEncoding();
            string[] tRecup;

            /* traitement de la réception,  préparation de la transmission, transmission */
            //byte[] en string
            try
            {
                // tous le code de traitement
                while (m_nain.Vie > 0 && m_elfe.Vie > 0)
                {
                    //initialisation d'un client (bloquant) 
                    
               
                    
                    m_ServerListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 7025);
                    m_ServerListener.Start();

                    lstSocket = new List<Socket>();
                    lstSocket.Add(m_client);

                    m_client = m_ServerListener.AcceptSocket();
                    lstReception.Items.Add("Client branché !");
                    lstReception.Update();
                    nbOctetReception = m_client.Receive(tByteReception);
                    receptionClient = Encoding.ASCII.GetString(tByteReception);
                    reponseServeur = "Message du client: " + receptionClient;
                    lstReception.Items.Add(reponseServeur);
                    lstReception.Update();
                    tRecup = receptionClient.Split(';');// recuperation de la demande de connection et des données du données (vie,force,arme)
                                                        // receptionClientBool = tRecup[0].StartsWith("Frappe");// la phrase utilisée pour se connecter au serveur
                    vie = Convert.ToInt32(tRecup[0]);
                    force = Convert.ToInt32(tRecup[1]);
                    arme = tRecup[2];
                    m_nain.Vie = vie;
                    m_nain.Force = force;
                    m_nain.Arme = arme;
                    // appeler la methode m_nain.Frapper pour attaquer l'elfe
                    m_nain.Frapper(m_elfe);

                    AfficheStatElfe();
                    // appeler la méthode m_elfe.LancerSort pour attaquer le nain
                    m_elfe.LancerSort(m_nain);
                    AfficheStatNain();
                    // envoyer la réponse au client
                    reponseServeur = m_nain.Vie.ToString() + ";" + m_nain.Force.ToString() + ";" + m_elfe.Vie + ";" + m_elfe.Force.ToString() + ";" + m_elfe.Sort.ToString() + ";";
                    lstReception.Items.Add(reponseServeur);
                    lstReception.Update();
                    tByteEnvoie = textByte.GetBytes(reponseServeur);
                    m_client.Send(tByteEnvoie);
                    Thread.Sleep(500);

                }
                if (m_nain.Vie == 0 && m_elfe.Vie > 0)
                {
                    MessageBox.Show("le gagnant est l'elfe");
                }
                else if (m_elfe.Vie == 0 && m_nain.Vie > 0)
                {
                    MessageBox.Show("le gagnant est le nain");
                    picElfe.Image = m_nain.Avatar;
                }
                else if (m_elfe.Vie == 0 && m_nain.Vie == 0)
                {
                    MessageBox.Show("Il y a égalité, les deux sont morts en même temps");
                }
                m_client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
        private void btnFermer_Click(object sender, EventArgs e)
        {
            // il faut avoir un objet elfe et un objet nain instanciés
            //m_elfe.Vie = 0;
            //m_nain.Vie = 0;
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
        private void frmServeurSocketElfe_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnFermer_Click(sender, e);
            try
            {
                // il faut avoir un objet TCPListener existant
                m_ServerListener.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
        void AfficheStatNain()
        {
            lblVieNain.Text = "Vie du nain: " + m_nain.Vie.ToString();
            lblForceNain.Text = "Force du nain: " + m_nain.Force.ToString();
            lblArmeNain.Text = "L'arme du nain est: " + m_nain.Arme;
            MessageBox.Show("Serveur:Frapper l'elfe");
            this.Update(); // pour s'assurer de l'affichage via le thread  pour rafraichir tout le formulaire
        }
        void AfficheStatElfe()
        {
            // mettre a jour les données de l'elfe
            lblVieElfe.Text = "Vie de l'elfe: " + m_elfe.Vie.ToString();
            lblForceElfe.Text = "Force de l'elfe: " + m_elfe.Force.ToString();
            lblSortElfe.Text = "Sort de l'elfe: " + m_elfe.Sort.ToString();
            // execute frapper
            MessageBox.Show("Serveur: Lancer un sort au nain");
            this.Update(); // pour s'assurer de l'affichage via le thread
        }
        void Reset()
        {
            m_nain = new Nain(1, 0, 0);
            picNain.Image = m_nain.Avatar;
            AfficheStatNain();
            m_elfe = new Elfe(m_r.Next(10, 20), m_r.Next(2, 6), m_r.Next(2, 6));
            picElfe.Image = m_elfe.Avatar;
            AfficheStatElfe();
            lstReception.Items.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
