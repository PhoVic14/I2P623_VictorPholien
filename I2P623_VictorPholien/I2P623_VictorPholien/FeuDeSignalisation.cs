using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_VictorPholien
{
    class FeuDeSignalisation
    {
        private int _couleur;
        private string _identifiant;
        public FeuDeSignalisation(string identifiant,int couleur)
        {
            _identifiant = identifiant;
            _couleur = couleur;

        }

        public int Couleur
        { 
            get { return _couleur; } 
            set { _couleur = value; } 
        }
        
        public string Identifiant
        { 
            get { return _identifiant; } 
            set { _identifiant = value; } 
        }

        public void Clignote(int etat)
        {
            int i;
            for (etat = 0, i = 0; i < 5; i++)
            {
                Console.WriteLine("Est éteint");
                Console.WriteLine("Est allumé");
            }
        }

        public void Change(int etat, string identifiant)
        {
            int i;
            for (etat = 0, i = 0; i < 5; i++)
            {
                Console.WriteLine("Le feu de signalisation est");
                Console.WriteLine("Le feu de signalisation est");
                Console.WriteLine("Le feu de signalisation est");
            }
        }

        public void AfficheEtat()
        {
            Console.WriteLine("Le feu de signalisation est");
            Console.WriteLine("Le feu de signalisation est");
        }
    }
}
