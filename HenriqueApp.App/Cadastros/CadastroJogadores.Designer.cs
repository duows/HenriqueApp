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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            rbtCapitao = new ReaLTaiizor.Controls.MaterialRadioButton();
            txtIdade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            rbtJogador = new ReaLTaiizor.Controls.MaterialRadioButton();
            cboTime = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 297);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboTime);
            tabPageCadastro.Controls.Add(rbtJogador);
            tabPageCadastro.Controls.Add(txtIdade);
            tabPageCadastro.Controls.Add(rbtCapitao);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new Size(786, 262);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(rbtCapitao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtIdade, 0);
            tabPageCadastro.Controls.SetChildIndex(rbtJogador, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTime, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(3, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(709, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // rbtCapitao
            // 
            rbtCapitao.AutoSize = true;
            rbtCapitao.Depth = 0;
            rbtCapitao.Location = new Point(6, 111);
            rbtCapitao.Margin = new Padding(0);
            rbtCapitao.MouseLocation = new Point(-1, -1);
            rbtCapitao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbtCapitao.Name = "rbtCapitao";
            rbtCapitao.Ripple = true;
            rbtCapitao.Size = new Size(90, 37);
            rbtCapitao.TabIndex = 3;
            rbtCapitao.TabStop = true;
            rbtCapitao.Text = "Capitão";
            rbtCapitao.UseAccentColor = false;
            rbtCapitao.UseVisualStyleBackColor = true;
            rbtCapitao.CheckedChanged += materialRadioButton_CheckedChanged;
            // 
            // txtIdade
            // 
            txtIdade.AnimateReadOnly = false;
            txtIdade.AutoCompleteMode = AutoCompleteMode.None;
            txtIdade.AutoCompleteSource = AutoCompleteSource.None;
            txtIdade.BackgroundImageLayout = ImageLayout.None;
            txtIdade.CharacterCasing = CharacterCasing.Normal;
            txtIdade.Depth = 0;
            txtIdade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdade.HideSelection = true;
            txtIdade.Hint = "Idade";
            txtIdade.LeadingIcon = null;
            txtIdade.Location = new Point(6, 60);
            txtIdade.MaxLength = 32767;
            txtIdade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIdade.Name = "txtIdade";
            txtIdade.PasswordChar = '\0';
            txtIdade.PrefixSuffixText = null;
            txtIdade.ReadOnly = false;
            txtIdade.RightToLeft = RightToLeft.No;
            txtIdade.SelectedText = "";
            txtIdade.SelectionLength = 0;
            txtIdade.SelectionStart = 0;
            txtIdade.ShortcutsEnabled = true;
            txtIdade.Size = new Size(773, 48);
            txtIdade.TabIndex = 1;
            txtIdade.TabStop = false;
            txtIdade.TextAlign = HorizontalAlignment.Left;
            txtIdade.TrailingIcon = null;
            txtIdade.UseSystemPasswordChar = false;
            // 
            // rbtJogador
            // 
            rbtJogador.AutoSize = true;
            rbtJogador.Depth = 0;
            rbtJogador.Location = new Point(145, 111);
            rbtJogador.Margin = new Padding(0);
            rbtJogador.MouseLocation = new Point(-1, -1);
            rbtJogador.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbtJogador.Name = "rbtJogador";
            rbtJogador.Ripple = true;
            rbtJogador.Size = new Size(94, 37);
            rbtJogador.TabIndex = 4;
            rbtJogador.TabStop = true;
            rbtJogador.Text = "Jogador";
            rbtJogador.UseAccentColor = false;
            rbtJogador.UseVisualStyleBackColor = true;
            rbtJogador.CheckedChanged += materialRadioButton_CheckedChanged;
            // 
            // cboTime
            // 
            cboTime.AutoResize = false;
            cboTime.BackColor = Color.FromArgb(255, 255, 255);
            cboTime.Depth = 0;
            cboTime.DrawMode = DrawMode.OwnerDrawVariable;
            cboTime.DropDownHeight = 174;
            cboTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTime.DropDownWidth = 121;
            cboTime.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTime.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTime.FormattingEnabled = true;
            cboTime.Hint = "Time";
            cboTime.IntegralHeight = false;
            cboTime.ItemHeight = 43;
            cboTime.Location = new Point(3, 151);
            cboTime.MaxDropDownItems = 4;
            cboTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(773, 49);
            cboTime.StartIndex = 0;
            cboTime.TabIndex = 11;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(718, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(58, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroJogadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 364);
            Location = new Point(0, 0);
            Name = "CadastroJogadores";
            Text = "CadastroJogadores";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
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