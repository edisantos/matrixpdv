
namespace lemosinfotec.matrixErp.UI.View
{
    partial class FrnFinanceiro
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
            this.grpListaFornecedores = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleHeaderFornecedor = new System.Windows.Forms.Label();
            this.grpListaFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListaFornecedores
            // 
            this.grpListaFornecedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.grpListaFornecedores.Controls.Add(this.iconPictureBox1);
            this.grpListaFornecedores.Controls.Add(this.lblTitleHeaderFornecedor);
            this.grpListaFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpListaFornecedores.Location = new System.Drawing.Point(0, 0);
            this.grpListaFornecedores.Name = "grpListaFornecedores";
            this.grpListaFornecedores.Size = new System.Drawing.Size(1489, 63);
            this.grpListaFornecedores.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 51;
            this.iconPictureBox1.Location = new System.Drawing.Point(9, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(51, 51);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblTitleHeaderFornecedor
            // 
            this.lblTitleHeaderFornecedor.AutoSize = true;
            this.lblTitleHeaderFornecedor.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitleHeaderFornecedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleHeaderFornecedor.Location = new System.Drawing.Point(54, 9);
            this.lblTitleHeaderFornecedor.Name = "lblTitleHeaderFornecedor";
            this.lblTitleHeaderFornecedor.Size = new System.Drawing.Size(148, 40);
            this.lblTitleHeaderFornecedor.TabIndex = 0;
            this.lblTitleHeaderFornecedor.Text = "Financeiro";
            // 
            // FrnFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1489, 735);
            this.Controls.Add(this.grpListaFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrnFinanceiro";
            this.Text = "FrnFinanceiro";
            this.grpListaFornecedores.ResumeLayout(false);
            this.grpListaFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel grpListaFornecedores;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblTitleHeaderFornecedor;
    }
}