namespace HenriqueApp.App
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            timeToolStripMenuItem = new ToolStripMenuItem();
            jogadorToolStripMenuItem = new ToolStripMenuItem();
            campeonatoToolStripMenuItem = new ToolStripMenuItem();
            timeToolStripMenuItem1 = new ToolStripMenuItem();
            novoCampeonatoToolStripMenuItem = new ToolStripMenuItem();
            classificaçãoToolStripMenuItem = new ToolStripMenuItem();
            partidaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            aJudaToolStripMenuItem = new ToolStripMenuItem();
            sãoPauloToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, aJudaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { timeToolStripMenuItem, jogadorToolStripMenuItem, campeonatoToolStripMenuItem, partidaToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // timeToolStripMenuItem
            // 
            timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            timeToolStripMenuItem.Size = new Size(143, 22);
            timeToolStripMenuItem.Text = "Time";
            timeToolStripMenuItem.Click += timeToolStripMenuItem_Click;
            // 
            // jogadorToolStripMenuItem
            // 
            jogadorToolStripMenuItem.Name = "jogadorToolStripMenuItem";
            jogadorToolStripMenuItem.Size = new Size(143, 22);
            jogadorToolStripMenuItem.Text = "Jogador";
            jogadorToolStripMenuItem.Click += jogadorToolStripMenuItem_Click;
            // 
            // campeonatoToolStripMenuItem
            // 
            campeonatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { timeToolStripMenuItem1, novoCampeonatoToolStripMenuItem, classificaçãoToolStripMenuItem });
            campeonatoToolStripMenuItem.Name = "campeonatoToolStripMenuItem";
            campeonatoToolStripMenuItem.Size = new Size(143, 22);
            campeonatoToolStripMenuItem.Text = "Campeonato";
            campeonatoToolStripMenuItem.Click += campeonatoToolStripMenuItem_Click;
            // 
            // timeToolStripMenuItem1
            // 
            timeToolStripMenuItem1.Name = "timeToolStripMenuItem1";
            timeToolStripMenuItem1.Size = new Size(187, 22);
            timeToolStripMenuItem1.Text = "Time no campeonato";
            timeToolStripMenuItem1.Click += timeToolStripMenuItem1_Click;
            // 
            // novoCampeonatoToolStripMenuItem
            // 
            novoCampeonatoToolStripMenuItem.Name = "novoCampeonatoToolStripMenuItem";
            novoCampeonatoToolStripMenuItem.Size = new Size(187, 22);
            novoCampeonatoToolStripMenuItem.Text = "Novo campeonato";
            novoCampeonatoToolStripMenuItem.Click += novoCampeonatoToolStripMenuItem_Click;
            // 
            // classificaçãoToolStripMenuItem
            // 
            classificaçãoToolStripMenuItem.Name = "classificaçãoToolStripMenuItem";
            classificaçãoToolStripMenuItem.Size = new Size(187, 22);
            classificaçãoToolStripMenuItem.Text = "Classificação";
            classificaçãoToolStripMenuItem.Click += classificaçãoToolStripMenuItem_Click;
            // 
            // partidaToolStripMenuItem
            // 
            partidaToolStripMenuItem.Name = "partidaToolStripMenuItem";
            partidaToolStripMenuItem.Size = new Size(143, 22);
            partidaToolStripMenuItem.Text = "Partida";
            partidaToolStripMenuItem.Click += partidaToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click_1;
            // 
            // aJudaToolStripMenuItem
            // 
            aJudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sãoPauloToolStripMenuItem });
            aJudaToolStripMenuItem.Name = "aJudaToolStripMenuItem";
            aJudaToolStripMenuItem.Size = new Size(50, 20);
            aJudaToolStripMenuItem.Text = "Ajuda";
            aJudaToolStripMenuItem.Click += aJudaToolStripMenuItem_Click_1;
            // 
            // sãoPauloToolStripMenuItem
            // 
            sãoPauloToolStripMenuItem.Name = "sãoPauloToolStripMenuItem";
            sãoPauloToolStripMenuItem.Size = new Size(180, 22);
            sãoPauloToolStripMenuItem.Text = "São paulo";
            sãoPauloToolStripMenuItem.Click += sãoPauloToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "HENRIQUE APP";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem timeToolStripMenuItem;
        private ToolStripMenuItem jogadorToolStripMenuItem;
        private ToolStripMenuItem campeonatoToolStripMenuItem;
        private ToolStripMenuItem partidaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem timeToolStripMenuItem1;
        private ToolStripMenuItem novoCampeonatoToolStripMenuItem;
        private ToolStripMenuItem classificaçãoToolStripMenuItem;
        private ToolStripMenuItem aJudaToolStripMenuItem;
        private ToolStripMenuItem sãoPauloToolStripMenuItem;
    }
}