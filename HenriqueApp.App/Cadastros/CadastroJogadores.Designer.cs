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
            txtNomeTime = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            rbtCapitao = new ReaLTaiizor.Controls.MaterialRadioButton();
            txtIdade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNumCamisa = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialRadioButton1 = new ReaLTaiizor.Controls.MaterialRadioButton();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(materialRadioButton1);
            tabPageCadastro.Controls.Add(txtNumCamisa);
            tabPageCadastro.Controls.Add(txtIdade);
            tabPageCadastro.Controls.Add(rbtCapitao);
            tabPageCadastro.Controls.Add(txtNomeTime);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNomeTime, 0);
            tabPageCadastro.Controls.SetChildIndex(rbtCapitao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtIdade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNumCamisa, 0);
            tabPageCadastro.Controls.SetChildIndex(materialRadioButton1, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Size = new Size(786, 348);
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            txtNome.Size = new Size(776, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtNomeTime
            // 
            txtNomeTime.AnimateReadOnly = false;
            txtNomeTime.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeTime.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeTime.BackgroundImageLayout = ImageLayout.None;
            txtNomeTime.CharacterCasing = CharacterCasing.Normal;
            txtNomeTime.Depth = 0;
            txtNomeTime.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeTime.HideSelection = true;
            txtNomeTime.Hint = "Nome do time";
            txtNomeTime.LeadingIcon = null;
            txtNomeTime.Location = new Point(4, 218);
            txtNomeTime.MaxLength = 32767;
            txtNomeTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeTime.Name = "txtNomeTime";
            txtNomeTime.PasswordChar = '\0';
            txtNomeTime.PrefixSuffixText = null;
            txtNomeTime.ReadOnly = false;
            txtNomeTime.RightToLeft = RightToLeft.No;
            txtNomeTime.SelectedText = "";
            txtNomeTime.SelectionLength = 0;
            txtNomeTime.SelectionStart = 0;
            txtNomeTime.ShortcutsEnabled = true;
            txtNomeTime.Size = new Size(776, 48);
            txtNomeTime.TabIndex = 5;
            txtNomeTime.TabStop = false;
            txtNomeTime.TextAlign = HorizontalAlignment.Left;
            txtNomeTime.TrailingIcon = null;
            txtNomeTime.UseSystemPasswordChar = false;
            // 
            // rbtCapitao
            // 
            rbtCapitao.AutoSize = true;
            rbtCapitao.Depth = 0;
            rbtCapitao.Location = new Point(6, 172);
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
            // 
            // txtIdade
            // 
            txtIdade.AnimateReadOnly = false;
            txtIdade.AutoCompleteMode = AutoCompleteMode.None;
            txtIdade.AutoCompleteSource = AutoCompleteSource.None;
            txtIdade.BackgroundImageLayout = ImageLayout.None;
            txtIdade.CharacterCasing = CharacterCasing.Normal;
            txtIdade.Depth = 0;
            txtIdade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            // txtNumCamisa
            // 
            txtNumCamisa.AnimateReadOnly = false;
            txtNumCamisa.AutoCompleteMode = AutoCompleteMode.None;
            txtNumCamisa.AutoCompleteSource = AutoCompleteSource.None;
            txtNumCamisa.BackgroundImageLayout = ImageLayout.None;
            txtNumCamisa.CharacterCasing = CharacterCasing.Normal;
            txtNumCamisa.Depth = 0;
            txtNumCamisa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNumCamisa.HideSelection = true;
            txtNumCamisa.Hint = "Nº da camisa";
            txtNumCamisa.LeadingIcon = null;
            txtNumCamisa.Location = new Point(6, 114);
            txtNumCamisa.MaxLength = 32767;
            txtNumCamisa.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNumCamisa.Name = "txtNumCamisa";
            txtNumCamisa.PasswordChar = '\0';
            txtNumCamisa.PrefixSuffixText = null;
            txtNumCamisa.ReadOnly = false;
            txtNumCamisa.RightToLeft = RightToLeft.No;
            txtNumCamisa.SelectedText = "";
            txtNumCamisa.SelectionLength = 0;
            txtNumCamisa.SelectionStart = 0;
            txtNumCamisa.ShortcutsEnabled = true;
            txtNumCamisa.Size = new Size(773, 48);
            txtNumCamisa.TabIndex = 2;
            txtNumCamisa.TabStop = false;
            txtNumCamisa.TextAlign = HorizontalAlignment.Left;
            txtNumCamisa.TrailingIcon = null;
            txtNumCamisa.UseSystemPasswordChar = false;
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(151, 172);
            materialRadioButton1.Margin = new Padding(0);
            materialRadioButton1.MouseLocation = new Point(-1, -1);
            materialRadioButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialRadioButton1.Name = "materialRadioButton1";
            materialRadioButton1.Ripple = true;
            materialRadioButton1.Size = new Size(94, 37);
            materialRadioButton1.TabIndex = 4;
            materialRadioButton1.TabStop = true;
            materialRadioButton1.Text = "Jogador";
            materialRadioButton1.UseAccentColor = false;
            materialRadioButton1.UseVisualStyleBackColor = true;
            materialRadioButton1.CheckedChanged += materialRadioButton1_CheckedChanged;
            // 
            // CadastroJogadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeTime;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNumCamisa;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIdade;
        private ReaLTaiizor.Controls.MaterialRadioButton materialRadioButton1;
    }
}