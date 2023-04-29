namespace picture_ranker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.initializeFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb1.Location = new System.Drawing.Point(35, 79);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(800, 800);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoad,
            this.btnSave,
            this.initializeFolderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1706, 48);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnLoad
            // 
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 36);
            this.btnLoad.Text = "Load New";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 36);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb2.Location = new System.Drawing.Point(866, 79);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(800, 800);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // initializeFolderToolStripMenuItem
            // 
            this.initializeFolderToolStripMenuItem.Name = "initializeFolderToolStripMenuItem";
            this.initializeFolderToolStripMenuItem.Size = new System.Drawing.Size(196, 44);
            this.initializeFolderToolStripMenuItem.Text = "Initialize Folder";
            this.initializeFolderToolStripMenuItem.Click += new System.EventHandler(this.initializeFolderToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1706, 911);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Picture Ranker";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnLoad;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.ToolStripMenuItem initializeFolderToolStripMenuItem;
    }
}

