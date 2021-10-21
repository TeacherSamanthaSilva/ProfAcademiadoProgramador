using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TesteAcademiadoProgramador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cONTROLEDEEQUIPAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControledeEquipamentos equipamentos = new ControledeEquipamentos();
            equipamentos.ShowDialog();
        }

        private void cONTROLEDECHAMADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControledeChamados chamados = new ControledeChamados();
            chamados.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
} 
