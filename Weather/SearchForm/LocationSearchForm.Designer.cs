namespace Weather.SearchForm
{
    partial class LocationSearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTextBox = new MetroSuite.MetroTextbox();
            this.SearchButton = new MetroSuite.MetroButton();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.SearchStatus = new MetroSuite.MetroLabel();
            this.metroLabel3 = new MetroSuite.MetroLabel();
            this.AddressLabel = new MetroSuite.MetroLabel();
            this.metroLabel5 = new MetroSuite.MetroLabel();
            this.LocationLabel = new MetroSuite.MetroLabel();
            this.ApplyButton = new MetroSuite.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "주소 입력";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddressTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.AddressTextBox.DefaultColor = System.Drawing.Color.White;
            this.AddressTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AddressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddressTextBox.HideSelection = false;
            this.AddressTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.AddressTextBox.Location = new System.Drawing.Point(13, 97);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.PasswordChar = '\0';
            this.AddressTextBox.Size = new System.Drawing.Size(370, 32);
            this.AddressTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.SearchButton.DefaultColor = System.Drawing.Color.White;
            this.SearchButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SearchButton.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SearchButton.Location = new System.Drawing.Point(389, 97);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SearchButton.Size = new System.Drawing.Size(87, 32);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "검색";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel1.Location = new System.Drawing.Point(13, 132);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 21);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "검색 결과 :";
            // 
            // SearchStatus
            // 
            this.SearchStatus.AutoSize = true;
            this.SearchStatus.BackColor = System.Drawing.SystemColors.Window;
            this.SearchStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SearchStatus.Location = new System.Drawing.Point(104, 132);
            this.SearchStatus.Name = "SearchStatus";
            this.SearchStatus.Size = new System.Drawing.Size(14, 21);
            this.SearchStatus.TabIndex = 5;
            this.SearchStatus.Text = " ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel3.Location = new System.Drawing.Point(13, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 21);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "주소 :";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.SystemColors.Window;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddressLabel.Location = new System.Drawing.Point(67, 161);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(14, 21);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = " ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroLabel5.Location = new System.Drawing.Point(13, 190);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 21);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "위치 :";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.BackColor = System.Drawing.SystemColors.Window;
            this.LocationLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LocationLabel.Location = new System.Drawing.Point(67, 190);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(14, 21);
            this.LocationLabel.TabIndex = 9;
            this.LocationLabel.Text = " ";
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ApplyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ApplyButton.DefaultColor = System.Drawing.Color.White;
            this.ApplyButton.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ApplyButton.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ApplyButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ApplyButton.Location = new System.Drawing.Point(482, 97);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ApplyButton.Size = new System.Drawing.Size(87, 32);
            this.ApplyButton.TabIndex = 10;
            this.ApplyButton.Text = "적용";
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // LocationSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 220);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.SearchStatus);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocationSearchForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "주소 검색창";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LocationSearchForm_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroSuite.MetroTextbox AddressTextBox;
        private MetroSuite.MetroButton SearchButton;
        private MetroSuite.MetroLabel metroLabel1;
        private MetroSuite.MetroLabel SearchStatus;
        private MetroSuite.MetroLabel metroLabel3;
        private MetroSuite.MetroLabel AddressLabel;
        private MetroSuite.MetroLabel metroLabel5;
        private MetroSuite.MetroLabel LocationLabel;
        private MetroSuite.MetroButton ApplyButton;
    }
}