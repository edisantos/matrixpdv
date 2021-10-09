
namespace lemosinfotec.matrixErp.UI.View
{
    partial class FrmRemoverItem
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
            this.grpRemoverItem = new System.Windows.Forms.GroupBox();
            this.btnRemoverItemVenda = new System.Windows.Forms.Button();
            this.lblGramas = new System.Windows.Forms.Label();
            this.txtRemoverItem = new System.Windows.Forms.TextBox();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.grpRemoverItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRemoverItem
            // 
            this.grpRemoverItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRemoverItem.Controls.Add(this.btnRemoverItemVenda);
            this.grpRemoverItem.Controls.Add(this.lblGramas);
            this.grpRemoverItem.Controls.Add(this.txtRemoverItem);
            this.grpRemoverItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpRemoverItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpRemoverItem.Location = new System.Drawing.Point(42, 33);
            this.grpRemoverItem.Name = "grpRemoverItem";
            this.grpRemoverItem.Size = new System.Drawing.Size(524, 125);
            this.grpRemoverItem.TabIndex = 1;
            this.grpRemoverItem.TabStop = false;
            this.grpRemoverItem.Text = "Remover um Item da venda";
            // 
            // btnRemoverItemVenda
            // 
            this.btnRemoverItemVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoverItemVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoverItemVenda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoverItemVenda.Location = new System.Drawing.Point(380, 60);
            this.btnRemoverItemVenda.Name = "btnRemoverItemVenda";
            this.btnRemoverItemVenda.Size = new System.Drawing.Size(121, 40);
            this.btnRemoverItemVenda.TabIndex = 3;
            this.btnRemoverItemVenda.Text = "Remover";
            this.btnRemoverItemVenda.UseVisualStyleBackColor = false;
            this.btnRemoverItemVenda.Click += new System.EventHandler(this.btnRemoverItemVenda_Click);
            // 
            // lblGramas
            // 
            this.lblGramas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGramas.AutoSize = true;
            this.lblGramas.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGramas.Location = new System.Drawing.Point(789, 60);
            this.lblGramas.Name = "lblGramas";
            this.lblGramas.Size = new System.Drawing.Size(36, 37);
            this.lblGramas.TabIndex = 2;
            this.lblGramas.Text = "G";
            // 
            // txtRemoverItem
            // 
            this.txtRemoverItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemoverItem.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRemoverItem.Location = new System.Drawing.Point(26, 60);
            this.txtRemoverItem.Name = "txtRemoverItem";
            this.txtRemoverItem.Size = new System.Drawing.Size(348, 40);
            this.txtRemoverItem.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.AutoSize = true;
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSair.IconColor = System.Drawing.Color.White;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 30;
            this.btnSair.Location = new System.Drawing.Point(570, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.TabIndex = 2;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmRemoverItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(28)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(612, 199);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpRemoverItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRemoverItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRemoverItem";
            this.grpRemoverItem.ResumeLayout(false);
            this.grpRemoverItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRemoverItem;
        private System.Windows.Forms.Button btnRemoverItemVenda;
        private System.Windows.Forms.Label lblGramas;
        private System.Windows.Forms.TextBox txtRemoverItem;
        private FontAwesome.Sharp.IconButton btnSair;
    }
}