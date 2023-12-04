using System.Reflection;

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
            txtGolDois = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboTimeUm = new ReaLTaiizor.Controls.MaterialComboBox();
            cboTimeDois = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCampeonato = new ReaLTaiizor.Controls.MaterialComboBox();
            cboTemporada = new ReaLTaiizor.Controls.MaterialComboBox();
            imgVersus = new PictureBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgVersus).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 361);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(imgVersus);
            tabPageCadastro.Controls.Add(cboTemporada);
            tabPageCadastro.Controls.Add(cboCampeonato);
            tabPageCadastro.Controls.Add(cboTimeDois);
            tabPageCadastro.Controls.Add(cboTimeUm);
            tabPageCadastro.Controls.Add(txtGolDois);
            tabPageCadastro.Controls.Add(txtGolUm);
            tabPageCadastro.Size = new Size(786, 326);
            tabPageCadastro.Controls.SetChildIndex(txtGolUm, 0);
            tabPageCadastro.Controls.SetChildIndex(txtGolDois, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTimeUm, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTimeDois, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCampeonato, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTemporada, 0);
            tabPageCadastro.Controls.SetChildIndex(imgVersus, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
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
            // txtGolDois
            // 
            txtGolDois.AnimateReadOnly = false;
            txtGolDois.AutoCompleteMode = AutoCompleteMode.None;
            txtGolDois.AutoCompleteSource = AutoCompleteSource.None;
            txtGolDois.BackgroundImageLayout = ImageLayout.None;
            txtGolDois.CharacterCasing = CharacterCasing.Normal;
            txtGolDois.Depth = 0;
            txtGolDois.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGolDois.HideSelection = true;
            txtGolDois.Hint = "Gols";
            txtGolDois.LeadingIcon = null;
            txtGolDois.Location = new Point(464, 60);
            txtGolDois.MaxLength = 32767;
            txtGolDois.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtGolDois.Name = "txtGolDois";
            txtGolDois.PasswordChar = '\0';
            txtGolDois.PrefixSuffixText = null;
            txtGolDois.ReadOnly = false;
            txtGolDois.RightToLeft = RightToLeft.No;
            txtGolDois.SelectedText = "";
            txtGolDois.SelectionLength = 0;
            txtGolDois.SelectionStart = 0;
            txtGolDois.ShortcutsEnabled = true;
            txtGolDois.Size = new Size(315, 48);
            txtGolDois.TabIndex = 14;
            txtGolDois.TabStop = false;
            txtGolDois.TextAlign = HorizontalAlignment.Left;
            txtGolDois.TrailingIcon = null;
            txtGolDois.UseSystemPasswordChar = false;
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
            cboTimeUm.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
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
            cboTimeUm.SelectedIndexChanged += CboTimeUm_SelectedIndexChanged;
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
            cboTimeDois.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
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
            cboCampeonato.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
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
            imgVersus.Location = new Point(328, 6);
            imgVersus.Name = "imgVersus";
            imgVersus.Size = new Size(117, 102);
            imgVersus.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVersus.TabIndex = 20;
            imgVersus.TabStop = false;
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
            txtId.Location = new Point(6, 224);
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
            txtId.Size = new Size(61, 48);
            txtId.TabIndex = 21;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Location = new Point(0, 0);
            Name = "CadastroPartida";
            Text = "CadastroPartida";
            Load += CadastroPartida_Load;
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgVersus).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGolDois;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGolUm;
        private ReaLTaiizor.Controls.MaterialComboBox cboCampeonato;
        private ReaLTaiizor.Controls.MaterialComboBox cboTimeDois;
        private ReaLTaiizor.Controls.MaterialComboBox cboTimeUm;
        private ReaLTaiizor.Controls.MaterialComboBox cboTemporada;
        private PictureBox imgVersus;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}