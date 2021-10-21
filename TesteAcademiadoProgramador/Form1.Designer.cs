
namespace TesteAcademiadoProgramador
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTROLEDEEQUIPAMENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTROLEDECHAMADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPÇÕESToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPÇÕESToolStripMenuItem
            // 
            this.oPÇÕESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONTROLEDEEQUIPAMENTOSToolStripMenuItem,
            this.cONTROLEDECHAMADOSToolStripMenuItem});
            this.oPÇÕESToolStripMenuItem.Name = "oPÇÕESToolStripMenuItem";
            this.oPÇÕESToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.oPÇÕESToolStripMenuItem.Text = "OPÇÕES";
            // 
            // cONTROLEDEEQUIPAMENTOSToolStripMenuItem
            // 
            this.cONTROLEDEEQUIPAMENTOSToolStripMenuItem.Name = "cONTROLEDEEQUIPAMENTOSToolStripMenuItem";
            this.cONTROLEDEEQUIPAMENTOSToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cONTROLEDEEQUIPAMENTOSToolStripMenuItem.Text = "CONTROLE DE EQUIPAMENTOS";
            this.cONTROLEDEEQUIPAMENTOSToolStripMenuItem.Click += new System.EventHandler(this.cONTROLEDEEQUIPAMENTOSToolStripMenuItem_Click);
            // 
            // cONTROLEDECHAMADOSToolStripMenuItem
            // 
            this.cONTROLEDECHAMADOSToolStripMenuItem.Name = "cONTROLEDECHAMADOSToolStripMenuItem";
            this.cONTROLEDECHAMADOSToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cONTROLEDECHAMADOSToolStripMenuItem.Text = "CONTROLE DE CHAMADOS";
            this.cONTROLEDECHAMADOSToolStripMenuItem.Click += new System.EventHandler(this.cONTROLEDECHAMADOSToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTROLEDEEQUIPAMENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTROLEDECHAMADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
    }
}