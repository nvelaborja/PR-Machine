namespace PR_Machine
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayerNameDropBox = new System.Windows.Forms.ComboBox();
            this.playerStringsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileProcessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fasdfasdfasdf = new System.Windows.Forms.Label();
            this.Place = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_AddPlacing = new System.Windows.Forms.Button();
            this.MonthlyCheckBox = new System.Windows.Forms.CheckBox();
            this.PlacingNumberBox = new System.Windows.Forms.NumericUpDown();
            this.DisplayBox = new System.Windows.Forms.RichTextBox();
            this.playersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.NewPlayerEntryBox = new System.Windows.Forms.TextBox();
            this.Button_AddPlayer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TournamentNameBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTournamentDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTournamentDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCurrentPRStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlacingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllPlayerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentFileInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WinkyFace = new System.Windows.Forms.PictureBox();
            this.clearTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.playerStringsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileProcessorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlacingNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinkyFace)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerNameDropBox
            // 
            this.PlayerNameDropBox.DataSource = this.playerStringsBindingSource;
            this.PlayerNameDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerNameDropBox.ItemHeight = 13;
            this.PlayerNameDropBox.Location = new System.Drawing.Point(12, 50);
            this.PlayerNameDropBox.MaxDropDownItems = 25;
            this.PlayerNameDropBox.MaxLength = 100;
            this.PlayerNameDropBox.Name = "PlayerNameDropBox";
            this.PlayerNameDropBox.Size = new System.Drawing.Size(121, 21);
            this.PlayerNameDropBox.TabIndex = 11;
            this.PlayerNameDropBox.SelectedIndexChanged += new System.EventHandler(this.PlayerNameDropBox_SelectedIndexChanged);
            // 
            // playerStringsBindingSource
            // 
            this.playerStringsBindingSource.DataMember = "PlayerStrings";
            this.playerStringsBindingSource.DataSource = this.fileProcessorBindingSource;
            // 
            // fileProcessorBindingSource
            // 
            this.fileProcessorBindingSource.DataSource = typeof(PR_Machine.FileProcessor);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(PR_Machine.Player);
            // 
            // playersBindingSource3
            // 
            this.playersBindingSource3.DataMember = "Players";
            this.playersBindingSource3.DataSource = this.fileProcessorBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // fasdfasdfasdf
            // 
            this.fasdfasdfasdf.AutoSize = true;
            this.fasdfasdfasdf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fasdfasdfasdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fasdfasdfasdf.Location = new System.Drawing.Point(15, 34);
            this.fasdfasdfasdf.Name = "fasdfasdfasdf";
            this.fasdfasdfasdf.Size = new System.Drawing.Size(76, 13);
            this.fasdfasdfasdf.TabIndex = 4;
            this.fasdfasdfasdf.Text = "Monkey Name";
            this.fasdfasdfasdf.Click += new System.EventHandler(this.label2_Click);
            // 
            // Place
            // 
            this.Place.AutoSize = true;
            this.Place.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Place.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Place.Location = new System.Drawing.Point(145, 34);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(34, 13);
            this.Place.TabIndex = 5;
            this.Place.Text = "Place";
            this.Place.Click += new System.EventHandler(this.Place_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(186, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Monthly";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Button_AddPlacing
            // 
            this.Button_AddPlacing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddPlacing.Location = new System.Drawing.Point(12, 89);
            this.Button_AddPlacing.Name = "Button_AddPlacing";
            this.Button_AddPlacing.Size = new System.Drawing.Size(363, 23);
            this.Button_AddPlacing.TabIndex = 7;
            this.Button_AddPlacing.Text = "Add Placing";
            this.Button_AddPlacing.UseVisualStyleBackColor = true;
            this.Button_AddPlacing.Click += new System.EventHandler(this.button1_Click);
            // 
            // MonthlyCheckBox
            // 
            this.MonthlyCheckBox.AutoSize = true;
            this.MonthlyCheckBox.Location = new System.Drawing.Point(202, 53);
            this.MonthlyCheckBox.Name = "MonthlyCheckBox";
            this.MonthlyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MonthlyCheckBox.TabIndex = 8;
            this.MonthlyCheckBox.UseVisualStyleBackColor = true;
            this.MonthlyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PlacingNumberBox
            // 
            this.PlacingNumberBox.Location = new System.Drawing.Point(145, 50);
            this.PlacingNumberBox.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.PlacingNumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlacingNumberBox.Name = "PlacingNumberBox";
            this.PlacingNumberBox.Size = new System.Drawing.Size(37, 20);
            this.PlacingNumberBox.TabIndex = 9;
            this.PlacingNumberBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DisplayBox
            // 
            this.DisplayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayBox.Location = new System.Drawing.Point(383, 34);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(322, 431);
            this.DisplayBox.TabIndex = 10;
            this.DisplayBox.Text = "";
            this.DisplayBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // playersBindingSource2
            // 
            this.playersBindingSource2.DataMember = "Players";
            this.playersBindingSource2.DataSource = this.fileProcessorBindingSource;
            // 
            // playersBindingSource1
            // 
            this.playersBindingSource1.DataMember = "Players";
            this.playersBindingSource1.DataSource = this.fileProcessorBindingSource;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.fileProcessorBindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Don\'t See The Monkey You Need? Add It Here!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NewPlayerEntryBox
            // 
            this.NewPlayerEntryBox.Location = new System.Drawing.Point(12, 162);
            this.NewPlayerEntryBox.Name = "NewPlayerEntryBox";
            this.NewPlayerEntryBox.Size = new System.Drawing.Size(205, 20);
            this.NewPlayerEntryBox.TabIndex = 13;
            this.NewPlayerEntryBox.TextChanged += new System.EventHandler(this.NewPlayerEntryBox_TextChanged);
            // 
            // Button_AddPlayer
            // 
            this.Button_AddPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddPlayer.Location = new System.Drawing.Point(235, 162);
            this.Button_AddPlayer.Name = "Button_AddPlayer";
            this.Button_AddPlayer.Size = new System.Drawing.Size(121, 23);
            this.Button_AddPlayer.TabIndex = 14;
            this.Button_AddPlayer.Text = "Add Player";
            this.Button_AddPlayer.UseVisualStyleBackColor = true;
            this.Button_AddPlayer.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(232, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tournament Name (Optional)";
            // 
            // TournamentNameBox
            // 
            this.TournamentNameBox.Location = new System.Drawing.Point(235, 49);
            this.TournamentNameBox.Name = "TournamentNameBox";
            this.TournamentNameBox.Size = new System.Drawing.Size(121, 20);
            this.TournamentNameBox.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTournamentDataFileToolStripMenuItem,
            this.saveTournamentDataFileToolStripMenuItem,
            this.exportCurrentPRStatisticsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadTournamentDataFileToolStripMenuItem
            // 
            this.loadTournamentDataFileToolStripMenuItem.Name = "loadTournamentDataFileToolStripMenuItem";
            this.loadTournamentDataFileToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.loadTournamentDataFileToolStripMenuItem.Text = "Load Tournament Data File";
            this.loadTournamentDataFileToolStripMenuItem.Click += new System.EventHandler(this.loadTournamentDataFileToolStripMenuItem_Click);
            // 
            // saveTournamentDataFileToolStripMenuItem
            // 
            this.saveTournamentDataFileToolStripMenuItem.Name = "saveTournamentDataFileToolStripMenuItem";
            this.saveTournamentDataFileToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.saveTournamentDataFileToolStripMenuItem.Text = "Save Tournament Data File";
            this.saveTournamentDataFileToolStripMenuItem.Click += new System.EventHandler(this.saveTournamentDataFileToolStripMenuItem_Click);
            // 
            // exportCurrentPRStatisticsToolStripMenuItem
            // 
            this.exportCurrentPRStatisticsToolStripMenuItem.Name = "exportCurrentPRStatisticsToolStripMenuItem";
            this.exportCurrentPRStatisticsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.exportCurrentPRStatisticsToolStripMenuItem.Text = "Export Current PR Statistics";
            this.exportCurrentPRStatisticsToolStripMenuItem.Click += new System.EventHandler(this.exportCurrentPRStatisticsToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlacingToolStripMenuItem,
            this.addPlayerToolStripMenuItem,
            this.displayAllPlayerInformationToolStripMenuItem,
            this.generatePRToolStripMenuItem,
            this.showCurrentFileInformationToolStripMenuItem,
            this.clearTextBoxToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // addPlacingToolStripMenuItem
            // 
            this.addPlacingToolStripMenuItem.Name = "addPlacingToolStripMenuItem";
            this.addPlacingToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addPlacingToolStripMenuItem.Text = "Add Placing";
            this.addPlacingToolStripMenuItem.Click += new System.EventHandler(this.addPlacingToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // displayAllPlayerInformationToolStripMenuItem
            // 
            this.displayAllPlayerInformationToolStripMenuItem.Name = "displayAllPlayerInformationToolStripMenuItem";
            this.displayAllPlayerInformationToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.displayAllPlayerInformationToolStripMenuItem.Text = "Display All Player Information";
            this.displayAllPlayerInformationToolStripMenuItem.Click += new System.EventHandler(this.displayAllPlayerInformationToolStripMenuItem_Click);
            // 
            // generatePRToolStripMenuItem
            // 
            this.generatePRToolStripMenuItem.Name = "generatePRToolStripMenuItem";
            this.generatePRToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.generatePRToolStripMenuItem.Text = "Display PR";
            this.generatePRToolStripMenuItem.Click += new System.EventHandler(this.generatePRToolStripMenuItem_Click);
            // 
            // showCurrentFileInformationToolStripMenuItem
            // 
            this.showCurrentFileInformationToolStripMenuItem.Name = "showCurrentFileInformationToolStripMenuItem";
            this.showCurrentFileInformationToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.showCurrentFileInformationToolStripMenuItem.Text = "Show Current File Information";
            this.showCurrentFileInformationToolStripMenuItem.Click += new System.EventHandler(this.showCurrentFileInformationToolStripMenuItem_Click);
            // 
            // WinkyFace
            // 
            this.WinkyFace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WinkyFace.BackColor = System.Drawing.Color.Transparent;
            this.WinkyFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WinkyFace.Image = ((System.Drawing.Image)(resources.GetObject("WinkyFace.Image")));
            this.WinkyFace.Location = new System.Drawing.Point(53, 213);
            this.WinkyFace.Name = "WinkyFace";
            this.WinkyFace.Size = new System.Drawing.Size(244, 252);
            this.WinkyFace.TabIndex = 21;
            this.WinkyFace.TabStop = false;
            this.WinkyFace.Click += new System.EventHandler(this.WinkyFace_Click);
            // 
            // clearTextBoxToolStripMenuItem
            // 
            this.clearTextBoxToolStripMenuItem.Name = "clearTextBoxToolStripMenuItem";
            this.clearTextBoxToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.clearTextBoxToolStripMenuItem.Text = "Clear Text Box";
            this.clearTextBoxToolStripMenuItem.Click += new System.EventHandler(this.clearTextBoxToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(718, 477);
            this.Controls.Add(this.WinkyFace);
            this.Controls.Add(this.TournamentNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_AddPlayer);
            this.Controls.Add(this.NewPlayerEntryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerNameDropBox);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.PlacingNumberBox);
            this.Controls.Add(this.MonthlyCheckBox);
            this.Controls.Add(this.Button_AddPlacing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.fasdfasdfasdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(734, 516);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PR Machine - Smash Bros. At WSU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerStringsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileProcessorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlacingNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WinkyFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fasdfasdfasdf;
        private System.Windows.Forms.Label Place;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_AddPlacing;
        private System.Windows.Forms.CheckBox MonthlyCheckBox;
        private System.Windows.Forms.NumericUpDown PlacingNumberBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPlayerEntryBox;
        private System.Windows.Forms.Button Button_AddPlayer;
        public System.Windows.Forms.RichTextBox DisplayBox;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource fileProcessorBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource1;
        private System.Windows.Forms.BindingSource playersBindingSource2;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.ComboBox PlayerNameDropBox;
        private System.Windows.Forms.BindingSource playersBindingSource3;
        private System.Windows.Forms.BindingSource playerStringsBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TournamentNameBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTournamentDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTournamentDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentPRStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlacingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllPlayerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentFileInformationToolStripMenuItem;
        private System.Windows.Forms.PictureBox WinkyFace;
        private System.Windows.Forms.ToolStripMenuItem clearTextBoxToolStripMenuItem;
    }
}

