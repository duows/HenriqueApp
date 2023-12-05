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
            cboTempCamp = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(794, 361);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboTempCamp);
            tabPageCadastro.Controls.Add(cboTimeDois);
            tabPageCadastro.Controls.Add(cboTimeUm);
            tabPageCadastro.Controls.Add(txtGolDois);
            tabPageCadastro.Controls.Add(txtGolUm);
            tabPageCadastro.Size = new Size(786, 326);
            tabPageCadastro.Controls.SetChildIndex(txtGolUm, 0);
            tabPageCadastro.Controls.SetChildIndex(txtGolDois, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTimeUm, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTimeDois, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTempCamp, 0);
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
            cboTempCamp.Hint = "Campeonatos - Temporada";
            cboTempCamp.IntegralHeight = false;
            cboTempCamp.ItemHeight = 43;
            cboTempCamp.Location = new Point(6, 114);
            cboTempCamp.MaxDropDownItems = 4;
            cboTempCamp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTempCamp.Name = "cboTempCamp";
            cboTempCamp.Size = new Size(773, 49);
            cboTempCamp.StartIndex = 0;
            cboTempCamp.TabIndex = 18;
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
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGolDois;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGolUm;
        private ReaLTaiizor.Controls.MaterialComboBox cboTempCamp;
        private ReaLTaiizor.Controls.MaterialComboBox cboTimeDois;
        private ReaLTaiizor.Controls.MaterialComboBox cboTimeUm;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}