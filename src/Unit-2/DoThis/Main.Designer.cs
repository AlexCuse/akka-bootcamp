namespace ChartApp
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpu = new System.Windows.Forms.Button();
            this.memory = new System.Windows.Forms.Button();
            this.disk = new System.Windows.Forms.Button();
            this.pauseResume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea2.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea2);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.sysChart.Legends.Add(legend2);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Name = "sysChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.sysChart.Series.Add(series2);
            this.sysChart.Size = new System.Drawing.Size(684, 446);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // cpu
            // 
            this.cpu.Location = new System.Drawing.Point(574, 265);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(98, 23);
            this.cpu.TabIndex = 1;
            this.cpu.Text = "CPU (ON)";
            this.cpu.UseVisualStyleBackColor = true;
            this.cpu.Click += new System.EventHandler(this.cpu_Click);
            // 
            // memory
            // 
            this.memory.Location = new System.Drawing.Point(574, 294);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(98, 23);
            this.memory.TabIndex = 2;
            this.memory.Text = "MEMORY (OFF)";
            this.memory.UseVisualStyleBackColor = true;
            this.memory.Click += new System.EventHandler(this.memory_Click);
            // 
            // disk
            // 
            this.disk.Location = new System.Drawing.Point(574, 323);
            this.disk.Name = "disk";
            this.disk.Size = new System.Drawing.Size(98, 23);
            this.disk.TabIndex = 3;
            this.disk.Text = "DISK (OFF)";
            this.disk.UseVisualStyleBackColor = true;
            this.disk.Click += new System.EventHandler(this.disk_Click);
            // 
            // pauseResume
            // 
            this.pauseResume.Location = new System.Drawing.Point(574, 137);
            this.pauseResume.Name = "pauseResume";
            this.pauseResume.Size = new System.Drawing.Size(98, 23);
            this.pauseResume.TabIndex = 4;
            this.pauseResume.Text = "PAUSE ||";
            this.pauseResume.UseVisualStyleBackColor = true;
            this.pauseResume.Click += new System.EventHandler(this.pauseResume_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 446);
            this.Controls.Add(this.pauseResume);
            this.Controls.Add(this.disk);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.sysChart);
            this.Name = "Main";
            this.Text = "System Metrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button cpu;
        private System.Windows.Forms.Button memory;
        private System.Windows.Forms.Button disk;
        private System.Windows.Forms.Button pauseResume;
    }
}

