﻿namespace LocadoraClassic.View
{
    partial class FrmTelaFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaFilme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomefilme = new System.Windows.Forms.TextBox();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.cbBoxCategoria = new System.Windows.Forms.ComboBox();
            this.cbBoxGenero = new System.Windows.Forms.ComboBox();
            this.maskedTxtDuracao = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxLocado = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duração";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gênero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(69, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome do Filme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sinopse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(69, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Locado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(483, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Banner";
            // 
            // txtNomefilme
            // 
            this.txtNomefilme.Location = new System.Drawing.Point(70, 156);
            this.txtNomefilme.Name = "txtNomefilme";
            this.txtNomefilme.Size = new System.Drawing.Size(393, 20);
            this.txtNomefilme.TabIndex = 7;
            this.txtNomefilme.TextChanged += new System.EventHandler(this.txtNomefilme_TextChanged);
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(70, 261);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(393, 90);
            this.txtSinopse.TabIndex = 9;
            this.txtSinopse.TextChanged += new System.EventHandler(this.txtSinopse_TextChanged);
            // 
            // cbBoxCategoria
            // 
            this.cbBoxCategoria.FormattingEnabled = true;
            this.cbBoxCategoria.Location = new System.Drawing.Point(70, 48);
            this.cbBoxCategoria.Name = "cbBoxCategoria";
            this.cbBoxCategoria.Size = new System.Drawing.Size(393, 21);
            this.cbBoxCategoria.TabIndex = 10;
            this.cbBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbBoxCategoria_SelectedIndexChanged);
            // 
            // cbBoxGenero
            // 
            this.cbBoxGenero.FormattingEnabled = true;
            this.cbBoxGenero.Location = new System.Drawing.Point(70, 101);
            this.cbBoxGenero.Name = "cbBoxGenero";
            this.cbBoxGenero.Size = new System.Drawing.Size(393, 21);
            this.cbBoxGenero.TabIndex = 11;
            this.cbBoxGenero.SelectedIndexChanged += new System.EventHandler(this.cbBoxGenero_SelectedIndexChanged);
            // 
            // maskedTxtDuracao
            // 
            this.maskedTxtDuracao.Location = new System.Drawing.Point(70, 209);
            this.maskedTxtDuracao.Mask = "00:00:00";
            this.maskedTxtDuracao.Name = "maskedTxtDuracao";
            this.maskedTxtDuracao.Size = new System.Drawing.Size(393, 20);
            this.maskedTxtDuracao.TabIndex = 12;
            this.maskedTxtDuracao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtDuracao_MaskInputRejected);
            // 
            // checkBoxLocado
            // 
            this.checkBoxLocado.AutoSize = true;
            this.checkBoxLocado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLocado.ForeColor = System.Drawing.Color.White;
            this.checkBoxLocado.Location = new System.Drawing.Point(144, 369);
            this.checkBoxLocado.Name = "checkBoxLocado";
            this.checkBoxLocado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLocado.TabIndex = 13;
            this.checkBoxLocado.UseVisualStyleBackColor = true;
            this.checkBoxLocado.CheckedChanged += new System.EventHandler(this.checkBoxLocado_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(70, 406);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(659, 33);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Location = new System.Drawing.Point(486, 69);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(243, 320);
            this.pictureBoxBanner.TabIndex = 16;
            this.pictureBoxBanner.TabStop = false;
            // 
            // FrmTelaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.checkBoxLocado);
            this.Controls.Add(this.maskedTxtDuracao);
            this.Controls.Add(this.cbBoxGenero);
            this.Controls.Add(this.cbBoxCategoria);
            this.Controls.Add(this.txtSinopse);
            this.Controls.Add(this.txtNomefilme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTelaFilme";
            this.Text = "FrmTelaFilme";
            this.Load += new System.EventHandler(this.FrmTelaFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomefilme;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.ComboBox cbBoxCategoria;
        private System.Windows.Forms.ComboBox cbBoxGenero;
        private System.Windows.Forms.MaskedTextBox maskedTxtDuracao;
        private System.Windows.Forms.CheckBox checkBoxLocado;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
    }
}