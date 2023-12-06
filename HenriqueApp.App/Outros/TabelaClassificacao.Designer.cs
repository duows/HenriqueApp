namespace HenriqueApp.App.Outros
{
    partial class TabelaClassificacao
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
            cboCamp = new ReaLTaiizor.Controls.MaterialComboBox();
            cboTemp = new ReaLTaiizor.Controls.MaterialComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            cboCamp.Location = new Point(6, 67);
            cboCamp.MaxDropDownItems = 4;
            cboCamp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCamp.Name = "cboCamp";
            cboCamp.Size = new Size(788, 49);
            cboCamp.StartIndex = 0;
            cboCamp.TabIndex = 0;
            cboCamp.SelectedIndexChanged += cboCamp_SelectedIndexChanged;
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
            cboTemp.Location = new Point(6, 122);
            cboTemp.MaxDropDownItems = 4;
            cboTemp.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTemp.Name = "cboTemp";
            cboTemp.Size = new Size(788, 49);
            cboTemp.StartIndex = 0;
            cboTemp.TabIndex = 1;
            cboTemp.SelectedIndexChanged += cboTemp_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(788, 267);
            dataGridView1.TabIndex = 2;
            // 
            // TabelaClassificacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(cboTemp);
            Controls.Add(cboCamp);
            Name = "TabelaClassificacao";
            Text = "TabelaClassificacao";
            Load += TabelaClassificacao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboCamp;
        private ReaLTaiizor.Controls.MaterialComboBox cboTemp;
        private DataGridView dataGridView1;
    }
}