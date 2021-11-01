
namespace Ping
{
    partial class LogConnect
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LogConnectTextBox = new System.Windows.Forms.TextBox();
            this.label_max_ping = new System.Windows.Forms.Label();
            this.label_min_ping = new System.Windows.Forms.Label();
            this.label_time_sessions = new System.Windows.Forms.Label();
            this.label_errors_ping = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogConnectTextBox
            // 
            this.LogConnectTextBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.LogConnectTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogConnectTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LogConnectTextBox.Location = new System.Drawing.Point(6, 14);
            this.LogConnectTextBox.MaxLength = 999999;
            this.LogConnectTextBox.Multiline = true;
            this.LogConnectTextBox.Name = "LogConnectTextBox";
            this.LogConnectTextBox.ReadOnly = true;
            this.LogConnectTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogConnectTextBox.Size = new System.Drawing.Size(530, 281);
            this.LogConnectTextBox.TabIndex = 3;
            this.LogConnectTextBox.TabStop = false;
            // 
            // label_max_ping
            // 
            this.label_max_ping.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_max_ping.BackColor = System.Drawing.Color.Transparent;
            this.label_max_ping.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_max_ping.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_max_ping.Location = new System.Drawing.Point(142, 298);
            this.label_max_ping.Name = "label_max_ping";
            this.label_max_ping.Size = new System.Drawing.Size(108, 20);
            this.label_max_ping.TabIndex = 11;
            this.label_max_ping.Text = "MAX PING:";
            this.label_max_ping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_min_ping
            // 
            this.label_min_ping.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_min_ping.BackColor = System.Drawing.Color.Transparent;
            this.label_min_ping.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_min_ping.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_min_ping.Location = new System.Drawing.Point(12, 298);
            this.label_min_ping.Name = "label_min_ping";
            this.label_min_ping.Size = new System.Drawing.Size(104, 20);
            this.label_min_ping.TabIndex = 12;
            this.label_min_ping.Text = "MIN PING:";
            this.label_min_ping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_min_ping.Click += new System.EventHandler(this.label_min_ping_Click);
            // 
            // label_time_sessions
            // 
            this.label_time_sessions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_time_sessions.BackColor = System.Drawing.Color.Transparent;
            this.label_time_sessions.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time_sessions.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_time_sessions.Location = new System.Drawing.Point(263, 298);
            this.label_time_sessions.Name = "label_time_sessions";
            this.label_time_sessions.Size = new System.Drawing.Size(171, 20);
            this.label_time_sessions.TabIndex = 13;
            this.label_time_sessions.Text = "TIME SESSION:";
            this.label_time_sessions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_errors_ping
            // 
            this.label_errors_ping.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_errors_ping.BackColor = System.Drawing.Color.Transparent;
            this.label_errors_ping.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_errors_ping.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_errors_ping.Location = new System.Drawing.Point(419, 298);
            this.label_errors_ping.Name = "label_errors_ping";
            this.label_errors_ping.Size = new System.Drawing.Size(109, 20);
            this.label_errors_ping.TabIndex = 14;
            this.label_errors_ping.Text = "ERRORS:";
            this.label_errors_ping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 3;
            chartArea17.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chart1.Legends.Add(legend17);
            this.chart1.Location = new System.Drawing.Point(6, 321);
            this.chart1.Name = "chart1";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series1";
            this.chart1.Series.Add(series17);
            this.chart1.Size = new System.Drawing.Size(530, 296);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_time_sessions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LogConnectTextBox);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Controls.Add(this.label_errors_ping);
            this.groupBox1.Controls.Add(this.label_max_ping);
            this.groupBox1.Controls.Add(this.label_min_ping);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(4, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 651);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(392, 623);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "IP:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(550, 651);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogConnect";
            this.Text = "Log Connect";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox LogConnectTextBox;
        public System.Windows.Forms.Label label_max_ping;
        public System.Windows.Forms.Label label_min_ping;
        public System.Windows.Forms.Label label_time_sessions;
        public System.Windows.Forms.Label label_errors_ping;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
    }
}