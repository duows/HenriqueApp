namespace HenriqueApp.App.Cadastros
{
    partial class CadastroPartida
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
            txtGolUm = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtGol2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboTimeUm = new ReaLTaiizor.Controls.MaterialComboBox();
            cboTimeDois = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCampeonato = new ReaLTaiizor.Controls.MaterialComboBox();
            cboTemporada = new ReaLTaiizor.Controls.MaterialComboBox();
            imgVersus = new PictureBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgVersus).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 341);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(imgVersus);
            tabPageCadastro.Controls.Add(cboTemporada);
            tabPageCadastro.Controls.Add(cboCampeonato);
            tabPageCadastro.Controls.Add(cboTimeDois);
            tabPageCadastro.Controls.Add(cboTimeUm);
            tabPageCadastro.Controls.Add(txtGol2);
            tabPageCadastro.Controls.Add(txtGolUm);
            tabPageCadastro.Size = new Size(786, 306);
            tabPageCadastro.Controls.SetChildIndex(txtGolUm, 0);
            tabPageCadastro.Controls.SetChildIndex(txtGol2, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTimeUm, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTimeDois, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCampeonato, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTemporada, 0);
            tabPageCadastro.Controls.SetChildIndex(imgVersus, 0);
            // 
            // txtGolUm
            // 
            txtGolUm.AnimateReadOnly = false;
            txtGolUm.AutoCompleteMode = AutoCompleteMode.None;
            txtGolUm.AutoCompleteSource = AutoCompleteSource.None;
            txtGolUm.BackgroundImageLayout = ImageLayout.None;
            txtGolUm.CharacterCasing = CharacterCasing.Normal;
            txtGolUm.Depth = 0;
            txtGolUm.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGolUm.HideSelection = true;
            txtGolUm.Hint = "Gols";
            txtGolUm.LeadingIcon = null;
            txtGolUm.Location = new Point(6, 60);
            txtGolUm.MaxLength = 32767;
            txtGolUm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtGolUm.Name = "txtGolUm";
            txtGolUm.PasswordChar = '\0';
            txtGolUm.PrefixSuffixText = null;
            txtGolUm.ReadOnly = false;
            txtGolUm.RightToLeft = RightToLeft.No;
            txtGolUm.SelectedText = "";
            txtGolUm.SelectionLength = 0;
            txtGolUm.SelectionStart = 0;
            txtGolUm.ShortcutsEnabled = true;
            txtGolUm.Size = new Size(305, 48);
            txtGolUm.TabIndex = 12;
            txtGolUm.TabStop = false;
            txtGolUm.TextAlign = HorizontalAlignment.Left;
            txtGolUm.TrailingIcon = null;
            txtGolUm.UseSystemPasswordChar = false;
            // 
            // txtGol2
            // 
            txtGol2.AnimateReadOnly = false;
            txtGol2.AutoCompleteMode = AutoCompleteMode.None;
            txtGol2.AutoCompleteSource = AutoCompleteSource.None;
            txtGol2.BackgroundImageLayout = ImageLayout.None;
            txtGol2.CharacterCasing = CharacterCasing.Normal;
            txtGol2.Depth = 0;
            txtGol2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGol2.HideSelection = true;
            txtGol2.Hint = "Gols";
            txtGol2.LeadingIcon = null;
            txtGol2.Location = new Point(464, 60);
            txtGol2.MaxLength = 32767;
            txtGol2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtGol2.Name = "txtGol2";
            txtGol2.PasswordChar = '\0';
            txtGol2.PrefixSuffixText = null;
            txtGol2.ReadOnly = false;
            txtGol2.RightToLeft = RightToLeft.No;
            txtGol2.SelectedText = "";
            txtGol2.SelectionLength = 0;
            txtGol2.SelectionStart = 0;
            txtGol2.ShortcutsEnabled = true;
            txtGol2.Size = new Size(315, 48);
            txtGol2.TabIndex = 14;
            txtGol2.TabStop = false;
            txtGol2.TextAlign = HorizontalAlignment.Left;
            txtGol2.TrailingIcon = null;
            txtGol2.UseSystemPasswordChar = false;
            // 
            // cboTimeUm
            // 
            cboTimeUm.AutoResize = false;
            cboTimeUm.BackColor = Color.FromArgb(255, 255, 255);
            cboTimeUm.Depth = 0;
            cboTimeUm.DrawMode = DrawMode.OwnerDrawVariable;
            cboTimeUm.DropDownHeight = 174;
            cboTimeUm.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTimeUm.DropDownWidth = 121;
            cboTimeUm.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTimeUm.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTimeUm.FormattingEnabled = true;
            cboTimeUm.Hint = "Mandante";
            cboTimeUm.IntegralHeight = false;
            cboTimeUm.ItemHeight = 43;
            cboTimeUm.Location = new Point(6, 6);
            cboTimeUm.MaxDropDownItems = 4;
            cboTimeUm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTimeUm.Name = "cboTimeUm";
            cboTimeUm.Size = new Size(305, 49);
            cboTimeUm.StartIndex = 0;
            cboTimeUm.TabIndex = 16;
            // 
            // cboTimeDois
            // 
            cboTimeDois.AutoResize = false;
            cboTimeDois.BackColor = Color.FromArgb(255, 255, 255);
            cboTimeDois.Depth = 0;
            cboTimeDois.DrawMode = DrawMode.OwnerDrawVariable;
            cboTimeDois.DropDownHeight = 174;
            cboTimeDois.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTimeDois.DropDownWidth = 121;
            cboTimeDois.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTimeDois.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTimeDois.FormattingEnabled = true;
            cboTimeDois.Hint = "Visitante";
            cboTimeDois.IntegralHeight = false;
            cboTimeDois.ItemHeight = 43;
            cboTimeDois.Location = new Point(464, 5);
            cboTimeDois.MaxDropDownItems = 4;
            cboTimeDois.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTimeDois.Name = "cboTimeDois";
            cboTimeDois.Size = new Size(315, 49);
            cboTimeDois.StartIndex = 0;
            cboTimeDois.TabIndex = 17;
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
            cboCampeonato.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCampeonato.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCampeonato.FormattingEnabled = true;
            cboCampeonato.Hint = "Campeonatos";
            cboCampeonato.IntegralHeight = false;
            cboCampeonato.ItemHeight = 43;
            cboCampeonato.Location = new Point(6, 114);
            cboCampeonato.MaxDropDownItems = 4;
            cboCampeonato.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCampeonato.Name = "cboCampeonato";
            cboCampeonato.Size = new Size(773, 49);
            cboCampeonato.StartIndex = 0;
            cboCampeonato.TabIndex = 18;
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
            cboTemporada.Location = new Point(6, 169);
            cboTemporada.MaxDropDownItems = 4;
            cboTemporada.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTemporada.Name = "cboTemporada";
            cboTemporada.Size = new Size(773, 49);
            cboTemporada.StartIndex = 0;
            cboTemporada.TabIndex = 19;
            // 
            // imgVersus
            // 
            imgVersus.BackgroundImageLayout = ImageLayout.Stretch;
            imgVersus.Image = App.Properties.Resources.vs;
            imgVersus.Location = new Point(328, 6);
            imgVersus.Name = "imgVersus";
            imgVersus.Size = new Size(117, 102);
            imgVersus.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVersus.TabIndex = 20;
            imgVersus.TabStop = false;
            // 
            // CadastroPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 408);
            Location = new Point(0, 0);
            Name = "CadastroPartida";
            Text = "CadastroPartida";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgVersus).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGol2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGolUm;
        private ReaLTaiizor.Controls.MaterialComboBox cboCampeonato;
        private ReaLTaiizor.Controls.MaterialComboBox cboTimeDois;
        private ReaLTaiizor.Controls.MaterialComboBox cboTimeUm;
        private ReaLTaiizor.Controls.MaterialComboBox cboTemporada;
        private PictureBox imgVersus;
    }
}