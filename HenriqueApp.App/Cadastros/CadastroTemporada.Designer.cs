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
            this.txtAno = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(794, 195);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtAno);
            this.tabPageCadastro.Size = new System.Drawing.Size(786, 160);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtAno, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            // 
            // txtAno
            // 
            this.txtAno.AnimateReadOnly = false;
            this.txtAno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAno.Depth = 0;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAno.HideSelection = true;
            this.txtAno.Hint = "Ano";
            this.txtAno.LeadingIcon = null;
            this.txtAno.Location = new System.Drawing.Point(6, 6);
            this.txtAno.MaxLength = 32767;
            this.txtAno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAno.Name = "txtAno";
            this.txtAno.PasswordChar = '\0';
            this.txtAno.PrefixSuffixText = null;
            this.txtAno.ReadOnly = false;
            this.txtAno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAno.SelectedText = "";
            this.txtAno.SelectionLength = 0;
            this.txtAno.SelectionStart = 0;
            this.txtAno.ShortcutsEnabled = true;
            this.txtAno.Size = new System.Drawing.Size(718, 48);
            this.txtAno.TabIndex = 0;
            this.txtAno.TabStop = false;
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAno.TrailingIcon = null;
            this.txtAno.UseSystemPasswordChar = false;
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
            this.txtId.Location = new System.Drawing.Point(730, 6);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = false;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(50, 48);
            this.txtId.TabIndex = 12;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // CadastroTemporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroTemporada";
            this.Text = "CadastroTemporada";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAno;
    }
}