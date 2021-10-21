
namespace TesteAcademiadoProgramador
{
    partial class ControledeChamados
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
            this.components = new System.ComponentModel.Container();
            this.btn_createchamado = new System.Windows.Forms.Button();
            this.btn_readchamado = new System.Windows.Forms.Button();
            this.btn_updatechamado = new System.Windows.Forms.Button();
            this.btn_deletechamado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigochamado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomeequipamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diaschamadoaberto = new System.Windows.Forms.TextBox();
            this.txt_dataaberturachamado = new System.Windows.Forms.MaskedTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_descricaochamado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pesquisaporcodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_createchamado
            // 
            this.btn_createchamado.Location = new System.Drawing.Point(35, 26);
            this.btn_createchamado.Name = "btn_createchamado";
            this.btn_createchamado.Size = new System.Drawing.Size(99, 23);
            this.btn_createchamado.TabIndex = 0;
            this.btn_createchamado.Text = "CADASTRAR";
            this.btn_createchamado.UseVisualStyleBackColor = true;
            this.btn_createchamado.Click += new System.EventHandler(this.btn_createchamado_Click);
            // 
            // btn_readchamado
            // 
            this.btn_readchamado.Location = new System.Drawing.Point(153, 26);
            this.btn_readchamado.Name = "btn_readchamado";
            this.btn_readchamado.Size = new System.Drawing.Size(88, 23);
            this.btn_readchamado.TabIndex = 1;
            this.btn_readchamado.Text = "CONSULTAR";
            this.btn_readchamado.UseVisualStyleBackColor = true;
            this.btn_readchamado.Click += new System.EventHandler(this.btn_readchamado_Click);
            // 
            // btn_updatechamado
            // 
            this.btn_updatechamado.Location = new System.Drawing.Point(258, 25);
            this.btn_updatechamado.Name = "btn_updatechamado";
            this.btn_updatechamado.Size = new System.Drawing.Size(75, 23);
            this.btn_updatechamado.TabIndex = 2;
            this.btn_updatechamado.Text = "ALTERAR";
            this.btn_updatechamado.UseVisualStyleBackColor = true;
            this.btn_updatechamado.Click += new System.EventHandler(this.btn_updatechamado_Click);
            // 
            // btn_deletechamado
            // 
            this.btn_deletechamado.Location = new System.Drawing.Point(350, 25);
            this.btn_deletechamado.Name = "btn_deletechamado";
            this.btn_deletechamado.Size = new System.Drawing.Size(75, 23);
            this.btn_deletechamado.TabIndex = 3;
            this.btn_deletechamado.Text = "EXCLUIR";
            this.btn_deletechamado.UseVisualStyleBackColor = true;
            this.btn_deletechamado.Click += new System.EventHandler(this.btn_deletechamado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código do chamado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_codigochamado
            // 
            this.txt_codigochamado.Location = new System.Drawing.Point(161, 119);
            this.txt_codigochamado.Name = "txt_codigochamado";
            this.txt_codigochamado.Size = new System.Drawing.Size(100, 23);
            this.txt_codigochamado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do equipamento: ";
            // 
            // txt_nomeequipamento
            // 
            this.txt_nomeequipamento.Location = new System.Drawing.Point(178, 232);
            this.txt_nomeequipamento.Name = "txt_nomeequipamento";
            this.txt_nomeequipamento.Size = new System.Drawing.Size(100, 23);
            this.txt_nomeequipamento.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data de abertura do chamado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Número de dias chamado aberto:";
            // 
            // txt_diaschamadoaberto
            // 
            this.txt_diaschamadoaberto.Location = new System.Drawing.Point(214, 338);
            this.txt_diaschamadoaberto.Name = "txt_diaschamadoaberto";
            this.txt_diaschamadoaberto.Size = new System.Drawing.Size(100, 23);
            this.txt_diaschamadoaberto.TabIndex = 11;
            // 
            // txt_dataaberturachamado
            // 
            this.txt_dataaberturachamado.Location = new System.Drawing.Point(197, 282);
            this.txt_dataaberturachamado.Mask = "__/__/____";
            this.txt_dataaberturachamado.Name = "txt_dataaberturachamado";
            this.txt_dataaberturachamado.Size = new System.Drawing.Size(100, 23);
            this.txt_dataaberturachamado.TabIndex = 12;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descrição Chamado: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_descricaochamado
            // 
            this.txt_descricaochamado.Location = new System.Drawing.Point(178, 178);
            this.txt_descricaochamado.Name = "txt_descricaochamado";
            this.txt_descricaochamado.Size = new System.Drawing.Size(100, 23);
            this.txt_descricaochamado.TabIndex = 14;
            this.txt_descricaochamado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pesquisar por código: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_pesquisaporcodigo
            // 
            this.txt_pesquisaporcodigo.Location = new System.Drawing.Point(165, 84);
            this.txt_pesquisaporcodigo.Name = "txt_pesquisaporcodigo";
            this.txt_pesquisaporcodigo.Size = new System.Drawing.Size(401, 23);
            this.txt_pesquisaporcodigo.TabIndex = 16;
            // 
            // ControledeChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_pesquisaporcodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_descricaochamado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dataaberturachamado);
            this.Controls.Add(this.txt_diaschamadoaberto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nomeequipamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigochamado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deletechamado);
            this.Controls.Add(this.btn_updatechamado);
            this.Controls.Add(this.btn_readchamado);
            this.Controls.Add(this.btn_createchamado);
            this.Name = "ControledeChamados";
            this.Text = "ControledeChamados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createchamado;
        private System.Windows.Forms.Button btn_readchamado;
        private System.Windows.Forms.Button btn_updatechamado;
        private System.Windows.Forms.Button btn_deletechamado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigochamado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomeequipamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_diaschamadoaberto;
        private System.Windows.Forms.MaskedTextBox txt_dataaberturachamado;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_descricaochamado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pesquisaporcodigo;
    }
}