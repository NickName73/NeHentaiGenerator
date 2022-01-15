namespace NeHentaiGenerator
{
    partial class neHentaiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.hentaiPictureBox = new System.Windows.Forms.PictureBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.tagBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hentaiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(584, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 20);
            label1.TabIndex = 5;
            label1.Text = "Size X";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(584, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 20);
            label2.TabIndex = 6;
            label2.Text = "Size Y";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(611, 116);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 20);
            label3.TabIndex = 8;
            label3.Text = "Tag";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hentaiPictureBox
            // 
            this.hentaiPictureBox.Location = new System.Drawing.Point(39, 12);
            this.hentaiPictureBox.Name = "hentaiPictureBox";
            this.hentaiPictureBox.Size = new System.Drawing.Size(401, 441);
            this.hentaiPictureBox.TabIndex = 0;
            this.hentaiPictureBox.TabStop = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refreshButton.Location = new System.Drawing.Point(653, 412);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(135, 41);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Regenerate";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyrightLabel.Location = new System.Drawing.Point(626, 9);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(162, 20);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "NickName73 © 2022";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(653, 59);
            this.numX.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(135, 23);
            this.numX.TabIndex = 3;
            this.numX.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(653, 88);
            this.numY.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(135, 23);
            this.numY.TabIndex = 4;
            this.numY.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // tagBox
            // 
            this.tagBox.BackColor = System.Drawing.Color.White;
            this.tagBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagBox.FormattingEnabled = true;
            this.tagBox.Items.AddRange(new object[] {
            "Hentai",
            "Femdom",
            "Feet",
            "Neko",
            "BOObs",
            "Pussy",
            "Cum",
            "Spank",
            "Blowjob",
            "Yuri",
            "Lewd",
            "Lewd Yuri",
            "Lewd Fox",
            "Avatar"});
            this.tagBox.Location = new System.Drawing.Point(653, 117);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(135, 23);
            this.tagBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(576, 412);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(71, 41);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveImage);
            // 
            // neHentaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(label3);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.hentaiPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "neHentaiForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NeHentai Generator";
            ((System.ComponentModel.ISupportInitialize)(this.hentaiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox hentaiPictureBox;
        private Button refreshButton;
        private Label copyrightLabel;
        private NumericUpDown numX;
        private NumericUpDown numY;
        private ComboBox tagBox;
        private Button saveButton;
    }
}