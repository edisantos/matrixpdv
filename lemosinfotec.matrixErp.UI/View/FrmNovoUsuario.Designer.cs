
namespace lemosinfotec.matrixErp.UI.View
{
    partial class FrmNovoUsuario
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.lblUsuarioCadastroheader = new System.Windows.Forms.Label();
            this.iconHeader = new FontAwesome.Sharp.IconPictureBox();
            this.grpFormulario = new System.Windows.Forms.GroupBox();
            this.txtDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistro = new FontAwesome.Sharp.IconButton();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmprea = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.lblSobreNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHeader)).BeginInit();
            this.grpFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlHeader.Controls.Add(this.btnSair);
            this.pnlHeader.Controls.Add(this.lblUsuarioCadastroheader);
            this.pnlHeader.Controls.Add(this.iconHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1128, 59);
            this.pnlHeader.TabIndex = 0;
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
            this.btnSair.Location = new System.Drawing.Point(1067, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.TabIndex = 19;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblUsuarioCadastroheader
            // 
            this.lblUsuarioCadastroheader.AutoSize = true;
            this.lblUsuarioCadastroheader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioCadastroheader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuarioCadastroheader.Location = new System.Drawing.Point(69, 16);
            this.lblUsuarioCadastroheader.Name = "lblUsuarioCadastroheader";
            this.lblUsuarioCadastroheader.Size = new System.Drawing.Size(255, 21);
            this.lblUsuarioCadastroheader.TabIndex = 1;
            this.lblUsuarioCadastroheader.Text = "CADASTRO DE NOVOS USUÀRIOS";
            // 
            // iconHeader
            // 
            this.iconHeader.BackColor = System.Drawing.Color.Transparent;
            this.iconHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconHeader.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconHeader.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHeader.Location = new System.Drawing.Point(22, 12);
            this.iconHeader.Name = "iconHeader";
            this.iconHeader.Size = new System.Drawing.Size(32, 32);
            this.iconHeader.TabIndex = 0;
            this.iconHeader.TabStop = false;
            // 
            // grpFormulario
            // 
            this.grpFormulario.Controls.Add(this.txtDataVencimento);
            this.grpFormulario.Controls.Add(this.btnRegistro);
            this.grpFormulario.Controls.Add(this.lblDataVencimento);
            this.grpFormulario.Controls.Add(this.cmbEmpresa);
            this.grpFormulario.Controls.Add(this.lblEmprea);
            this.grpFormulario.Controls.Add(this.txtUf);
            this.grpFormulario.Controls.Add(this.lblUf);
            this.grpFormulario.Controls.Add(this.txtCidade);
            this.grpFormulario.Controls.Add(this.lblCidade);
            this.grpFormulario.Controls.Add(this.txtNumero);
            this.grpFormulario.Controls.Add(this.lblNumero);
            this.grpFormulario.Controls.Add(this.txtEndereco);
            this.grpFormulario.Controls.Add(this.lblEndereco);
            this.grpFormulario.Controls.Add(this.txtEmail);
            this.grpFormulario.Controls.Add(this.lblEmail);
            this.grpFormulario.Controls.Add(this.txtSobreNome);
            this.grpFormulario.Controls.Add(this.lblSobreNome);
            this.grpFormulario.Controls.Add(this.txtNome);
            this.grpFormulario.Controls.Add(this.lblNome);
            this.grpFormulario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpFormulario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpFormulario.Location = new System.Drawing.Point(12, 87);
            this.grpFormulario.Name = "grpFormulario";
            this.grpFormulario.Size = new System.Drawing.Size(1065, 466);
            this.grpFormulario.TabIndex = 1;
            this.grpFormulario.TabStop = false;
            this.grpFormulario.Text = "Fomulário";
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataVencimento.Location = new System.Drawing.Point(116, 332);
            this.txtDataVencimento.Mask = "00/00/0000";
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(286, 33);
            this.txtDataVencimento.TabIndex = 19;
            this.txtDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnRegistro.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnRegistro.IconColor = System.Drawing.Color.White;
            this.btnRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(116, 387);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(916, 58);
            this.btnRegistro.TabIndex = 18;
            this.btnRegistro.Text = "REGISTRAR";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(14, 337);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(99, 21);
            this.lblDataVencimento.TabIndex = 16;
            this.lblDataVencimento.Text = " Vencimento:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(116, 281);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(904, 33);
            this.cmbEmpresa.TabIndex = 15;
            // 
            // lblEmprea
            // 
            this.lblEmprea.AutoSize = true;
            this.lblEmprea.Location = new System.Drawing.Point(36, 284);
            this.lblEmprea.Name = "lblEmprea";
            this.lblEmprea.Size = new System.Drawing.Size(73, 21);
            this.lblEmprea.TabIndex = 14;
            this.lblEmprea.Text = "Empresa:";
            // 
            // txtUf
            // 
            this.txtUf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUf.Location = new System.Drawing.Point(862, 226);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(158, 33);
            this.txtUf.TabIndex = 13;
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(823, 236);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(32, 21);
            this.lblUf.TabIndex = 12;
            this.lblUf.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(116, 230);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(692, 33);
            this.txtCidade.TabIndex = 11;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(44, 236);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(61, 21);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(862, 173);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(158, 33);
            this.txtNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(823, 184);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(31, 21);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "N°:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndereco.Location = new System.Drawing.Point(116, 175);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(692, 33);
            this.txtEndereco.TabIndex = 7;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(31, 181);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 21);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(116, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(901, 33);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(52, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 21);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSobreNome.Location = new System.Drawing.Point(592, 60);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(425, 33);
            this.txtSobreNome.TabIndex = 3;
            // 
            // lblSobreNome
            // 
            this.lblSobreNome.AutoSize = true;
            this.lblSobreNome.Location = new System.Drawing.Point(489, 67);
            this.lblSobreNome.Name = "lblSobreNome";
            this.lblSobreNome.Size = new System.Drawing.Size(97, 21);
            this.lblSobreNome.TabIndex = 2;
            this.lblSobreNome.Text = "SobreNome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(116, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(358, 33);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(50, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // FrmNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1128, 614);
            this.Controls.Add(this.grpFormulario);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNovoUsuario";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHeader)).EndInit();
            this.grpFormulario.ResumeLayout(false);
            this.grpFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private FontAwesome.Sharp.IconPictureBox iconHeader;
        private System.Windows.Forms.Label lblUsuarioCadastroheader;
        private System.Windows.Forms.GroupBox grpFormulario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.Label lblSobreNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblEmprea;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label lblDataVencimento;
        private FontAwesome.Sharp.IconButton btnRegistro;
        private FontAwesome.Sharp.IconButton btnSair;
        private System.Windows.Forms.MaskedTextBox txtDataVencimento;
    }
}