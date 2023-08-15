namespace FoilomancerGUI
{
    partial class packForm
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
            this.packModTitleLabel = new System.Windows.Forms.Label();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.instructions1Label = new System.Windows.Forms.Label();
            this.instructions2label = new System.Windows.Forms.Label();
            this.modNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.modVersionTextBox = new System.Windows.Forms.TextBox();
            this.packModBtn = new System.Windows.Forms.Button();
            this.splitApkName = new System.Windows.Forms.Label();
            this.modNameLabel = new System.Windows.Forms.Label();
            this.modDescriptionLabel = new System.Windows.Forms.Label();
            this.modVersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // packModTitleLabel
            // 
            this.packModTitleLabel.AutoSize = true;
            this.packModTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.packModTitleLabel.Location = new System.Drawing.Point(184, 43);
            this.packModTitleLabel.Name = "packModTitleLabel";
            this.packModTitleLabel.Size = new System.Drawing.Size(156, 31);
            this.packModTitleLabel.TabIndex = 1;
            this.packModTitleLabel.Text = "Pack a mod";
            this.packModTitleLabel.Click += new System.EventHandler(this.packModTitleLabel_Click);
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(201, 128);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(126, 26);
            this.chooseFileBtn.TabIndex = 2;
            this.chooseFileBtn.Text = "Browse..";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // instructions1Label
            // 
            this.instructions1Label.AutoSize = true;
            this.instructions1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.instructions1Label.Location = new System.Drawing.Point(37, 84);
            this.instructions1Label.Name = "instructions1Label";
            this.instructions1Label.Size = new System.Drawing.Size(511, 34);
            this.instructions1Label.TabIndex = 3;
            this.instructions1Label.Text = "First, you need to provide the split APK you edited. \r\n(Make sure it has the orig" +
    "inal name, like \"base.apk\", or else the mod won\'t work)";
            // 
            // instructions2label
            // 
            this.instructions2label.AutoSize = true;
            this.instructions2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.instructions2label.Location = new System.Drawing.Point(131, 172);
            this.instructions2label.Name = "instructions2label";
            this.instructions2label.Size = new System.Drawing.Size(299, 17);
            this.instructions2label.TabIndex = 4;
            this.instructions2label.Text = "Now, fill out some information about your mod.";
            // 
            // modNameTextBox
            // 
            this.modNameTextBox.Location = new System.Drawing.Point(201, 201);
            this.modNameTextBox.Name = "modNameTextBox";
            this.modNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.modNameTextBox.TabIndex = 5;
            this.modNameTextBox.TextChanged += new System.EventHandler(this.modNameTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(104, 246);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(376, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // modVersionTextBox
            // 
            this.modVersionTextBox.Location = new System.Drawing.Point(201, 289);
            this.modVersionTextBox.Name = "modVersionTextBox";
            this.modVersionTextBox.Size = new System.Drawing.Size(139, 20);
            this.modVersionTextBox.TabIndex = 7;
            this.modVersionTextBox.TextChanged += new System.EventHandler(this.modVersionTextBox_TextChanged);
            // 
            // packModBtn
            // 
            this.packModBtn.Location = new System.Drawing.Point(40, 399);
            this.packModBtn.Name = "packModBtn";
            this.packModBtn.Size = new System.Drawing.Size(456, 26);
            this.packModBtn.TabIndex = 8;
            this.packModBtn.Text = "PACK MOD";
            this.packModBtn.UseVisualStyleBackColor = true;
            this.packModBtn.Click += new System.EventHandler(this.packModBtn_Click);
            // 
            // splitApkName
            // 
            this.splitApkName.AutoSize = true;
            this.splitApkName.Location = new System.Drawing.Point(326, 135);
            this.splitApkName.Name = "splitApkName";
            this.splitApkName.Size = new System.Drawing.Size(154, 13);
            this.splitApkName.TabIndex = 10;
            this.splitApkName.Text = "No modified split apk selected..";
            // 
            // modNameLabel
            // 
            this.modNameLabel.AutoSize = true;
            this.modNameLabel.Location = new System.Drawing.Point(135, 204);
            this.modNameLabel.Name = "modNameLabel";
            this.modNameLabel.Size = new System.Drawing.Size(60, 13);
            this.modNameLabel.TabIndex = 11;
            this.modNameLabel.Text = "Mod name:";
            // 
            // modDescriptionLabel
            // 
            this.modDescriptionLabel.AutoSize = true;
            this.modDescriptionLabel.Location = new System.Drawing.Point(13, 253);
            this.modDescriptionLabel.Name = "modDescriptionLabel";
            this.modDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            this.modDescriptionLabel.TabIndex = 12;
            this.modDescriptionLabel.Text = "Mod description:";
            // 
            // modVersionLabel
            // 
            this.modVersionLabel.AutoSize = true;
            this.modVersionLabel.Location = new System.Drawing.Point(110, 292);
            this.modVersionLabel.Name = "modVersionLabel";
            this.modVersionLabel.Size = new System.Drawing.Size(68, 13);
            this.modVersionLabel.TabIndex = 13;
            this.modVersionLabel.Text = "Mod version:";
            // 
            // packForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 432);
            this.Controls.Add(this.modVersionLabel);
            this.Controls.Add(this.modDescriptionLabel);
            this.Controls.Add(this.modNameLabel);
            this.Controls.Add(this.splitApkName);
            this.Controls.Add(this.packModBtn);
            this.Controls.Add(this.modVersionTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.modNameTextBox);
            this.Controls.Add(this.instructions2label);
            this.Controls.Add(this.instructions1Label);
            this.Controls.Add(this.chooseFileBtn);
            this.Controls.Add(this.packModTitleLabel);
            this.Name = "packForm";
            this.Text = "Pack mod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label packModTitleLabel;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.Label instructions1Label;
        private System.Windows.Forms.Label instructions2label;
        private System.Windows.Forms.TextBox modNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox modVersionTextBox;
        private System.Windows.Forms.Button packModBtn;
        private System.Windows.Forms.Label splitApkName;
        private System.Windows.Forms.Label modNameLabel;
        private System.Windows.Forms.Label modDescriptionLabel;
        private System.Windows.Forms.Label modVersionLabel;
    }
}