
namespace lemosinfotec.matrixErp.UI.View
{
    partial class FrmRoles
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.lblUsuarioCadastroheader = new System.Windows.Forms.Label();
            this.iconHeader = new FontAwesome.Sharp.IconPictureBox();
            this.grpFormularioRoles = new System.Windows.Forms.GroupBox();
            this.lblPermisao = new System.Windows.Forms.Label();
            this.cmbPermissao = new System.Windows.Forms.ComboBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnRegistro = new FontAwesome.Sharp.IconButton();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHeader)).BeginInit();
            this.grpFormularioRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlHeader.Controls.Add(this.iconButton1);
            this.pnlHeader.Controls.Add(this.btnSair);
            this.pnlHeader.Controls.Add(this.lblUsuarioCadastroheader);
            this.pnlHeader.Controls.Add(this.iconHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(885, 59);
            this.pnlHeader.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.AutoSize = true;
            this.iconButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(825, 8);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 36);
            this.iconButton1.TabIndex = 24;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.btnSair.Location = new System.Drawing.Point(1752, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 36);
            this.btnSair.TabIndex = 19;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblUsuarioCadastroheader
            // 
            this.lblUsuarioCadastroheader.AutoSize = true;
            this.lblUsuarioCadastroheader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioCadastroheader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuarioCadastroheader.Location = new System.Drawing.Point(69, 16);
            this.lblUsuarioCadastroheader.Name = "lblUsuarioCadastroheader";
            this.lblUsuarioCadastroheader.Size = new System.Drawing.Size(101, 21);
            this.lblUsuarioCadastroheader.TabIndex = 1;
            this.lblUsuarioCadastroheader.Text = "PERMISSÔES";
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
            // grpFormularioRoles
            // 
            this.grpFormularioRoles.Controls.Add(this.lblPermisao);
            this.grpFormularioRoles.Controls.Add(this.cmbPermissao);
            this.grpFormularioRoles.Controls.Add(this.txtConfirmaSenha);
            this.grpFormularioRoles.Controls.Add(this.lblConfirmaSenha);
            this.grpFormularioRoles.Controls.Add(this.txtSenha);
            this.grpFormularioRoles.Controls.Add(this.btnRegistro);
            this.grpFormularioRoles.Controls.Add(this.cmbUsuarios);
            this.grpFormularioRoles.Controls.Add(this.lblUsuarios);
            this.grpFormularioRoles.Controls.Add(this.txtUserName);
            this.grpFormularioRoles.Controls.Add(this.lblSenha);
            this.grpFormularioRoles.Controls.Add(this.lblUserName);
            this.grpFormularioRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpFormularioRoles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpFormularioRoles.Location = new System.Drawing.Point(32, 74);
            this.grpFormularioRoles.Name = "grpFormularioRoles";
            this.grpFormularioRoles.Size = new System.Drawing.Size(738, 435);
            this.grpFormularioRoles.TabIndex = 2;
            this.grpFormularioRoles.TabStop = false;
            this.grpFormularioRoles.Text = "Permissôes";
            // 
            // lblPermisao
            // 
            this.lblPermisao.AutoSize = true;
            this.lblPermisao.Location = new System.Drawing.Point(74, 273);
            this.lblPermisao.Name = "lblPermisao";
            this.lblPermisao.Size = new System.Drawing.Size(84, 21);
            this.lblPermisao.TabIndex = 23;
            this.lblPermisao.Text = "Permissao:";
            // 
            // cmbPermissao
            // 
            this.cmbPermissao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPermissao.FormattingEnabled = true;
            this.cmbPermissao.Location = new System.Drawing.Point(165, 264);
            this.cmbPermissao.Name = "cmbPermissao";
            this.cmbPermissao.Size = new System.Drawing.Size(434, 33);
            this.cmbPermissao.TabIndex = 22;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmaSenha.Location = new System.Drawing.Point(168, 209);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = '*';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(431, 33);
            this.txtConfirmaSenha.TabIndex = 21;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(37, 219);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(125, 21);
            this.lblConfirmaSenha.TabIndex = 20;
            this.lblConfirmaSenha.Text = "Confirma Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(168, 155);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(431, 33);
            this.txtSenha.TabIndex = 19;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnRegistro.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnRegistro.IconColor = System.Drawing.Color.White;
            this.btnRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(165, 321);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(437, 58);
            this.btnRegistro.TabIndex = 18;
            this.btnRegistro.Text = "REGISTRAR";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(168, 48);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(434, 33);
            this.cmbUsuarios.TabIndex = 15;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(94, 54);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(67, 21);
            this.lblUsuarios.TabIndex = 14;
            this.lblUsuarios.Text = "Usuario:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(168, 104);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(431, 33);
            this.txtUserName.TabIndex = 13;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(106, 167);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 21);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(74, 114);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 21);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "UserName:";
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(885, 567);
            this.Controls.Add(this.grpFormularioRoles);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRoles";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHeader)).EndInit();
            this.grpFormularioRoles.ResumeLayout(false);
            this.grpFormularioRoles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private FontAwesome.Sharp.IconButton btnSair;
        private System.Windows.Forms.Label lblUsuarioCadastroheader;
        private FontAwesome.Sharp.IconPictureBox iconHeader;
        private System.Windows.Forms.GroupBox grpFormularioRoles;
        private FontAwesome.Sharp.IconButton btnRegistro;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.Label lblPermisao;
        private System.Windows.Forms.ComboBox cmbPermissao;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}