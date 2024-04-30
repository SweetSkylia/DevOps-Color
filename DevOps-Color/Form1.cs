namespace DevOps_Color
{
    public partial class Form4 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Form4()
        {
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();

            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();

            GenerateRandomPanels();

            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();
            GenerateRandomPanels();

            GenerateRandomPanels();

            InitializeComponent();
        }

        private Color GenerateRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            
            Refresh();
        }

        private void btnEnregisterer_Click(object sender, EventArgs e)
        {
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

        private void btnFermer_MouseEnter(object sender, EventArgs e)
        {
            btnFermer.BackColor = Color.Red;
        }

        private void btnFermer_MouseLeave(object sender, EventArgs e)
        {
            btnFermer.BackColor = Color.Transparent;
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {
            //
        }
        private void GenerateRandomPanels()
        {
            Controls.Clear();
            for (int i = 0; i < 5; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(100, 100); // Taille du panneau
                panel.Location = new Point(50 + i * 120, 50); // Position du panneau
                panel.BackColor = GenerateRandomColor(); // Couleur al�atoire pour le fond du panneau
                this.Controls.Add(panel); // Ajout du panneau au formulaire
            }
            InitializeComponent();
        }
    }
}
