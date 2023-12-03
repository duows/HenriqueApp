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
            cboCampeonatos = new ReaLTaiizor.Controls.MaterialComboBox();
            cboTemporada = new ReaLTaiizor.Controls.MaterialComboBox();
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
            tabPageCadastro.Controls.Add(cboTemporada);
            tabPageCadastro.Controls.Add(cboCampeonatos);
            tabPageCadastro.Controls.Add(cboTime);
            tabPageCadastro.Size = new Size(786, 348);
            tabPageCadastro.Controls.SetChildIndex(cboTime, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCampeonatos, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTemporada, 0);
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
            cboTime.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
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
            // cboCampeonatos
            // 
            cboCampeonatos.AutoResize = false;
            cboCampeonatos.BackColor = Color.FromArgb(255, 255, 255);
            cboCampeonatos.Depth = 0;
            cboCampeonatos.DrawMode = DrawMode.OwnerDrawVariable;
            cboCampeonatos.DropDownHeight = 174;
            cboCampeonatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCampeonatos.DropDownWidth = 121;
            cboCampeonatos.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCampeonatos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCampeonatos.FormattingEnabled = true;
            cboCampeonatos.Hint = "Campeonato";
            cboCampeonatos.IntegralHeight = false;
            cboCampeonatos.ItemHeight = 43;
            cboCampeonatos.Location = new Point(6, 61);
            cboCampeonatos.MaxDropDownItems = 4;
            cboCampeonatos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCampeonatos.Name = "cboCampeonatos";
            cboCampeonatos.Size = new Size(417, 49);
            cboCampeonatos.StartIndex = 0;
            cboCampeonatos.TabIndex = 12;
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
            cboTemporada.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
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
        private ReaLTaiizor.Controls.MaterialComboBox cboCampeonatos;
        private ReaLTaiizor.Controls.MaterialComboBox cboTime;
    }
}