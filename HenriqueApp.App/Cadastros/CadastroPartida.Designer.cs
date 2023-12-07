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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPartida));
            this.txtGolUm = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtGolDois = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboTimeUm = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboTimeDois = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboCamp = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboTemp = new ReaLTaiizor.Controls.MaterialComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(794, 368);
            this.materialTabControl.SelectedIndexChanged += new System.EventHandler(this.materialTabControl_SelectedIndexChanged);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.pictureBox1);
            this.tabPageCadastro.Controls.Add(this.cboTemp);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.cboCamp);
            this.tabPageCadastro.Controls.Add(this.cboTimeDois);
            this.tabPageCadastro.Controls.Add(this.cboTimeUm);
            this.tabPageCadastro.Controls.Add(this.txtGolDois);
            this.tabPageCadastro.Controls.Add(this.txtGolUm);
            this.tabPageCadastro.Size = new System.Drawing.Size(786, 333);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtGolUm, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtGolDois, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboTimeUm, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboTimeDois, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboCamp, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboTemp, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Size = new System.Drawing.Size(786, 333);
            // 
            // txtGolUm
            // 
            this.txtGolUm.AnimateReadOnly = false;
            this.txtGolUm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGolUm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGolUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGolUm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGolUm.Depth = 0;
            this.txtGolUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGolUm.HideSelection = true;
            this.txtGolUm.Hint = "Gols";
            this.txtGolUm.LeadingIcon = null;
            this.txtGolUm.Location = new System.Drawing.Point(6, 60);
            this.txtGolUm.MaxLength = 32767;
            this.txtGolUm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtGolUm.Name = "txtGolUm";
            this.txtGolUm.PasswordChar = '\0';
            this.txtGolUm.PrefixSuffixText = null;
            this.txtGolUm.ReadOnly = false;
            this.txtGolUm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGolUm.SelectedText = "";
            this.txtGolUm.SelectionLength = 0;
            this.txtGolUm.SelectionStart = 0;
            this.txtGolUm.ShortcutsEnabled = true;
            this.txtGolUm.Size = new System.Drawing.Size(305, 48);
            this.txtGolUm.TabIndex = 2;
            this.txtGolUm.TabStop = false;
            this.txtGolUm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGolUm.TrailingIcon = null;
            this.txtGolUm.UseSystemPasswordChar = false;
            // 
            // txtGolDois
            // 
            this.txtGolDois.AnimateReadOnly = false;
            this.txtGolDois.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtGolDois.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtGolDois.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGolDois.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGolDois.Depth = 0;
            this.txtGolDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGolDois.HideSelection = true;
            this.txtGolDois.Hint = "Gols";
            this.txtGolDois.LeadingIcon = null;
            this.txtGolDois.Location = new System.Drawing.Point(464, 60);
            this.txtGolDois.MaxLength = 32767;
            this.txtGolDois.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtGolDois.Name = "txtGolDois";
            this.txtGolDois.PasswordChar = '\0';
            this.txtGolDois.PrefixSuffixText = null;
            this.txtGolDois.ReadOnly = false;
            this.txtGolDois.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGolDois.SelectedText = "";
            this.txtGolDois.SelectionLength = 0;
            this.txtGolDois.SelectionStart = 0;
            this.txtGolDois.ShortcutsEnabled = true;
            this.txtGolDois.Size = new System.Drawing.Size(315, 48);
            this.txtGolDois.TabIndex = 3;
            this.txtGolDois.TabStop = false;
            this.txtGolDois.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGolDois.TrailingIcon = null;
            this.txtGolDois.UseSystemPasswordChar = false;
            // 
            // cboTimeUm
            // 
            this.cboTimeUm.AutoResize = false;
            this.cboTimeUm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTimeUm.Depth = 0;
            this.cboTimeUm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTimeUm.DropDownHeight = 174;
            this.cboTimeUm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeUm.DropDownWidth = 121;
            this.cboTimeUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTimeUm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTimeUm.FormattingEnabled = true;
            this.cboTimeUm.Hint = "Mandante";
            this.cboTimeUm.IntegralHeight = false;
            this.cboTimeUm.ItemHeight = 43;
            this.cboTimeUm.Location = new System.Drawing.Point(6, 6);
            this.cboTimeUm.MaxDropDownItems = 4;
            this.cboTimeUm.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTimeUm.Name = "cboTimeUm";
            this.cboTimeUm.Size = new System.Drawing.Size(305, 49);
            this.cboTimeUm.StartIndex = 0;
            this.cboTimeUm.TabIndex = 0;
            // 
            // cboTimeDois
            // 
            this.cboTimeDois.AutoResize = false;
            this.cboTimeDois.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTimeDois.Depth = 0;
            this.cboTimeDois.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTimeDois.DropDownHeight = 174;
            this.cboTimeDois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeDois.DropDownWidth = 121;
            this.cboTimeDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTimeDois.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTimeDois.FormattingEnabled = true;
            this.cboTimeDois.Hint = "Visitante";
            this.cboTimeDois.IntegralHeight = false;
            this.cboTimeDois.ItemHeight = 43;
            this.cboTimeDois.Location = new System.Drawing.Point(464, 5);
            this.cboTimeDois.MaxDropDownItems = 4;
            this.cboTimeDois.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTimeDois.Name = "cboTimeDois";
            this.cboTimeDois.Size = new System.Drawing.Size(315, 49);
            this.cboTimeDois.StartIndex = 0;
            this.cboTimeDois.TabIndex = 1;
            // 
            // cboCamp
            // 
            this.cboCamp.AutoResize = false;
            this.cboCamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCamp.Depth = 0;
            this.cboCamp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCamp.DropDownHeight = 174;
            this.cboCamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamp.DropDownWidth = 121;
            this.cboCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCamp.FormattingEnabled = true;
            this.cboCamp.Hint = "Campeonatos";
            this.cboCamp.IntegralHeight = false;
            this.cboCamp.ItemHeight = 43;
            this.cboCamp.Location = new System.Drawing.Point(6, 114);
            this.cboCamp.MaxDropDownItems = 4;
            this.cboCamp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboCamp.Name = "cboCamp";
            this.cboCamp.Size = new System.Drawing.Size(773, 49);
            this.cboCamp.StartIndex = 0;
            this.cboCamp.TabIndex = 4;
            this.cboCamp.SelectedIndexChanged += new System.EventHandler(this.cboCamp_SelectedIndexChanged);
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
            this.txtId.Location = new System.Drawing.Point(6, 224);
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
            this.txtId.Size = new System.Drawing.Size(61, 48);
            this.txtId.TabIndex = 21;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // cboTemp
            // 
            this.cboTemp.AutoResize = false;
            this.cboTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTemp.Depth = 0;
            this.cboTemp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTemp.DropDownHeight = 174;
            this.cboTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTemp.DropDownWidth = 121;
            this.cboTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTemp.FormattingEnabled = true;
            this.cboTemp.Hint = "Temporada";
            this.cboTemp.IntegralHeight = false;
            this.cboTemp.ItemHeight = 43;
            this.cboTemp.Location = new System.Drawing.Point(6, 169);
            this.cboTemp.MaxDropDownItems = 4;
            this.cboTemp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTemp.Name = "cboTemp";
            this.cboTemp.Size = new System.Drawing.Size(773, 49);
            this.cboTemp.StartIndex = 0;
            this.cboTemp.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // CadastroPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroPartida";
            this.Text = "Cadastro de Partida";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGolDois;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGolUm;
        private ReaLTaiizor.Controls.MaterialComboBox cboCamp;
        private ReaLTaiizor.Controls.MaterialComboBox cboTimeDois;
        private ReaLTaiizor.Controls.MaterialComboBox cboTimeUm;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboTemp;
        private PictureBox pictureBox1;
    }
}