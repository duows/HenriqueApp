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
            cboCamp = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboTemp = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(499, 283);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboTemp);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboCamp);
            tabPageCadastro.Controls.Add(cboTime);
            tabPageCadastro.Size = new Size(491, 248);
            tabPageCadastro.Controls.SetChildIndex(cboTime, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCamp, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTemp, 0);
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
            // cboCamp
            // 
            cboCamp.AutoResize = false;
            cboCamp.BackColor = Color.FromArgb(255, 255, 255);
            cboCamp.Depth = 0;
            cboCamp.DrawMode = DrawMode.OwnerDrawVariable;
            cboCamp.DropDownHeight = 174;
            cboCamp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCamp.DropDownWidth = 121;
            cboCamp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCamp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCamp.FormattingEnabled = true;
            cboCamp.Hint = "Campeonato";
            cboCamp.IntegralHeight = false;
            cboCamp.ItemHeight = 43;
            cboCamp.Location = new Point(6, 61);
            cboCamp.MaxDropDownItems = 4;
            cboCamp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCamp.Name = "cboCamp";
            cboCamp.Size = new Size(417, 49);
            cboCamp.StartIndex = 0;
            cboCamp.TabIndex = 12;
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
            txtId.Location = new Point(429, 6);
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
            // cboTemp
            // 
            cboTemp.AutoResize = false;
            cboTemp.BackColor = Color.FromArgb(255, 255, 255);
            cboTemp.Depth = 0;
            cboTemp.DrawMode = DrawMode.OwnerDrawVariable;
            cboTemp.DropDownHeight = 174;
            cboTemp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTemp.DropDownWidth = 121;
            cboTemp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTemp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTemp.FormattingEnabled = true;
            cboTemp.Hint = "Temporada";
            cboTemp.IntegralHeight = false;
            cboTemp.ItemHeight = 43;
            cboTemp.Location = new Point(6, 116);
            cboTemp.MaxDropDownItems = 4;
            cboTemp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTemp.Name = "cboTemp";
            cboTemp.Size = new Size(417, 49);
            cboTemp.StartIndex = 0;
            cboTemp.TabIndex = 15;
            // 
            // CadastroTimeCampeonato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 350);
            Location = new Point(0, 0);
            Name = "CadastroTimeCampeonato";
            Text = "CadastroTimeCampeonato";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboTemporada;
        private ReaLTaiizor.Controls.MaterialComboBox cboCamp;
        private ReaLTaiizor.Controls.MaterialComboBox cboTime;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboTemp;
    }
}