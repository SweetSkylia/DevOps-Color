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
            btnGenerer = new Button();
            btnEnregistrer = new Button();
            SuspendLayout();
            // 
            // btnGenerer
            // 
            btnGenerer.Location = new Point(32, 29);
            btnGenerer.Name = "btnGenerer";
            btnGenerer.Size = new Size(94, 29);
            btnGenerer.TabIndex = 0;
            btnGenerer.Text = "Générer";
            btnGenerer.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Location = new Point(132, 29);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(94, 29);
            btnEnregistrer.TabIndex = 1;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnregistrer);
            Controls.Add(btnGenerer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerer;
        private Button btnEnregistrer;
    }
}
