﻿
namespace SisFin
{
    partial class FrmConta
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
            this.labelNome = new System.Windows.Forms.Label();
            this.gpBoxConta = new System.Windows.Forms.GroupBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.gpBoxConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(8, 19);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 16);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // gpBoxConta
            // 
            this.gpBoxConta.Controls.Add(this.checkBoxStatus);
            this.gpBoxConta.Controls.Add(this.comboBoxCategoria);
            this.gpBoxConta.Controls.Add(this.labelCategoria);
            this.gpBoxConta.Controls.Add(this.txtDescricao);
            this.gpBoxConta.Controls.Add(this.labelDescricao);
            this.gpBoxConta.Controls.Add(this.txtNome);
            this.gpBoxConta.Controls.Add(this.labelNome);
            this.gpBoxConta.Location = new System.Drawing.Point(18, 15);
            this.gpBoxConta.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoxConta.Name = "gpBoxConta";
            this.gpBoxConta.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoxConta.Size = new System.Drawing.Size(531, 204);
            this.gpBoxConta.TabIndex = 1;
            this.gpBoxConta.TabStop = false;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(4, 136);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(76, 16);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoria";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(7, 96);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(515, 22);
            this.txtDescricao.TabIndex = 3;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(8, 77);
            this.labelDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(79, 16);
            this.labelDescricao.TabIndex = 2;
            this.labelDescricao.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 39);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(514, 22);
            this.txtNome.TabIndex = 1;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(7, 155);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(164, 24);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(452, 155);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(70, 20);
            this.checkBoxStatus.TabIndex = 6;
            this.checkBoxStatus.Text = "Status";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 303);
            this.Controls.Add(this.gpBoxConta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConta";
            this.Text = "FrmConta";
            this.gpBoxConta.ResumeLayout(false);
            this.gpBoxConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.GroupBox gpBoxConta;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
    }
}