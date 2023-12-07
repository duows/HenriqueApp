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
            this.cboTime = new ReaLTaiizor.Controls.MaterialComboBox();
            this.cboCamp = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboTemp = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(499, 283);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.cboTemp);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.cboCamp);
            this.tabPageCadastro.Controls.Add(this.cboTime);
            this.tabPageCadastro.Size = new System.Drawing.Size(491, 248);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboTime, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboCamp, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboTemp, 0);
            // 
            // cboTime
            // 
            this.cboTime.AutoResize = false;
            this.cboTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTime.Depth = 0;
            this.cboTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTime.DropDownHeight = 174;
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.DropDownWidth = 121;
            this.cboTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Hint = "Times";
            this.cboTime.IntegralHeight = false;
            this.cboTime.ItemHeight = 43;
            this.cboTime.Location = new System.Drawing.Point(6, 6);
            this.cboTime.MaxDropDownItems = 4;
            this.cboTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(417, 49);
            this.cboTime.StartIndex = 0;
            this.cboTime.TabIndex = 0;
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
            this.cboCamp.Hint = "Campeonato";
            this.cboCamp.IntegralHeight = false;
            this.cboCamp.ItemHeight = 43;
            this.cboCamp.Location = new System.Drawing.Point(6, 61);
            this.cboCamp.MaxDropDownItems = 4;
            this.cboCamp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboCamp.Name = "cboCamp";
            this.cboCamp.Size = new System.Drawing.Size(417, 49);
            this.cboCamp.StartIndex = 0;
            this.cboCamp.TabIndex = 1;
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
            this.txtId.Location = new System.Drawing.Point(429, 6);
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
            this.txtId.Size = new System.Drawing.Size(55, 48);
            this.txtId.TabIndex = 14;
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
            this.cboTemp.Location = new System.Drawing.Point(6, 116);
            this.cboTemp.MaxDropDownItems = 4;
            this.cboTemp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboTemp.Name = "cboTemp";
            this.cboTemp.Size = new System.Drawing.Size(417, 49);
            this.cboTemp.StartIndex = 0;
            this.cboTemp.TabIndex = 2;
            // 
            // CadastroTimeCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 350);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroTimeCampeonato";
            this.Text = "Cadastro de Time no Campeonato";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboTemporada;
        private ReaLTaiizor.Controls.MaterialComboBox cboCamp;
        private ReaLTaiizor.Controls.MaterialComboBox cboTime;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboTemp;
    }
}