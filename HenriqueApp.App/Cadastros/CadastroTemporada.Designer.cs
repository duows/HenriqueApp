namespace HenriqueApp.App.Cadastros
{
    partial class CadastroTemporada
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
            txtAno = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 316);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtAno);
            tabPageCadastro.Size = new Size(786, 281);
            tabPageCadastro.Controls.SetChildIndex(txtAno, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            // 
            // txtAno
            // 
            txtAno.AnimateReadOnly = false;
            txtAno.AutoCompleteMode = AutoCompleteMode.None;
            txtAno.AutoCompleteSource = AutoCompleteSource.None;
            txtAno.BackgroundImageLayout = ImageLayout.None;
            txtAno.CharacterCasing = CharacterCasing.Normal;
            txtAno.Depth = 0;
            txtAno.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAno.HideSelection = true;
            txtAno.Hint = "Ano";
            txtAno.LeadingIcon = null;
            txtAno.Location = new Point(6, 6);
            txtAno.MaxLength = 32767;
            txtAno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAno.Name = "txtAno";
            txtAno.PasswordChar = '\0';
            txtAno.PrefixSuffixText = null;
            txtAno.ReadOnly = false;
            txtAno.RightToLeft = RightToLeft.No;
            txtAno.SelectedText = "";
            txtAno.SelectionLength = 0;
            txtAno.SelectionStart = 0;
            txtAno.ShortcutsEnabled = true;
            txtAno.Size = new Size(718, 48);
            txtAno.TabIndex = 11;
            txtAno.TabStop = false;
            txtAno.TextAlign = HorizontalAlignment.Left;
            txtAno.TrailingIcon = null;
            txtAno.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(730, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(50, 48);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroTemporada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 383);
            Location = new Point(0, 0);
            Name = "CadastroTemporada";
            Text = "CadastroTemporada";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAno;
    }
}