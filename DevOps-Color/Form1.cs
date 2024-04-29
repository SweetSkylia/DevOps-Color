namespace DevOps_Color
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        
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
            // Cr�ation et affichage des panneaux avec les couleurs al�atoires
            for (int i = 0; i < 5; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(100, 1000); // Taille du panneau
                panel.Location = new Point(50 + i * 120, 50); // Position du panneau
                panel.BackColor = GenerateRandomColor(); // Couleur al�atoire pour le fond du panneau
                this.Controls.Add(panel); // Ajout du panneau au formulaire
            }
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNettoyage_Click(object sender, EventArgs e)
        {
            //Reset
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnEnregisterer_Click(object sender, EventArgs e){
            //Sauvegarde
        }

        private void txtUnchampdetexte_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblLelabel_Click(object sender, EventArgs e)
        {

        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
