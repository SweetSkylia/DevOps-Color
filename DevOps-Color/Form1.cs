namespace DevOps_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Color GenerateRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Création et affichage des panneaux avec les couleurs aléatoires
            for (int i = 0; i < 5; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(100, 1000); // Taille du panneau
                panel.Location = new Point(50 + i * 120, 50); // Position du panneau
                panel.BackColor = GenerateRandomColor(); // Couleur aléatoire pour le fond du panneau
                this.Controls.Add(panel); // Ajout du panneau au formulaire
            }
        }
    }
}
