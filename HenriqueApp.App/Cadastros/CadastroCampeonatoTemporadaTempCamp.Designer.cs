namespace HenriqueApp.App.Cadastros
{
    partial class CadastroCampeonatoTemporadaTempCamp
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
            panel2 = new Panel();
            btnNTemp = new ReaLTaiizor.Controls.MaterialButton();
            btnNCamp = new ReaLTaiizor.Controls.MaterialButton();
            cboTemporada = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCampeonato = new ReaLTaiizor.Controls.MaterialComboBox();
            btnNovoCamp = new ReaLTaiizor.Controls.MaterialButton();
            btnNovaTemp = new ReaLTaiizor.Controls.MaterialButton();
            txtPremio = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCampeao = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 363);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(panel2);
            tabPageCadastro.Size = new Size(786, 328);
            tabPageCadastro.Click += tabPageCadastro_Click;
            tabPageCadastro.Controls.SetChildIndex(panel2, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(cboCampeao);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(txtPremio);
            panel2.Controls.Add(btnNTemp);
            panel2.Controls.Add(btnNCamp);
            panel2.Controls.Add(cboTemporada);
            panel2.Controls.Add(cboCampeonato);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 268);
            panel2.TabIndex = 11;
            // 
            // btnNTemp
            // 
            btnNTemp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNTemp.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNTemp.Depth = 0;
            btnNTemp.HighEmphasis = true;
            btnNTemp.Icon = null;
            btnNTemp.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNTemp.Location = new Point(396, 61);
            btnNTemp.Margin = new Padding(4, 6, 4, 6);
            btnNTemp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNTemp.Name = "btnNTemp";
            btnNTemp.NoAccentTextColor = Color.Empty;
            btnNTemp.Size = new Size(162, 36);
            btnNTemp.TabIndex = 3;
            btnNTemp.Text = "&Nova temporada";
            btnNTemp.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNTemp.UseAccentColor = false;
            btnNTemp.UseVisualStyleBackColor = true;
            btnNTemp.Click += btnNTemp_Click;
            // 
            // btnNCamp
            // 
            btnNCamp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNCamp.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNCamp.Depth = 0;
            btnNCamp.HighEmphasis = true;
            btnNCamp.Icon = null;
            btnNCamp.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNCamp.Location = new Point(4, 61);
            btnNCamp.Margin = new Padding(4, 6, 4, 6);
            btnNCamp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNCamp.Name = "btnNCamp";
            btnNCamp.NoAccentTextColor = Color.Empty;
            btnNCamp.Size = new Size(174, 36);
            btnNCamp.TabIndex = 2;
            btnNCamp.Text = "&Novo campeonato";
            btnNCamp.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNCamp.UseAccentColor = false;
            btnNCamp.UseVisualStyleBackColor = true;
            btnNCamp.Click += btnNCamp_Click;
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
            cboTemporada.Hint = "Temporadas";
            cboTemporada.IntegralHeight = false;
            cboTemporada.ItemHeight = 43;
            cboTemporada.Location = new Point(396, 3);
            cboTemporada.MaxDropDownItems = 4;
            cboTemporada.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTemporada.Name = "cboTemporada";
            cboTemporada.Size = new Size(380, 49);
            cboTemporada.StartIndex = 0;
            cboTemporada.TabIndex = 1;
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
            cboCampeonato.Hint = "Campeonatos";
            cboCampeonato.IntegralHeight = false;
            cboCampeonato.ItemHeight = 43;
            cboCampeonato.Location = new Point(4, 3);
            cboCampeonato.MaxDropDownItems = 4;
            cboCampeonato.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCampeonato.Name = "cboCampeonato";
            cboCampeonato.Size = new Size(380, 49);
            cboCampeonato.StartIndex = 0;
            cboCampeonato.TabIndex = 0;
            // 
            // btnNovoCamp
            // 
            btnNovoCamp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovoCamp.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovoCamp.Depth = 0;
            btnNovoCamp.HighEmphasis = true;
            btnNovoCamp.Icon = null;
            btnNovoCamp.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovoCamp.Location = new Point(4, 6);
            btnNovoCamp.Margin = new Padding(4, 6, 4, 6);
            btnNovoCamp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovoCamp.Name = "btnNovoCamp";
            btnNovoCamp.NoAccentTextColor = Color.Empty;
            btnNovoCamp.Size = new Size(174, 36);
            btnNovoCamp.TabIndex = 12;
            btnNovoCamp.Text = "&Novo campeonato";
            btnNovoCamp.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovoCamp.UseAccentColor = false;
            btnNovoCamp.UseVisualStyleBackColor = true;
            // 
            // btnNovaTemp
            // 
            btnNovaTemp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovaTemp.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovaTemp.Depth = 0;
            btnNovaTemp.HighEmphasis = true;
            btnNovaTemp.Icon = null;
            btnNovaTemp.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovaTemp.Location = new Point(186, 6);
            btnNovaTemp.Margin = new Padding(4, 6, 4, 6);
            btnNovaTemp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovaTemp.Name = "btnNovaTemp";
            btnNovaTemp.NoAccentTextColor = Color.Empty;
            btnNovaTemp.Size = new Size(162, 36);
            btnNovaTemp.TabIndex = 13;
            btnNovaTemp.Text = "&Nova temporada";
            btnNovaTemp.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovaTemp.UseAccentColor = false;
            btnNovaTemp.UseVisualStyleBackColor = true;
            // 
            // txtPremio
            // 
            txtPremio.AnimateReadOnly = false;
            txtPremio.AutoCompleteMode = AutoCompleteMode.None;
            txtPremio.AutoCompleteSource = AutoCompleteSource.None;
            txtPremio.BackgroundImageLayout = ImageLayout.None;
            txtPremio.CharacterCasing = CharacterCasing.Normal;
            txtPremio.Depth = 0;
            txtPremio.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPremio.HideSelection = true;
            txtPremio.Hint = "Prêmio";
            txtPremio.LeadingIcon = null;
            txtPremio.Location = new Point(4, 106);
            txtPremio.MaxLength = 32767;
            txtPremio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPremio.Name = "txtPremio";
            txtPremio.PasswordChar = '\0';
            txtPremio.PrefixSuffixText = null;
            txtPremio.ReadOnly = false;
            txtPremio.RightToLeft = RightToLeft.No;
            txtPremio.SelectedText = "";
            txtPremio.SelectionLength = 0;
            txtPremio.SelectionStart = 0;
            txtPremio.ShortcutsEnabled = true;
            txtPremio.Size = new Size(715, 48);
            txtPremio.TabIndex = 4;
            txtPremio.TabStop = false;
            txtPremio.TextAlign = HorizontalAlignment.Left;
            txtPremio.TrailingIcon = null;
            txtPremio.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(725, 106);
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
            txtId.Size = new Size(51, 48);
            txtId.TabIndex = 6;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            txtId.Click += txtId_Click;
            // 
            // cboCampeao
            // 
            cboCampeao.AutoResize = false;
            cboCampeao.BackColor = Color.FromArgb(255, 255, 255);
            cboCampeao.Depth = 0;
            cboCampeao.DrawMode = DrawMode.OwnerDrawVariable;
            cboCampeao.DropDownHeight = 174;
            cboCampeao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampeao.DropDownWidth = 121;
            cboCampeao.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCampeao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCampeao.FormattingEnabled = true;
            cboCampeao.Hint = "Campeão";
            cboCampeao.IntegralHeight = false;
            cboCampeao.ItemHeight = 43;
            cboCampeao.Location = new Point(4, 160);
            cboCampeao.MaxDropDownItems = 4;
            cboCampeao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCampeao.Name = "cboCampeao";
            cboCampeao.Size = new Size(772, 49);
            cboCampeao.StartIndex = 0;
            cboCampeao.TabIndex = 7;
            // 
            // CadastroCampeonatoTemporadaTempCamp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Location = new Point(0, 0);
            Name = "CadastroCampeonatoTemporadaTempCamp";
            Text = "CAMPEONATOS";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ReaLTaiizor.Controls.MaterialComboBox cboCampeonato;
        private ReaLTaiizor.Controls.MaterialButton btnNovoCamp;
        private ReaLTaiizor.Controls.MaterialButton btnNovaTemp;
        private ReaLTaiizor.Controls.MaterialComboBox cboTemporada;
        private ReaLTaiizor.Controls.MaterialButton btnNTemp;
        private ReaLTaiizor.Controls.MaterialButton btnNCamp;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPremio;
        private ReaLTaiizor.Controls.MaterialComboBox cboCampeao;
    }
}