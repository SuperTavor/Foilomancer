namespace FoilomancerGUI
{
    partial class MainForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.loadModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectAdbToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bluestacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadModToolStripMenuItem,
            this.packModToolStripMenuItem,
            this.howToUseToolStripMenuItem,
            this.connectAdbToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(424, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // loadModToolStripMenuItem
            // 
            this.loadModToolStripMenuItem.Name = "loadModToolStripMenuItem";
            this.loadModToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.loadModToolStripMenuItem.Text = "Load Mod";
            this.loadModToolStripMenuItem.Click += new System.EventHandler(this.loadModToolStripMenuItem_Click);
            // 
            // packModToolStripMenuItem
            // 
            this.packModToolStripMenuItem.Name = "packModToolStripMenuItem";
            this.packModToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.packModToolStripMenuItem.Text = "Pack Mod";
            this.packModToolStripMenuItem.Click += new System.EventHandler(this.packModToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.howToUseToolStripMenuItem.Text = "How to use";
            // 
            // connectAdbToolStripMenuItem1
            // 
            this.connectAdbToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalPhoneToolStripMenuItem,
            this.emulatorToolStripMenuItem});
            this.connectAdbToolStripMenuItem1.Name = "connectAdbToolStripMenuItem1";
            this.connectAdbToolStripMenuItem1.Size = new System.Drawing.Size(128, 20);
            this.connectAdbToolStripMenuItem1.Text = "Connect your device";
            // 
            // normalPhoneToolStripMenuItem
            // 
            this.normalPhoneToolStripMenuItem.Name = "normalPhoneToolStripMenuItem";
            this.normalPhoneToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.normalPhoneToolStripMenuItem.Text = "Normal phone";
            // 
            // emulatorToolStripMenuItem
            // 
            this.emulatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noxToolStripMenuItem,
            this.bluestacksToolStripMenuItem});
            this.emulatorToolStripMenuItem.Name = "emulatorToolStripMenuItem";
            this.emulatorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.emulatorToolStripMenuItem.Text = "Emulator";
            // 
            // noxToolStripMenuItem
            // 
            this.noxToolStripMenuItem.Name = "noxToolStripMenuItem";
            this.noxToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.noxToolStripMenuItem.Text = "Nox";
            // 
            // bluestacksToolStripMenuItem
            // 
            this.bluestacksToolStripMenuItem.Name = "bluestacksToolStripMenuItem";
            this.bluestacksToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.bluestacksToolStripMenuItem.Text = "Bluestacks";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.welcomeLabel.Location = new System.Drawing.Point(12, 127);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(351, 34);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome to Foilomancer! \r\nPlease check out the \'How to use\' menu to get started.";
            this.welcomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 314);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "FoilomancerGUI";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem loadModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ToolStripMenuItem connectAdbToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem normalPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emulatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bluestacksToolStripMenuItem;
    }
}

