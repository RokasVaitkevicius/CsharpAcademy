namespace ComputerMetricsWinForms
{
    partial class ComputerMetricsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ComputerNameBox = new System.Windows.Forms.TextBox();
            this.ComputerNameLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.CpuBox = new System.Windows.Forms.TextBox();
            this.CpuLabel = new System.Windows.Forms.Label();
            this.CpuUsageLabel = new System.Windows.Forms.Label();
            this.RamBox = new System.Windows.Forms.TextBox();
            this.RamUsageBox = new System.Windows.Forms.TextBox();
            this.VideoCardBox = new System.Windows.Forms.TextBox();
            this.RamLabel = new System.Windows.Forms.Label();
            this.RamUsageLabel = new System.Windows.Forms.Label();
            this.VideoCardLabel = new System.Windows.Forms.Label();
            this.AvailableDiskSpaceLabel = new System.Windows.Forms.Label();
            this.IpLabel = new System.Windows.Forms.Label();
            this.IpBox = new System.Windows.Forms.TextBox();
            this.AvailableDiskSpaceGBBox = new System.Windows.Forms.TextBox();
            this.AvarageDiskQueueLengthLabel = new System.Windows.Forms.Label();
            this.AverageDiskQueueLengthBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.CpuUsageBox = new System.Windows.Forms.TextBox();
            this.UsageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton = new System.Windows.Forms.Button();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.SummaryTab = new System.Windows.Forms.TabPage();
            this.GraphTab = new System.Windows.Forms.TabPage();
            this.StopButton = new System.Windows.Forms.Button();
            this.ProgramStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsageChart)).BeginInit();
            this.MainTab.SuspendLayout();
            this.SummaryTab.SuspendLayout();
            this.GraphTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComputerNameBox
            // 
            this.ComputerNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ComputerNameBox.Location = new System.Drawing.Point(23, 19);
            this.ComputerNameBox.Name = "ComputerNameBox";
            this.ComputerNameBox.Size = new System.Drawing.Size(317, 20);
            this.ComputerNameBox.TabIndex = 1;
            // 
            // ComputerNameLabel
            // 
            this.ComputerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ComputerNameLabel.AutoSize = true;
            this.ComputerNameLabel.Location = new System.Drawing.Point(20, 3);
            this.ComputerNameLabel.Name = "ComputerNameLabel";
            this.ComputerNameLabel.Size = new System.Drawing.Size(83, 13);
            this.ComputerNameLabel.TabIndex = 2;
            this.ComputerNameLabel.Text = "Computer Name";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(20, 42);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(57, 13);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "UserName";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserNameBox.Location = new System.Drawing.Point(23, 58);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(317, 20);
            this.UserNameBox.TabIndex = 4;
            // 
            // CpuBox
            // 
            this.CpuBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CpuBox.Location = new System.Drawing.Point(23, 97);
            this.CpuBox.Name = "CpuBox";
            this.CpuBox.Size = new System.Drawing.Size(317, 20);
            this.CpuBox.TabIndex = 5;
            // 
            // CpuLabel
            // 
            this.CpuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CpuLabel.AutoSize = true;
            this.CpuLabel.Location = new System.Drawing.Point(20, 81);
            this.CpuLabel.Name = "CpuLabel";
            this.CpuLabel.Size = new System.Drawing.Size(29, 13);
            this.CpuLabel.TabIndex = 6;
            this.CpuLabel.Text = "CPU";
            // 
            // CpuUsageLabel
            // 
            this.CpuUsageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CpuUsageLabel.AutoSize = true;
            this.CpuUsageLabel.Location = new System.Drawing.Point(20, 120);
            this.CpuUsageLabel.Name = "CpuUsageLabel";
            this.CpuUsageLabel.Size = new System.Drawing.Size(61, 13);
            this.CpuUsageLabel.TabIndex = 7;
            this.CpuUsageLabel.Text = "CPU usage";
            // 
            // RamBox
            // 
            this.RamBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RamBox.Location = new System.Drawing.Point(23, 175);
            this.RamBox.Name = "RamBox";
            this.RamBox.Size = new System.Drawing.Size(317, 20);
            this.RamBox.TabIndex = 9;
            // 
            // RamUsageBox
            // 
            this.RamUsageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RamUsageBox.Location = new System.Drawing.Point(23, 214);
            this.RamUsageBox.Name = "RamUsageBox";
            this.RamUsageBox.Size = new System.Drawing.Size(317, 20);
            this.RamUsageBox.TabIndex = 10;
            // 
            // VideoCardBox
            // 
            this.VideoCardBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VideoCardBox.Location = new System.Drawing.Point(23, 253);
            this.VideoCardBox.Name = "VideoCardBox";
            this.VideoCardBox.Size = new System.Drawing.Size(317, 20);
            this.VideoCardBox.TabIndex = 11;
            // 
            // RamLabel
            // 
            this.RamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RamLabel.AutoSize = true;
            this.RamLabel.Location = new System.Drawing.Point(20, 159);
            this.RamLabel.Name = "RamLabel";
            this.RamLabel.Size = new System.Drawing.Size(29, 13);
            this.RamLabel.TabIndex = 12;
            this.RamLabel.Text = "Ram";
            // 
            // RamUsageLabel
            // 
            this.RamUsageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RamUsageLabel.AutoSize = true;
            this.RamUsageLabel.Location = new System.Drawing.Point(20, 198);
            this.RamUsageLabel.Name = "RamUsageLabel";
            this.RamUsageLabel.Size = new System.Drawing.Size(61, 13);
            this.RamUsageLabel.TabIndex = 13;
            this.RamUsageLabel.Text = "Ram usage";
            // 
            // VideoCardLabel
            // 
            this.VideoCardLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VideoCardLabel.AutoSize = true;
            this.VideoCardLabel.Location = new System.Drawing.Point(20, 237);
            this.VideoCardLabel.Name = "VideoCardLabel";
            this.VideoCardLabel.Size = new System.Drawing.Size(58, 13);
            this.VideoCardLabel.TabIndex = 14;
            this.VideoCardLabel.Text = "Video card";
            // 
            // AvailableDiskSpaceLabel
            // 
            this.AvailableDiskSpaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AvailableDiskSpaceLabel.AutoSize = true;
            this.AvailableDiskSpaceLabel.Location = new System.Drawing.Point(20, 276);
            this.AvailableDiskSpaceLabel.Name = "AvailableDiskSpaceLabel";
            this.AvailableDiskSpaceLabel.Size = new System.Drawing.Size(122, 13);
            this.AvailableDiskSpaceLabel.TabIndex = 15;
            this.AvailableDiskSpaceLabel.Text = "Available disk space GB";
            // 
            // IpLabel
            // 
            this.IpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(20, 315);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(16, 13);
            this.IpLabel.TabIndex = 16;
            this.IpLabel.Text = "Ip";
            // 
            // IpBox
            // 
            this.IpBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IpBox.Location = new System.Drawing.Point(23, 331);
            this.IpBox.Name = "IpBox";
            this.IpBox.Size = new System.Drawing.Size(317, 20);
            this.IpBox.TabIndex = 17;
            // 
            // AvailableDiskSpaceGBBox
            // 
            this.AvailableDiskSpaceGBBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AvailableDiskSpaceGBBox.Location = new System.Drawing.Point(23, 292);
            this.AvailableDiskSpaceGBBox.Name = "AvailableDiskSpaceGBBox";
            this.AvailableDiskSpaceGBBox.Size = new System.Drawing.Size(317, 20);
            this.AvailableDiskSpaceGBBox.TabIndex = 18;
            // 
            // AvarageDiskQueueLengthLabel
            // 
            this.AvarageDiskQueueLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AvarageDiskQueueLengthLabel.AutoSize = true;
            this.AvarageDiskQueueLengthLabel.Location = new System.Drawing.Point(20, 354);
            this.AvarageDiskQueueLengthLabel.Name = "AvarageDiskQueueLengthLabel";
            this.AvarageDiskQueueLengthLabel.Size = new System.Drawing.Size(134, 13);
            this.AvarageDiskQueueLengthLabel.TabIndex = 20;
            this.AvarageDiskQueueLengthLabel.Text = "Average disk queue length";
            // 
            // AverageDiskQueueLengthBox
            // 
            this.AverageDiskQueueLengthBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AverageDiskQueueLengthBox.Location = new System.Drawing.Point(23, 370);
            this.AverageDiskQueueLengthBox.Name = "AverageDiskQueueLengthBox";
            this.AverageDiskQueueLengthBox.Size = new System.Drawing.Size(317, 20);
            this.AverageDiskQueueLengthBox.TabIndex = 21;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CpuUsageBox
            // 
            this.CpuUsageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CpuUsageBox.Location = new System.Drawing.Point(23, 136);
            this.CpuUsageBox.Name = "CpuUsageBox";
            this.CpuUsageBox.Size = new System.Drawing.Size(317, 20);
            this.CpuUsageBox.TabIndex = 22;
            // 
            // UsageChart
            // 
            this.UsageChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.UsageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.UsageChart.Legends.Add(legend1);
            this.UsageChart.Location = new System.Drawing.Point(0, 6);
            this.UsageChart.Name = "UsageChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.UsageChart.Series.Add(series1);
            this.UsageChart.Size = new System.Drawing.Size(938, 381);
            this.UsageChart.TabIndex = 23;
            this.UsageChart.Text = "chart1";
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.StartButton.Location = new System.Drawing.Point(16, 451);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(116, 50);
            this.StartButton.TabIndex = 24;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTab.Controls.Add(this.SummaryTab);
            this.MainTab.Controls.Add(this.GraphTab);
            this.MainTab.Location = new System.Drawing.Point(12, 12);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(952, 433);
            this.MainTab.TabIndex = 25;
            // 
            // SummaryTab
            // 
            this.SummaryTab.Controls.Add(this.ComputerNameBox);
            this.SummaryTab.Controls.Add(this.ComputerNameLabel);
            this.SummaryTab.Controls.Add(this.UserNameLabel);
            this.SummaryTab.Controls.Add(this.CpuUsageBox);
            this.SummaryTab.Controls.Add(this.UserNameBox);
            this.SummaryTab.Controls.Add(this.AverageDiskQueueLengthBox);
            this.SummaryTab.Controls.Add(this.CpuBox);
            this.SummaryTab.Controls.Add(this.AvarageDiskQueueLengthLabel);
            this.SummaryTab.Controls.Add(this.CpuLabel);
            this.SummaryTab.Controls.Add(this.AvailableDiskSpaceGBBox);
            this.SummaryTab.Controls.Add(this.CpuUsageLabel);
            this.SummaryTab.Controls.Add(this.IpBox);
            this.SummaryTab.Controls.Add(this.RamBox);
            this.SummaryTab.Controls.Add(this.IpLabel);
            this.SummaryTab.Controls.Add(this.RamUsageBox);
            this.SummaryTab.Controls.Add(this.AvailableDiskSpaceLabel);
            this.SummaryTab.Controls.Add(this.VideoCardBox);
            this.SummaryTab.Controls.Add(this.VideoCardLabel);
            this.SummaryTab.Controls.Add(this.RamLabel);
            this.SummaryTab.Controls.Add(this.RamUsageLabel);
            this.SummaryTab.Location = new System.Drawing.Point(4, 22);
            this.SummaryTab.Name = "SummaryTab";
            this.SummaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.SummaryTab.Size = new System.Drawing.Size(944, 407);
            this.SummaryTab.TabIndex = 0;
            this.SummaryTab.Text = "Summary";
            this.SummaryTab.UseVisualStyleBackColor = true;
            // 
            // GraphTab
            // 
            this.GraphTab.Controls.Add(this.UsageChart);
            this.GraphTab.Location = new System.Drawing.Point(4, 22);
            this.GraphTab.Name = "GraphTab";
            this.GraphTab.Padding = new System.Windows.Forms.Padding(3);
            this.GraphTab.Size = new System.Drawing.Size(944, 407);
            this.GraphTab.TabIndex = 1;
            this.GraphTab.Text = "Graph";
            this.GraphTab.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.StopButton.Location = new System.Drawing.Point(138, 451);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(112, 50);
            this.StopButton.TabIndex = 26;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ProgramStatusLabel
            // 
            this.ProgramStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramStatusLabel.AutoSize = true;
            this.ProgramStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramStatusLabel.Location = new System.Drawing.Point(688, 463);
            this.ProgramStatusLabel.Name = "ProgramStatusLabel";
            this.ProgramStatusLabel.Size = new System.Drawing.Size(272, 25);
            this.ProgramStatusLabel.TabIndex = 23;
            this.ProgramStatusLabel.Text = "Program status: Stopped";
            // 
            // ComputerMetricsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 513);
            this.Controls.Add(this.ProgramStatusLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.MainTab);
            this.Controls.Add(this.StartButton);
            this.Name = "ComputerMetricsForm";
            this.Text = "Computer metrics";
            this.Load += new System.EventHandler(this.ComputerMetricsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsageChart)).EndInit();
            this.MainTab.ResumeLayout(false);
            this.SummaryTab.ResumeLayout(false);
            this.SummaryTab.PerformLayout();
            this.GraphTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ComputerNameBox;
        private System.Windows.Forms.Label ComputerNameLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox CpuBox;
        private System.Windows.Forms.Label CpuLabel;
        private System.Windows.Forms.Label CpuUsageLabel;
        private System.Windows.Forms.TextBox RamBox;
        private System.Windows.Forms.TextBox RamUsageBox;
        private System.Windows.Forms.TextBox VideoCardBox;
        private System.Windows.Forms.Label RamLabel;
        private System.Windows.Forms.Label RamUsageLabel;
        private System.Windows.Forms.Label VideoCardLabel;
        private System.Windows.Forms.Label AvailableDiskSpaceLabel;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.TextBox IpBox;
        private System.Windows.Forms.TextBox AvailableDiskSpaceGBBox;
        private System.Windows.Forms.Label AvarageDiskQueueLengthLabel;
        private System.Windows.Forms.TextBox AverageDiskQueueLengthBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox CpuUsageBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart UsageChart;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage SummaryTab;
        private System.Windows.Forms.TabPage GraphTab;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label ProgramStatusLabel;
    }
}

