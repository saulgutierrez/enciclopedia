namespace enciclopedia
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.supportButton = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonGeography = new System.Windows.Forms.Button();
            this.buttonPeople = new System.Windows.Forms.Button();
            this.buttonArts = new System.Windows.Forms.Button();
            this.buttonPolitics = new System.Windows.Forms.Button();
            this.buttonScience = new System.Windows.Forms.Button();
            this.buttonTech = new System.Windows.Forms.Button();
            this.buttonReligion = new System.Windows.Forms.Button();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PlaceholderText = "Type here";
            this.searchTextBox.Size = new System.Drawing.Size(636, 29);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoríes";
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(654, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 30);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutButton.Image")));
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(526, 418);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(120, 31);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(400, 418);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(120, 31);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(274, 418);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(120, 31);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // supportButton
            // 
            this.supportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.supportButton.Image = ((System.Drawing.Image)(resources.GetObject("supportButton.Image")));
            this.supportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supportButton.Location = new System.Drawing.Point(652, 418);
            this.supportButton.Name = "supportButton";
            this.supportButton.Size = new System.Drawing.Size(120, 31);
            this.supportButton.TabIndex = 8;
            this.supportButton.Text = "Support Us";
            this.supportButton.UseVisualStyleBackColor = true;
            this.supportButton.Click += new System.EventHandler(this.supportButton_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonHistory.Image")));
            this.buttonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistory.Location = new System.Drawing.Point(12, 68);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(189, 60);
            this.buttonHistory.TabIndex = 9;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonGeography
            // 
            this.buttonGeography.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeography.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGeography.Image = ((System.Drawing.Image)(resources.GetObject("buttonGeography.Image")));
            this.buttonGeography.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGeography.Location = new System.Drawing.Point(12, 144);
            this.buttonGeography.Name = "buttonGeography";
            this.buttonGeography.Size = new System.Drawing.Size(189, 60);
            this.buttonGeography.TabIndex = 10;
            this.buttonGeography.Text = "Geography";
            this.buttonGeography.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGeography.UseVisualStyleBackColor = true;
            this.buttonGeography.Click += new System.EventHandler(this.buttonGeography_Click);
            // 
            // buttonPeople
            // 
            this.buttonPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPeople.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPeople.Image = ((System.Drawing.Image)(resources.GetObject("buttonPeople.Image")));
            this.buttonPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPeople.Location = new System.Drawing.Point(12, 232);
            this.buttonPeople.Name = "buttonPeople";
            this.buttonPeople.Size = new System.Drawing.Size(189, 60);
            this.buttonPeople.TabIndex = 11;
            this.buttonPeople.Text = "Society";
            this.buttonPeople.UseVisualStyleBackColor = true;
            this.buttonPeople.Click += new System.EventHandler(this.buttonPeople_Click);
            // 
            // buttonArts
            // 
            this.buttonArts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArts.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonArts.Image = ((System.Drawing.Image)(resources.GetObject("buttonArts.Image")));
            this.buttonArts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonArts.Location = new System.Drawing.Point(583, 68);
            this.buttonArts.Name = "buttonArts";
            this.buttonArts.Size = new System.Drawing.Size(189, 60);
            this.buttonArts.TabIndex = 12;
            this.buttonArts.Text = "Arts";
            this.buttonArts.UseVisualStyleBackColor = true;
            this.buttonArts.Click += new System.EventHandler(this.buttonArts_Click);
            // 
            // buttonPolitics
            // 
            this.buttonPolitics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPolitics.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPolitics.Image = ((System.Drawing.Image)(resources.GetObject("buttonPolitics.Image")));
            this.buttonPolitics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPolitics.Location = new System.Drawing.Point(583, 144);
            this.buttonPolitics.Name = "buttonPolitics";
            this.buttonPolitics.Size = new System.Drawing.Size(189, 60);
            this.buttonPolitics.TabIndex = 13;
            this.buttonPolitics.Text = "Politics";
            this.buttonPolitics.UseVisualStyleBackColor = true;
            this.buttonPolitics.Click += new System.EventHandler(this.buttonPolitics_Click);
            // 
            // buttonScience
            // 
            this.buttonScience.BackColor = System.Drawing.SystemColors.Control;
            this.buttonScience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScience.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonScience.Image = ((System.Drawing.Image)(resources.GetObject("buttonScience.Image")));
            this.buttonScience.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonScience.Location = new System.Drawing.Point(583, 232);
            this.buttonScience.Name = "buttonScience";
            this.buttonScience.Size = new System.Drawing.Size(189, 60);
            this.buttonScience.TabIndex = 14;
            this.buttonScience.Text = "Science";
            this.buttonScience.UseVisualStyleBackColor = false;
            this.buttonScience.Click += new System.EventHandler(this.buttonScience_Click);
            // 
            // buttonTech
            // 
            this.buttonTech.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTech.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTech.Image = ((System.Drawing.Image)(resources.GetObject("buttonTech.Image")));
            this.buttonTech.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTech.Location = new System.Drawing.Point(12, 322);
            this.buttonTech.Name = "buttonTech";
            this.buttonTech.Size = new System.Drawing.Size(189, 60);
            this.buttonTech.TabIndex = 15;
            this.buttonTech.Text = "Tech";
            this.buttonTech.UseVisualStyleBackColor = false;
            this.buttonTech.Click += new System.EventHandler(this.buttonTech_Click);
            // 
            // buttonReligion
            // 
            this.buttonReligion.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReligion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReligion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReligion.Image = ((System.Drawing.Image)(resources.GetObject("buttonReligion.Image")));
            this.buttonReligion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReligion.Location = new System.Drawing.Point(583, 322);
            this.buttonReligion.Name = "buttonReligion";
            this.buttonReligion.Size = new System.Drawing.Size(189, 60);
            this.buttonReligion.TabIndex = 16;
            this.buttonReligion.Text = "Religion";
            this.buttonReligion.UseVisualStyleBackColor = false;
            this.buttonReligion.Click += new System.EventHandler(this.buttonReligion_Click);
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.AllowUserToResizeColumns = false;
            this.dataGridViewInfo.AllowUserToResizeRows = false;
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInfo.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewInfo.Location = new System.Drawing.Point(207, 68);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.RowHeadersVisible = false;
            this.dataGridViewInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewInfo.RowTemplate.Height = 25;
            this.dataGridViewInfo.Size = new System.Drawing.Size(370, 314);
            this.dataGridViewInfo.TabIndex = 17;
            // 
            // Main
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.buttonReligion);
            this.Controls.Add(this.buttonTech);
            this.Controls.Add(this.buttonScience);
            this.Controls.Add(this.buttonPolitics);
            this.Controls.Add(this.buttonArts);
            this.Controls.Add(this.buttonPeople);
            this.Controls.Add(this.buttonGeography);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.supportButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Academy Hub";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchTextBox;
        private Label label1;
        private Button searchButton;
        private Button aboutButton;
        private Button settingsButton;
        private Button helpButton;
        private Button supportButton;
        private Button buttonHistory;
        private Button buttonGeography;
        private Button buttonPeople;
        private Button buttonArts;
        private Button buttonPolitics;
        private Button buttonScience;
        private Button buttonTech;
        private Button buttonReligion;
        private DataGridView dataGridViewInfo;
    }
}