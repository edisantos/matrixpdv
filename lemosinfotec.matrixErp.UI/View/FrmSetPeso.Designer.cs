
namespace lemosinfotec.matrixErp.UI.View
{
    partial class FrmSetPeso
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
            this.grpPeso = new System.Windows.Forms.GroupBox();
            this.btnAddPeso = new System.Windows.Forms.Button();
            this.lblGramas = new System.Windows.Forms.Label();
            this.lblVendasId = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.grpPeso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPeso
            // 
            this.grpPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPeso.Controls.Add(this.btnAddPeso);
            this.grpPeso.Controls.Add(this.lblGramas);
            this.grpPeso.Controls.Add(this.lblVendasId);
            this.grpPeso.Controls.Add(this.txtPeso);
            this.grpPeso.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpPeso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpPeso.Location = new System.Drawing.Point(36, 34);
            this.grpPeso.Name = "grpPeso";
            this.grpPeso.Size = new System.Drawing.Size(524, 125);
            this.grpPeso.TabIndex = 0;
            this.grpPeso.TabStop = false;
            this.grpPeso.Text = "Entre com o peso em grama. Ex: 1Kg = 1000g";
            // 
            // btnAddPeso
            // 
            this.btnAddPeso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddPeso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPeso.Location = new System.Drawing.Point(29, 62);
            this.btnAddPeso.Name = "btnAddPeso";
            this.btnAddPeso.Size = new System.Drawing.Size(121, 38);
            this.btnAddPeso.TabIndex = 3;
            this.btnAddPeso.Text = "Add";
            this.btnAddPeso.UseVisualStyleBackColor = false;
            this.btnAddPeso.Click += new System.EventHandler(this.btnAddPeso_Click);
            // 
            // lblGramas
            // 
            this.lblGramas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGramas.AutoSize = true;
            this.lblGramas.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGramas.Location = new System.Drawing.Point(465, 60);
            this.lblGramas.Name = "lblGramas";
            this.lblGramas.Size = new System.Drawing.Size(36, 37);
            this.lblGramas.TabIndex = 2;
            this.lblGramas.Text = "G";
            // 
            // lblVendasId
            // 
            this.lblVendasId.AutoSize = true;
            this.lblVendasId.Location = new System.Drawing.Point(29, 28);
            this.lblVendasId.Name = "lblVendasId";
            this.lblVendasId.Size = new System.Drawing.Size(72, 30);
            this.lblVendasId.TabIndex = 1;
            this.lblVendasId.Text = "label1";
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeso.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPeso.Location = new System.Drawing.Point(156, 60);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(303, 40);
            this.txtPeso.TabIndex = 0;
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
            this.btnSair.Location = new System.Drawing.Point(571, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.TabIndex = 3;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmSetPeso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(612, 199);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpPeso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmSetPeso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSetPeso";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSetPeso_KeyDown_1);
            this.grpPeso.ResumeLayout(false);
            this.grpPeso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblVendasId;
        private System.Windows.Forms.Label lblGramas;
        private System.Windows.Forms.Button btnAddPeso;
        private FontAwesome.Sharp.IconButton btnSair;
    }
}