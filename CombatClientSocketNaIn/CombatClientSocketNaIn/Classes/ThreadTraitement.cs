using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClientSocketNaIn.Classes
{
    class ThreadTraitement
    {
        string laReponseAuServeur { get; set; }

        public ThreadTraitement(string reponse)
        {
            this.laReponseAuServeur = reponse;
        }
    /*    public void traitementAttaque(object data)  voir document: file:///C:/Users/JF/OneDrive%20-%20C%C3%A9gep%20de%20L%C3%A9vis/aut2021/programmation_systeme/semaine6_Thread/Threads-in-CSharp.pdf
        {
            string[] tRecup;
            tRecup = data.ToString().Split(';');

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
        }*/
    }
}
