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

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            //
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
    }
}
