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
            cboCampeonato = new ReaLTaiizor.Controls.MaterialComboBox();
            btnNovoCamp = new ReaLTaiizor.Controls.MaterialButton();
            btnNovaTemp = new ReaLTaiizor.Controls.MaterialButton();
            cboTemporada = new ReaLTaiizor.Controls.MaterialComboBox();
            panel2 = new Panel();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 383);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(panel2);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Click += tabPageCadastro_Click;
            tabPageCadastro.Controls.SetChildIndex(panel2, 0);
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
            cboCampeonato.Location = new Point(3, 22);
            cboCampeonato.MaxDropDownItems = 4;
            cboCampeonato.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCampeonato.Name = "cboCampeonato";
            cboCampeonato.Size = new Size(574, 49);
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
            btnNovoCamp.Location = new Point(593, 27);
            btnNovoCamp.Margin = new Padding(4, 6, 4, 6);
            btnNovoCamp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovoCamp.Name = "btnNovoCamp";
            btnNovoCamp.NoAccentTextColor = Color.Empty;
            btnNovoCamp.Size = new Size(174, 36);
            btnNovoCamp.TabIndex = 1;
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
            btnNovaTemp.Location = new Point(598, 83);
            btnNovaTemp.Margin = new Padding(4, 6, 4, 6);
            btnNovaTemp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovaTemp.Name = "btnNovaTemp";
            btnNovaTemp.NoAccentTextColor = Color.Empty;
            btnNovaTemp.Size = new Size(162, 36);
            btnNovaTemp.TabIndex = 3;
            btnNovaTemp.Text = "&Nova temporada";
            btnNovaTemp.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovaTemp.UseAccentColor = false;
            btnNovaTemp.UseVisualStyleBackColor = true;
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
            cboTemporada.Location = new Point(3, 77);
            cboTemporada.MaxDropDownItems = 4;
            cboTemporada.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTemporada.Name = "cboTemporada";
            cboTemporada.Size = new Size(574, 49);
            cboTemporada.StartIndex = 0;
            cboTemporada.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(cboCampeonato);
            panel2.Controls.Add(btnNovaTemp);
            panel2.Controls.Add(btnNovoCamp);
            panel2.Controls.Add(cboTemporada);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(780, 288);
            panel2.TabIndex = 11;
            // 
            // CadastroCampeonatoTemporadaTempCamp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

        private ReaLTaiizor.Controls.MaterialButton btnNovoCamp;
        private ReaLTaiizor.Controls.MaterialComboBox cboCampeonato;
        private ReaLTaiizor.Controls.MaterialButton btnNovaTemp;
        private ReaLTaiizor.Controls.MaterialComboBox cboTemporada;
        private Panel panel2;
    }
}