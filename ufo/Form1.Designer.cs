namespace ufo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.startBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Plot1 = new ScottPlot.FormsPlot();
            this.polynom = new System.Windows.Forms.Label();
            this.sleepTime = new System.Windows.Forms.NumericUpDown();
            this.timeLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepTime)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(0, 0);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "start";
            this.startBtn.UseMnemonic = false;
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Plot1
            // 
            this.Plot1.Location = new System.Drawing.Point(0, 48);
            this.Plot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Plot1.Name = "Plot1";
            this.Plot1.Size = new System.Drawing.Size(537, 346);
            this.Plot1.TabIndex = 2;
            this.Plot1.Visible = false;
            // 
            // polynom
            // 
            this.polynom.AutoSize = true;
            this.polynom.Location = new System.Drawing.Point(81, 4);
            this.polynom.Name = "polynom";
            this.polynom.Size = new System.Drawing.Size(91, 15);
            this.polynom.TabIndex = 3;
            this.polynom.Text = "Polynom Power";
            // 
            // sleepTime
            // 
            this.sleepTime.Location = new System.Drawing.Point(0, 29);
            this.sleepTime.Name = "sleepTime";
            this.sleepTime.Size = new System.Drawing.Size(75, 23);
            this.sleepTime.TabIndex = 4;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(81, 31);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(61, 15);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "sleep time";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(231, 379);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(91, 15);
            this.xLabel.TabIndex = 6;
            this.xLabel.Text = "Polynom Power";
            this.xLabel.Visible = false;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(0, 203);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(32, 15);
            this.yLabel.TabIndex = 7;
            this.yLabel.Text = "error";
            this.yLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sleepTime);
            this.Controls.Add(this.polynom);
            this.Controls.Add(this.Plot1);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startBtn;
        private BindingSource bindingSource1;
        private ContextMenuStrip contextMenuStrip1;
        private ScottPlot.FormsPlot Plot1;
        private Label polynom;
        private NumericUpDown sleepTime;
        private Label timeLabel;
        private Label xLabel;
        private Label yLabel;
    }
}