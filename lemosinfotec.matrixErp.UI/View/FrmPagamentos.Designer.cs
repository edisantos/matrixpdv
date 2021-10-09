
namespace lemosinfotec.matrixErp.UI.View
{
    partial class FrmPagamentos
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
            this.grpPagamento = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ccmbTipoPag = new System.Windows.Forms.ComboBox();
            this.btnSalvarValorPago = new System.Windows.Forms.Button();
            this.lblGramas = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.grpPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPagamento
            // 
            this.grpPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPagamento.Controls.Add(this.label1);
            this.grpPagamento.Controls.Add(this.ccmbTipoPag);
            this.grpPagamento.Controls.Add(this.btnSalvarValorPago);
            this.grpPagamento.Controls.Add(this.lblGramas);
            this.grpPagamento.Controls.Add(this.txtValorPago);
            this.grpPagamento.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpPagamento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpPagamento.Location = new System.Drawing.Point(26, 26);
            this.grpPagamento.Name = "grpPagamento";
            this.grpPagamento.Size = new System.Drawing.Size(524, 188);
            this.grpPagamento.TabIndex = 1;
            this.grpPagamento.TabStop = false;
            this.grpPagamento.Text = "Entre com o Valor Recebido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // ccmbTipoPag
            // 
            this.ccmbTipoPag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ccmbTipoPag.FormattingEnabled = true;
            this.ccmbTipoPag.Location = new System.Drawing.Point(33, 49);
            this.ccmbTipoPag.Name = "ccmbTipoPag";
            this.ccmbTipoPag.Size = new System.Drawing.Size(459, 38);
            this.ccmbTipoPag.TabIndex = 4;
            // 
            // btnSalvarValorPago
            // 
            this.btnSalvarValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvarValorPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarValorPago.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarValorPago.Location = new System.Drawing.Point(30, 102);
            this.btnSalvarValorPago.Name = "btnSalvarValorPago";
            this.btnSalvarValorPago.Size = new System.Drawing.Size(121, 46);
            this.btnSalvarValorPago.TabIndex = 3;
            this.btnSalvarValorPago.Text = "Enter";
            this.btnSalvarValorPago.UseVisualStyleBackColor = false;
            this.btnSalvarValorPago.Click += new System.EventHandler(this.btnSalvarValorPago_Click);
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
            // txtValorPago
            // 
            this.txtValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorPago.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValorPago.Location = new System.Drawing.Point(157, 108);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(335, 40);
            this.txtValorPago.TabIndex = 0;
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
            this.btnSair.Location = new System.Drawing.Point(571, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.TabIndex = 3;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(612, 262);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpPagamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPagamentos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPagamentos_KeyDown);
            this.grpPagamento.ResumeLayout(false);
            this.grpPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPagamento;
        private System.Windows.Forms.Button btnSalvarValorPago;
        private System.Windows.Forms.Label lblGramas;
        private System.Windows.Forms.TextBox txtValorPago;
        private FontAwesome.Sharp.IconButton btnSair;
        private System.Windows.Forms.ComboBox ccmbTipoPag;
        private System.Windows.Forms.Label label1;
    }
}