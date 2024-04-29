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
            pnlCenter = new Panel();
            pnlTop.SuspendLayout();
            pnlCenter.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerer
            // 
            btnGenerer.Location = new Point(12, 336);
            btnGenerer.Name = "btnGenerer";
            btnGenerer.Size = new Size(94, 29);
            btnGenerer.TabIndex = 0;
            btnGenerer.Text = "Générer";
            btnGenerer.UseVisualStyleBackColor = true;
            btnGenerer.Click += btnGenerer_Click;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Location = new Point(127, 336);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(94, 29);
            btnEnregistrer.TabIndex = 1;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Transparent;
            btnFermer.FlatAppearance.BorderSize = 0;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Image = (Image)resources.GetObject("btnFermer.Image");
            btnFermer.Location = new Point(750, 0);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(50, 50);
            btnFermer.TabIndex = 2;
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnQuitter_Click;
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = Color.LightBlue;
            pnlTop.Controls.Add(btnFermer);
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 50);
            pnlTop.TabIndex = 3;
            pnlTop.MouseDown += pnlTop_MouseDown;
            pnlTop.MouseMove += pnlTop_MouseMove;
            pnlTop.MouseUp += pnlTop_MouseUp;
            // 
            // pnlCenter
            // 
            pnlCenter.Controls.Add(btnGenerer);
            pnlCenter.Controls.Add(btnEnregistrer);
            pnlCenter.Location = new Point(0, 50);
            pnlCenter.Name = "pnlCenter";
            pnlCenter.Size = new Size(800, 400);
            pnlCenter.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCenter);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            pnlTop.ResumeLayout(false);
            pnlCenter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerer;
        private Button btnEnregistrer;
        private Button btnFermer;
        private Panel pnlTop;
        private Panel pnlCenter;
    }
}
