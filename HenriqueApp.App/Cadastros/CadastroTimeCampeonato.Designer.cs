namespace HenriqueApp.App.Cadastros
{
    partial class CadastroTimeCampeonato
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
            cboTime = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCampeonato = new ReaLTaiizor.Controls.MaterialComboBox();
            cboTemporada = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboTemporada);
            tabPageCadastro.Controls.Add(cboCampeonato);
            tabPageCadastro.Controls.Add(cboTime);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(cboTime, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCampeonato, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTemporada, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
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
            cboTime.Hint = "Times";
            cboTime.IntegralHeight = false;
            cboTime.ItemHeight = 43;
            cboTime.Location = new Point(6, 6);
            cboTime.MaxDropDownItems = 4;
            cboTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(417, 49);
            cboTime.StartIndex = 0;
            cboTime.TabIndex = 11;
            // 
            // cboCampeonato
            // 
            cboCampeonato.AutoResize = false;
            cboCampeonato.BackColor = Color.FromArgb(255, 255, 255);
            cboCampeonato.Depth = 0;
            cboCampeonato.DrawMode = DrawMode.OwnerDrawVariable;
            cboCampeonato.DropDownHeight = 174;
            cboCampeonato.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampeonato.DropDownWidth = 121;
            cboCampeonato.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCampeonato.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCampeonato.FormattingEnabled = true;
            cboCampeonato.Hint = "Campeonato";
            cboCampeonato.IntegralHeight = false;
            cboCampeonato.ItemHeight = 43;
            cboCampeonato.Location = new Point(6, 61);
            cboCampeonato.MaxDropDownItems = 4;
            cboCampeonato.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCampeonato.Name = "cboCampeonato";
            cboCampeonato.Size = new Size(417, 49);
            cboCampeonato.StartIndex = 0;
            cboCampeonato.TabIndex = 12;
            // 
            // cboTemporada
            // 
            cboTemporada.AutoResize = false;
            cboTemporada.BackColor = Color.FromArgb(255, 255, 255);
            cboTemporada.Depth = 0;
            cboTemporada.DrawMode = DrawMode.OwnerDrawVariable;
            cboTemporada.DropDownHeight = 174;
            cboTemporada.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTemporada.DropDownWidth = 121;
            cboTemporada.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTemporada.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTemporada.FormattingEnabled = true;
            cboTemporada.Hint = "Temporada";
            cboTemporada.IntegralHeight = false;
            cboTemporada.ItemHeight = 43;
            cboTemporada.Location = new Point(6, 116);
            cboTemporada.MaxDropDownItems = 4;
            cboTemporada.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTemporada.Name = "cboTemporada";
            cboTemporada.Size = new Size(417, 49);
            cboTemporada.StartIndex = 0;
            cboTemporada.TabIndex = 13;
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
            txtId.Location = new Point(724, 6);
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
            txtId.Size = new Size(55, 48);
            txtId.TabIndex = 14;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroTimeCampeonato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroTimeCampeonato";
            Text = "CadastroTimeCampeonato";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboTemporada;
        private ReaLTaiizor.Controls.MaterialComboBox cboCampeonato;
        private ReaLTaiizor.Controls.MaterialComboBox cboTime;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}