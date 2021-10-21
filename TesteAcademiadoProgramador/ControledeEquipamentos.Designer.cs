
namespace TesteAcademiadoProgramador
{
    partial class ControledeEquipamentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomedoequipamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_precoequipamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numerodeserie = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fabricante = new System.Windows.Forms.TextBox();
            this.btn_createequipamento = new System.Windows.Forms.Button();
            this.btn_updateequipeamento = new System.Windows.Forms.Button();
            this.btn_readequipamento = new System.Windows.Forms.Button();
            this.btn_deleteequipamento = new System.Windows.Forms.Button();
            this.txt_datafabricacao = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pesquisaequipamento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Equipamento: ";
            // 
            // txt_nomedoequipamento
            // 
            this.txt_nomedoequipamento.Location = new System.Drawing.Point(179, 159);
            this.txt_nomedoequipamento.Name = "txt_nomedoequipamento";
            this.txt_nomedoequipamento.Size = new System.Drawing.Size(100, 23);
            this.txt_nomedoequipamento.TabIndex = 1;
            this.txt_nomedoequipamento.TextChanged += new System.EventHandler(this.txt_nomedoequipamento_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço do Equipamento: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_precoequipamento
            // 
            this.txt_precoequipamento.Location = new System.Drawing.Point(176, 218);
            this.txt_precoequipamento.Name = "txt_precoequipamento";
            this.txt_precoequipamento.Size = new System.Drawing.Size(100, 23);
            this.txt_precoequipamento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de série: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_numerodeserie
            // 
            this.txt_numerodeserie.Location = new System.Drawing.Point(176, 269);
            this.txt_numerodeserie.Name = "txt_numerodeserie";
            this.txt_numerodeserie.Size = new System.Drawing.Size(100, 23);
            this.txt_numerodeserie.TabIndex = 5;
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(36, 330);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(110, 15);
            this.Data.TabIndex = 6;
            this.Data.Text = "Data de Fabricação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fabricante:";
            // 
            // txt_fabricante
            // 
            this.txt_fabricante.Location = new System.Drawing.Point(162, 376);
            this.txt_fabricante.Name = "txt_fabricante";
            this.txt_fabricante.Size = new System.Drawing.Size(100, 23);
            this.txt_fabricante.TabIndex = 9;
            this.txt_fabricante.TextChanged += new System.EventHandler(this.txt_fabricante_TextChanged);
            // 
            // btn_createequipamento
            // 
            this.btn_createequipamento.Location = new System.Drawing.Point(49, 23);
            this.btn_createequipamento.Name = "btn_createequipamento";
            this.btn_createequipamento.Size = new System.Drawing.Size(98, 23);
            this.btn_createequipamento.TabIndex = 10;
            this.btn_createequipamento.Text = "CADASTRAR";
            this.btn_createequipamento.UseVisualStyleBackColor = true;
            this.btn_createequipamento.Click += new System.EventHandler(this.btn_createequipamento_Click);
            // 
            // btn_updateequipeamento
            // 
            this.btn_updateequipeamento.Location = new System.Drawing.Point(260, 23);
            this.btn_updateequipeamento.Name = "btn_updateequipeamento";
            this.btn_updateequipeamento.Size = new System.Drawing.Size(75, 23);
            this.btn_updateequipeamento.TabIndex = 11;
            this.btn_updateequipeamento.Text = "ALTERAR";
            this.btn_updateequipeamento.UseVisualStyleBackColor = true;
            this.btn_updateequipeamento.Click += new System.EventHandler(this.btn_updateequipeamento_Click);
            // 
            // btn_readequipamento
            // 
            this.btn_readequipamento.Location = new System.Drawing.Point(162, 23);
            this.btn_readequipamento.Name = "btn_readequipamento";
            this.btn_readequipamento.Size = new System.Drawing.Size(83, 23);
            this.btn_readequipamento.TabIndex = 12;
            this.btn_readequipamento.Text = "CONSULTAR";
            this.btn_readequipamento.UseVisualStyleBackColor = true;
            this.btn_readequipamento.Click += new System.EventHandler(this.btn_readequipamento_Click);
            // 
            // btn_deleteequipamento
            // 
            this.btn_deleteequipamento.Location = new System.Drawing.Point(352, 22);
            this.btn_deleteequipamento.Name = "btn_deleteequipamento";
            this.btn_deleteequipamento.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteequipamento.TabIndex = 13;
            this.btn_deleteequipamento.Text = "EXCLUIR";
            this.btn_deleteequipamento.UseVisualStyleBackColor = true;
            this.btn_deleteequipamento.Click += new System.EventHandler(this.btn_deleteequipamento_Click);
            // 
            // txt_datafabricacao
            // 
            this.txt_datafabricacao.Location = new System.Drawing.Point(162, 330);
            this.txt_datafabricacao.Mask = "__/__/____";
            this.txt_datafabricacao.Name = "txt_datafabricacao";
            this.txt_datafabricacao.Size = new System.Drawing.Size(100, 23);
            this.txt_datafabricacao.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pesquisar Equipamento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_pesquisaequipamento
            // 
            this.txt_pesquisaequipamento.Location = new System.Drawing.Point(186, 101);
            this.txt_pesquisaequipamento.Name = "txt_pesquisaequipamento";
            this.txt_pesquisaequipamento.Size = new System.Drawing.Size(501, 23);
            this.txt_pesquisaequipamento.TabIndex = 16;
            this.txt_pesquisaequipamento.TextChanged += new System.EventHandler(this.txt_pesquisaequipamento_TextChanged);
            // 
            // ControledeEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_pesquisaequipamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_datafabricacao);
            this.Controls.Add(this.btn_deleteequipamento);
            this.Controls.Add(this.btn_readequipamento);
            this.Controls.Add(this.btn_updateequipeamento);
            this.Controls.Add(this.btn_createequipamento);
            this.Controls.Add(this.txt_fabricante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.txt_numerodeserie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_precoequipamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nomedoequipamento);
            this.Controls.Add(this.label1);
            this.Name = "ControledeEquipamentos";
            this.Text = "ControledeEquipamentos";
            this.Load += new System.EventHandler(this.ControledeEquipamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomedoequipamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_precoequipamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numerodeserie;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fabricante;
        private System.Windows.Forms.Button btn_createequipamento;
        private System.Windows.Forms.Button btn_updateequipeamento;
        private System.Windows.Forms.Button btn_readequipamento;
        private System.Windows.Forms.Button btn_deleteequipamento;
        private System.Windows.Forms.MaskedTextBox txt_datafabricacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pesquisaequipamento;
    }
}