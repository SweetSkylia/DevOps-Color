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
