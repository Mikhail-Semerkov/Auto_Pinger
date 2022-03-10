namespace Ping
{
    partial class AutoPinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoPinger));
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ResponseTextBox = new System.Windows.Forms.TextBox();
            this.PingTimer = new System.Windows.Forms.Timer(this.components);
            this.OnPingRButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_sound = new System.Windows.Forms.CheckBox();
            this.PoVerhOkonCheckBox = new System.Windows.Forms.CheckBox();
            this.OffPingRButton = new System.Windows.Forms.RadioButton();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NewPageButton = new System.Windows.Forms.Button();
            this.Zaderjka_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_ip_adrr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IPTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IPTextBox.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IPTextBox.Location = new System.Drawing.Point(9, 12);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(436, 40);
            this.IPTextBox.TabIndex = 3;
            this.IPTextBox.Text = "192.168.10.10";
            this.IPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.ResponseTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResponseTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ResponseTextBox.Location = new System.Drawing.Point(9, 114);
            this.ResponseTextBox.Multiline = true;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResponseTextBox.Size = new System.Drawing.Size(436, 94);
            this.ResponseTextBox.TabIndex = 2;
            // 
            // PingTimer
            // 
            this.PingTimer.Enabled = true;
            this.PingTimer.Interval = 1000;
            this.PingTimer.Tick += new System.EventHandler(this.PingTimer_Tick);
            // 
            // OnPingRButton
            // 
            this.OnPingRButton.AutoSize = true;
            this.OnPingRButton.BackColor = System.Drawing.Color.Transparent;
            this.OnPingRButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OnPingRButton.Location = new System.Drawing.Point(6, 10);
            this.OnPingRButton.Name = "OnPingRButton";
            this.OnPingRButton.Size = new System.Drawing.Size(74, 17);
            this.OnPingRButton.TabIndex = 4;
            this.OnPingRButton.Text = "Включить";
            this.OnPingRButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_sound);
            this.groupBox1.Controls.Add(this.PoVerhOkonCheckBox);
            this.groupBox1.Controls.Add(this.OffPingRButton);
            this.groupBox1.Controls.Add(this.OnPingRButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(9, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 31);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // checkBox_sound
            // 
            this.checkBox_sound.AutoSize = true;
            this.checkBox_sound.Location = new System.Drawing.Point(380, 11);
            this.checkBox_sound.Name = "checkBox_sound";
            this.checkBox_sound.Size = new System.Drawing.Size(50, 17);
            this.checkBox_sound.TabIndex = 7;
            this.checkBox_sound.Text = "Звук";
            this.checkBox_sound.UseVisualStyleBackColor = true;
            this.checkBox_sound.CheckedChanged += new System.EventHandler(this.checked_sound);
            // 
            // PoVerhOkonCheckBox
            // 
            this.PoVerhOkonCheckBox.AutoSize = true;
            this.PoVerhOkonCheckBox.Location = new System.Drawing.Point(218, 10);
            this.PoVerhOkonCheckBox.Name = "PoVerhOkonCheckBox";
            this.PoVerhOkonCheckBox.Size = new System.Drawing.Size(156, 17);
            this.PoVerhOkonCheckBox.TabIndex = 6;
            this.PoVerhOkonCheckBox.Text = "Отображать по верх окон";
            this.PoVerhOkonCheckBox.UseVisualStyleBackColor = true;
            this.PoVerhOkonCheckBox.CheckedChanged += new System.EventHandler(this.PoVerchOkon_CheckedChanged);
            // 
            // OffPingRButton
            // 
            this.OffPingRButton.AutoSize = true;
            this.OffPingRButton.BackColor = System.Drawing.Color.Transparent;
            this.OffPingRButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OffPingRButton.Location = new System.Drawing.Point(86, 10);
            this.OffPingRButton.Name = "OffPingRButton";
            this.OffPingRButton.Size = new System.Drawing.Size(82, 17);
            this.OffPingRButton.TabIndex = 5;
            this.OffPingRButton.Text = "Выключить";
            this.OffPingRButton.UseVisualStyleBackColor = false;
            this.OffPingRButton.Click += new System.EventHandler(this.RadioButtonClick);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(305, 212);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(140, 25);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "Лог соединения";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NewPageButton
            // 
            this.NewPageButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NewPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPageButton.ForeColor = System.Drawing.Color.Black;
            this.NewPageButton.Location = new System.Drawing.Point(9, 212);
            this.NewPageButton.Name = "NewPageButton";
            this.NewPageButton.Size = new System.Drawing.Size(141, 25);
            this.NewPageButton.TabIndex = 6;
            this.NewPageButton.TabStop = false;
            this.NewPageButton.Text = "Новое окно";
            this.NewPageButton.UseVisualStyleBackColor = false;
            this.NewPageButton.Click += new System.EventHandler(this.NewPageButton_Click);
            // 
            // Zaderjka_label
            // 
            this.Zaderjka_label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Zaderjka_label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zaderjka_label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Zaderjka_label.Location = new System.Drawing.Point(156, 213);
            this.Zaderjka_label.Name = "Zaderjka_label";
            this.Zaderjka_label.Size = new System.Drawing.Size(143, 25);
            this.Zaderjka_label.TabIndex = 7;
            this.Zaderjka_label.Text = "Задержка:";
            this.Zaderjka_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_ip_adrr);
            this.groupBox2.Controls.Add(this.Zaderjka_label);
            this.groupBox2.Controls.Add(this.IPTextBox);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.NewPageButton);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.ResponseTextBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 243);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label_ip_adrr
            // 
            this.label_ip_adrr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_ip_adrr.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ip_adrr.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_ip_adrr.Location = new System.Drawing.Point(9, 56);
            this.label_ip_adrr.Name = "label_ip_adrr";
            this.label_ip_adrr.Size = new System.Drawing.Size(436, 20);
            this.label_ip_adrr.TabIndex = 8;
            this.label_ip_adrr.Text = "IP данной машины";
            this.label_ip_adrr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoPinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(460, 249);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoPinger";
            this.Text = "Auto Pinger 13.09.2021";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Program_FormClosing);
            this.Load += new System.EventHandler(this.Program_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox ResponseTextBox;
        private System.Windows.Forms.Timer PingTimer;
        private System.Windows.Forms.RadioButton OnPingRButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OffPingRButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button NewPageButton;
        private System.Windows.Forms.CheckBox PoVerhOkonCheckBox;
        private System.Windows.Forms.Label Zaderjka_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_ip_adrr;
        private System.Windows.Forms.CheckBox checkBox_sound;
    }
}

