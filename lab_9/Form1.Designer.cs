namespace lab_9
{
    partial class Room
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
            this.InfoRoom = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.windows = new System.Windows.Forms.Label();
            this.windowsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.defaultRoomButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoRoom
            // 
            this.InfoRoom.AutoSize = true;
            this.InfoRoom.Location = new System.Drawing.Point(29, 19);
            this.InfoRoom.Name = "InfoRoom";
            this.InfoRoom.Size = new System.Drawing.Size(160, 16);
            this.InfoRoom.TabIndex = 0;
            this.InfoRoom.Text = "Інформація про кімнату";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(12, 62);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(74, 16);
            this.Area.TabIndex = 1;
            this.Area.Text = "Площа (м²)";
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(101, 56);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(139, 22);
            this.AreaTextBox.TabIndex = 2;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(12, 95);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(74, 16);
            this.Height.TabIndex = 3;
            this.Height.Text = "Висота (м)";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(101, 89);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(139, 22);
            this.HeightTextBox.TabIndex = 4;
            // 
            // windows
            // 
            this.windows.AutoSize = true;
            this.windows.Location = new System.Drawing.Point(12, 127);
            this.windows.Name = "windows";
            this.windows.Size = new System.Drawing.Size(77, 16);
            this.windows.TabIndex = 5;
            this.windows.Text = "К-сть вікон";
            // 
            // windowsTextBox
            // 
            this.windowsTextBox.Location = new System.Drawing.Point(101, 124);
            this.windowsTextBox.Name = "windowsTextBox";
            this.windowsTextBox.Size = new System.Drawing.Size(139, 22);
            this.windowsTextBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(12, 195);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(119, 42);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Обчислити";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // defaultRoomButton
            // 
            this.defaultRoomButton.BackColor = System.Drawing.Color.Blue;
            this.defaultRoomButton.ForeColor = System.Drawing.Color.White;
            this.defaultRoomButton.Location = new System.Drawing.Point(12, 243);
            this.defaultRoomButton.Name = "defaultRoomButton";
            this.defaultRoomButton.Size = new System.Drawing.Size(163, 48);
            this.defaultRoomButton.TabIndex = 8;
            this.defaultRoomButton.Text = "Створити кімнату";
            this.defaultRoomButton.UseVisualStyleBackColor = false;
            this.defaultRoomButton.Click += new System.EventHandler(this.defaultRoomButton_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.defaultRoomButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.windowsTextBox);
            this.Controls.Add(this.windows);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.InfoRoom);
            this.Name = "Room";
            this.Text = "Кімната";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoRoom;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label windows;
        private System.Windows.Forms.TextBox windowsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button defaultRoomButton;
    }
}

