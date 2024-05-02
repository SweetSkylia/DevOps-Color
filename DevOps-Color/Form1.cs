namespace DevOps_Color
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Color[] listeCouleurs = new Color[5];
        public Form1()
        {
            GenerateRandomPanels();
            InitializeComponent();
        }

        private Color GenerateRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        public void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnGenerer_Click(object sender, EventArgs e)
        {
            GenerateRandomPanels();
            Refresh();
        }

        public void btnEnregisterer_Click(object sender, EventArgs e)
        {
            //Sauvegarde
        }

        public void txtUnchampdetexte_TextChanged(object sender, EventArgs e)
        {

        }

        public void lblLelabel_Click(object sender, EventArgs e)
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

        public void btnFermer_MouseEnter(object sender, EventArgs e)
        {
            btnFermer.BackColor = Color.Red;
        }

        public void btnFermer_MouseLeave(object sender, EventArgs e)
        {
            btnFermer.BackColor = Color.Transparent;
        }

        public void lblTitre_Click(object sender, EventArgs e)
        {
            //
        }
        private void GenerateRandomPanels()
        {
            Color color;
            foreach (Control control in Controls)
            {
                control.Dispose();
            }
            Controls.Clear();
            for (int i = 0; i < 5; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(100, 100); // Taille du panneau
                panel.Location = new Point(50 + i * 120, 50); // Position du panneau
                color = GenerateRandomColor();
                listeCouleurs[i] = color;
                panel.BackColor = color; // Couleur al�atoire pour le fond du panneau
                this.Controls.Add(panel); // Ajout du panneau au formulaire
            }
            InitializeComponent();
        }

        public void btnEnregistrer_Click(object sender, EventArgs e)
        {
            JsonWriter enregistrement = new JsonWriter();
            enregistrement.WriteToJsonFile(listeCouleurs);
            MessageBox.Show("Fichier exporté.");
        }

        public void btnImporter_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Sélectionnez un fichier JSON à importer";
            openFileDialog.Filter = "Fichier JSON (.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                JsonReader lecture = new JsonReader();
                listeCouleurs = lecture.ReadJsonFromFile(filePath);

                foreach (Color couleur in listeCouleurs)
                {
                    MessageBox.Show(couleur.Name);
                }

            }
        }

    }
}
