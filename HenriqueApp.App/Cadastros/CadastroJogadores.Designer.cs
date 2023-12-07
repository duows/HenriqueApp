namespace HenriqueApp.App.Cadastros
{
    partial class CadastroJogadores
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
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.rbtCapitao = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.txtIdade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.rbtJogador = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.cboTime = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(794, 297);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.cboTime);
            this.tabPageCadastro.Controls.Add(this.rbtJogador);
            this.tabPageCadastro.Controls.Add(this.txtIdade);
            this.tabPageCadastro.Controls.Add(this.rbtCapitao);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Size = new System.Drawing.Size(786, 262);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.rbtCapitao, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtIdade, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.rbtJogador, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboTime, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(3, 6);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(709, 48);
            this.txtNome.TabIndex = 0;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // rbtCapitao
            // 
            this.rbtCapitao.AutoSize = true;
            this.rbtCapitao.Depth = 0;
            this.rbtCapitao.Location = new System.Drawing.Point(6, 111);
            this.rbtCapitao.Margin = new System.Windows.Forms.Padding(0);
            this.rbtCapitao.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtCapitao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.rbtCapitao.Name = "rbtCapitao";
            this.rbtCapitao.Ripple = true;
            this.rbtCapitao.Size = new System.Drawing.Size(90, 37);
            this.rbtCapitao.TabIndex = 2;
            this.rbtCapitao.TabStop = true;
            this.rbtCapitao.Text = "Capitão";
            this.rbtCapitao.UseAccentColor = false;
            this.rbtCapitao.UseVisualStyleBackColor = true;
            // 
            // txtIdade
            // 
            this.txtIdade.AnimateReadOnly = false;
            this.txtIdade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdade.Depth = 0;
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdade.HideSelection = true;
            this.txtIdade.Hint = "Idade";
            this.txtIdade.LeadingIcon = null;
            this.txtIdade.Location = new System.Drawing.Point(6, 60);
            this.txtIdade.MaxLength = 32767;
            this.txtIdade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.PasswordChar = '\0';
            this.txtIdade.PrefixSuffixText = null;
            this.txtIdade.ReadOnly = false;
            this.txtIdade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdade.SelectedText = "";
            this.txtIdade.SelectionLength = 0;
            this.txtIdade.SelectionStart = 0;
            this.txtIdade.ShortcutsEnabled = true;
            this.txtIdade.Size = new System.Drawing.Size(773, 48);
            this.txtIdade.TabIndex = 1;
            this.txtIdade.TabStop = false;
            this.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdade.TrailingIcon = null;
            this.txtIdade.UseSystemPasswordChar = false;
            // 
            // rbtJogador
            // 
            this.rbtJogador.AutoSize = true;
            this.rbtJogador.Depth = 0;
            this.rbtJogador.Location = new System.Drawing.Point(145, 111);
            this.rbtJogador.Margin = new System.Windows.Forms.Padding(0);
            this.rbtJogador.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtJogador.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.rbtJogador.Name = "rbtJogador";
            this.rbtJogador.Ripple = true;
            this.rbtJogador.Size = new System.Drawing.Size(94, 37);
            this.rbtJogador.TabIndex = 3;
            this.rbtJogador.TabStop = true;
            this.rbtJogador.Text = "Jogador";
            this.rbtJogador.UseAccentColor = false;
            this.rbtJogador.UseVisualStyleBackColor = true;
            // 
            // cboTime
            // 
            this.cboTime.AutoResize = false;
            this.cboTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTime.Depth = 0;
            this.cboTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTime.DropDownHeight = 174;
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.DropDownWidth = 121;
            this.cboTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Hint = "Time";
            this.cboTime.IntegralHeight = false;
            this.cboTime.ItemHeight = 43;
            this.cboTime.Location = new System.Drawing.Point(3, 151);
            this.cboTime.MaxDropDownItems = 4;
            this.cboTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(773, 49);
            this.cboTime.StartIndex = 0;
            this.cboTime.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "ID";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(718, 6);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(58, 48);
            this.txtId.TabIndex = 12;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // CadastroJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroJogadores";
            this.Text = "Cadastro de Jogadores";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialRadioButton rbtCapitao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIdade;
        private ReaLTaiizor.Controls.MaterialRadioButton rbtJogador;
        private ReaLTaiizor.Controls.MaterialComboBox cboTime;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}