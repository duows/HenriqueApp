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
            cboTempCamp = new ReaLTaiizor.Controls.MaterialComboBox();
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
            tabPageCadastro.Controls.Add(cboTempCamp);
            tabPageCadastro.Controls.Add(cboTime);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(cboTime, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTempCamp, 0);
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
            // cboTempCamp
            // 
            cboTempCamp.AutoResize = false;
            cboTempCamp.BackColor = Color.FromArgb(255, 255, 255);
            cboTempCamp.Depth = 0;
            cboTempCamp.DrawMode = DrawMode.OwnerDrawVariable;
            cboTempCamp.DropDownHeight = 174;
            cboTempCamp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTempCamp.DropDownWidth = 121;
            cboTempCamp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTempCamp.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTempCamp.FormattingEnabled = true;
            cboTempCamp.Hint = "Campeonato - Temporada";
            cboTempCamp.IntegralHeight = false;
            cboTempCamp.ItemHeight = 43;
            cboTempCamp.Location = new Point(6, 61);
            cboTempCamp.MaxDropDownItems = 4;
            cboTempCamp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTempCamp.Name = "cboTempCamp";
            cboTempCamp.Size = new Size(417, 49);
            cboTempCamp.StartIndex = 0;
            cboTempCamp.TabIndex = 12;
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
        private ReaLTaiizor.Controls.MaterialComboBox cboTempCamp;
        private ReaLTaiizor.Controls.MaterialComboBox cboTime;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}