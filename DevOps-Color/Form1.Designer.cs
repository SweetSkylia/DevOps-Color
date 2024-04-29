namespace DevOps_Color
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                //salut c'est moi
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGenerer = new Button();
            btnEnregistrer = new Button();
            btnFermer = new Button();
            pnlTop = new Panel();
            lblTitre = new Label();
            pnlCenter = new Panel();
            pnlTop.SuspendLayout();
            pnlCenter.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerer
            // 
            btnGenerer.BackColor = Color.CornflowerBlue;
            btnGenerer.FlatAppearance.BorderSize = 0;
            btnGenerer.FlatStyle = FlatStyle.Flat;
            btnGenerer.Location = new Point(21, 538);
            btnGenerer.Name = "btnGenerer";
            btnGenerer.Size = new Size(94, 29);
            btnGenerer.TabIndex = 0;
            btnGenerer.Text = "Générer";
            btnGenerer.UseVisualStyleBackColor = false;
            btnGenerer.Click += btnGenerer_Click;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.CornflowerBlue;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Location = new Point(136, 538);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(94, 29);
            btnEnregistrer.TabIndex = 1;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // btnFermer
            // 
            btnFermer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFermer.BackColor = Color.Transparent;
            btnFermer.FlatAppearance.BorderSize = 0;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Image = (Image)resources.GetObject("btnFermer.Image");
            btnFermer.Location = new Point(1027, 0);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(50, 50);
            btnFermer.TabIndex = 2;
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnQuitter_Click;
            btnFermer.MouseEnter += btnFermer_MouseEnter;
            btnFermer.MouseLeave += btnFermer_MouseLeave;
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = Color.CornflowerBlue;
            pnlTop.Controls.Add(lblTitre);
            pnlTop.Controls.Add(btnFermer);
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1077, 50);
            pnlTop.TabIndex = 3;
            pnlTop.MouseDown += pnlTop_MouseDown;
            pnlTop.MouseMove += pnlTop_MouseMove;
            pnlTop.MouseUp += pnlTop_MouseUp;
            // 
            // lblTitre
            // 
            lblTitre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 11F);
            lblTitre.Location = new Point(3, 11);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(328, 25);
            lblTitre.TabIndex = 3;
            lblTitre.Text = "Générateur de couleur (original wow)";
            lblTitre.TextAlign = ContentAlignment.MiddleLeft;
            lblTitre.Click += lblTitre_Click;
            lblTitre.MouseDown += pnlTop_MouseDown;
            lblTitre.MouseMove += pnlTop_MouseMove;
            lblTitre.MouseUp += pnlTop_MouseUp;
            // 
            // pnlCenter
            // 
            pnlCenter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCenter.BackColor = Color.White;
            pnlCenter.Controls.Add(btnGenerer);
            pnlCenter.Controls.Add(btnEnregistrer);
            pnlCenter.Location = new Point(0, 50);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(1077, 593);
            pnlCenter.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1077, 643);
            Controls.Add(pnlCenter);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlCenter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerer;
        private Button btnEnregistrer;
        private Button btnFermer;
        private Panel pnlTop;
        private Panel pnlCenter;
        private Label lblTitre;
    }
}
