using NeHentaiGenerator.Controls;

namespace NeHentaiGenerator
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.menuScreen = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.downloadButton = new NeHentaiGenerator.Controls.RoundedButton();
            this.nextButton = new NeHentaiGenerator.Controls.RoundedButton();
            this.optionScreen = new System.Windows.Forms.Panel();
            this.imageSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.sidePanel.SuspendLayout();
            this.menuScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(188)))));
            this.sidePanel.Controls.Add(this.backButton);
            this.sidePanel.Controls.Add(this.optionsButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(59, 384);
            this.sidePanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::NeHentaiGenerator.Properties.Resources.previous;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(59, 73);
            this.backButton.TabIndex = 1;
            this.backButton.TabStop = false;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.OptionsClose);
            // 
            // optionsButton
            // 
            this.optionsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.optionsButton.FlatAppearance.BorderSize = 0;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Image = global::NeHentaiGenerator.Properties.Resources.option;
            this.optionsButton.Location = new System.Drawing.Point(0, 325);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(59, 59);
            this.optionsButton.TabIndex = 0;
            this.optionsButton.TabStop = false;
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.OptionsOpen);
            // 
            // menuScreen
            // 
            this.menuScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.menuScreen.Controls.Add(this.picture);
            this.menuScreen.Controls.Add(this.downloadButton);
            this.menuScreen.Controls.Add(this.nextButton);
            this.menuScreen.Location = new System.Drawing.Point(81, 12);
            this.menuScreen.Name = "menuScreen";
            this.menuScreen.Size = new System.Drawing.Size(618, 173);
            this.menuScreen.TabIndex = 1;
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(11, 11);
            this.picture.Margin = new System.Windows.Forms.Padding(0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(604, 159);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(188)))));
            this.downloadButton.EllipseRadius = 5;
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Image = global::NeHentaiGenerator.Properties.Resources.download;
            this.downloadButton.Location = new System.Drawing.Point(491, 111);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.RoundedCorners = true;
            this.downloadButton.Size = new System.Drawing.Size(59, 59);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.DownloadClick);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(67)))), ((int)(((byte)(188)))));
            this.nextButton.EllipseRadius = 5;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Image = global::NeHentaiGenerator.Properties.Resources.next;
            this.nextButton.Location = new System.Drawing.Point(556, 111);
            this.nextButton.Name = "nextButton";
            this.nextButton.RoundedCorners = true;
            this.nextButton.Size = new System.Drawing.Size(59, 59);
            this.nextButton.TabIndex = 0;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.NextClick);
            // 
            // optionScreen
            // 
            this.optionScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.optionScreen.Location = new System.Drawing.Point(81, 191);
            this.optionScreen.Name = "optionScreen";
            this.optionScreen.Size = new System.Drawing.Size(618, 181);
            this.optionScreen.TabIndex = 2;
            // 
            // imageSaveDialog
            // 
            this.imageSaveDialog.Filter = "JPeg Image|*.jpg|PNG Image|*.png|Gif Image|*.gif";
            this.imageSaveDialog.Title = "Save an Image File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 384);
            this.Controls.Add(this.optionScreen);
            this.Controls.Add(this.menuScreen);
            this.Controls.Add(this.sidePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "neHentaiGenerator";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Press);
            this.sidePanel.ResumeLayout(false);
            this.menuScreen.ResumeLayout(false);
            this.AllowTransparency = false;
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidePanel;
        private Button optionsButton;
        private Button backButton;
        private Panel menuScreen;
        private Panel optionScreen;
        private RoundedButton nextButton;
        private RoundedButton downloadButton;
        private SaveFileDialog imageSaveDialog;
        private PictureBox picture;
    }
}