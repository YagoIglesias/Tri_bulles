using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_10_Tri_a_bulles
{
    public partial class Main : Form
    {
        // const taille tableau
        const int MAX_VALUES = 50;
        //const hauteur max du panel principal
        const int MAX_HEIGTH = 243;
        // const largeur max du panel principal
        const int MAX_WIDTH = 758;
        //const pour le random
        const int MAX_NBR = MAX_HEIGTH;
        // const pour la largeur des panels
        const int WIDTH_PANELS = MAX_WIDTH / (MAX_VALUES * 2);
        // création d'un random
        Random random = new Random();
        // tableau de panels
        Panel[] tabPnl = new Panel[MAX_VALUES];
        // tableau de chiffres (randoms)
        int[] tabRandom = new int[MAX_VALUES];
        // var creation nombres
        int nbr = 0;
        // const position y
        const int POSITION_Y = 0;
        // var position x
        int positionX = 0;
        // instanciation d'une variable stock
        int keepValue = 0;


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnRandomNbr_Click(object sender, EventArgs e)
        {
            // remettre les variables à 0
            nbr = 0;
            random = new Random();
            tabPnl = new Panel[MAX_VALUES];
            positionX = 0;

            //boucle pour créer les chifres
            for (int i = 0; i < MAX_VALUES; i++)
            {
                // creation des chifres
                nbr = random.Next(1,MAX_NBR);

                // inserer les chiffres dans le tableau
                tabRandom[i] = nbr;


                // créer le panel et l'inserer dans le tableau de panels
                tabPnl[i] = new Panel();

                //changement de couleur
                tabPnl[i].BackColor = Color.Green;

                // taille des panels pour le graphique
                tabPnl[i].Size = new Size(WIDTH_PANELS,nbr);

                // position des panels sur l'axe X
                positionX = positionX + 2*WIDTH_PANELS;

                // position du panel
                tabPnl[i].Location = new Point(positionX,POSITION_Y);

                // affichage des panels dans le panel principal
                pnlGraphique.Controls.Add(tabPnl[i]);

                // desactiver le bouton
                btnRandomNbr.Enabled = false;
            }
            
        }

        private void btnBulles_Click(object sender, EventArgs e)
        {
            // activer le bouton
            btnRandomNbr.Enabled = true;

            // boucle pour faire le trie en une fois
            for (int i = 0; i < tabRandom.Length - 1; i++)
            {
                // boucle for pour comparer les chifres et le placer correctement
                for (int j = 0; j < tabRandom.Length - 1; j++)
                {
                    // si le chiffre de droite est plus grand que celui de gauche alors on inverse leur position
                    if (tabRandom[j] > tabRandom[j + 1])
                    {
                        // garder la valeur initial pour ne pas l'ecraser 
                        keepValue = tabRandom[j + 1];

                        // le chiffre de gauche est remplacé par celui de droite
                        tabRandom[j + 1] = tabRandom[j];

                        // remplacer celui de droite par celui de gauche précédemment stocké
                        tabRandom[j] = keepValue;

                        // changer et afficher la taille des panel 
                        tabPnl[j + 1].Size = new Size(WIDTH_PANELS, tabRandom[j + 1]);
                        tabPnl[j].Size = new Size(WIDTH_PANELS, keepValue);

                        // delai de 15 miliscondes pour changer la possition
                        Thread.Sleep(6);

                    }
                }


            }


        }



    }
}
