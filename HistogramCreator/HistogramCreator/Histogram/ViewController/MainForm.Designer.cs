using ScottPlot;

namespace Histogram
{
    partial class MainForm
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
            this.formsPlotR = new ScottPlot.FormsPlot();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.radioButtonCS = new System.Windows.Forms.RadioButton();
            this.radioButtonAsm = new System.Windows.Forms.RadioButton();
            this.trackBarThreads = new System.Windows.Forms.TrackBar();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.formsPlotG = new ScottPlot.FormsPlot();
            this.formsPlotB = new ScottPlot.FormsPlot();
            this.buttonGenerateTimes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlotR
            // 
            this.formsPlotR.Location = new System.Drawing.Point(525, 20);
            this.formsPlotR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotR.Name = "formsPlotR";
            this.formsPlotR.Size = new System.Drawing.Size(650, 175);
            this.formsPlotR.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(10, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(10, 565);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // radioButtonCS
            // 
            this.radioButtonCS.AutoSize = true;
            this.radioButtonCS.Location = new System.Drawing.Point(170, 540);
            this.radioButtonCS.Name = "radioButtonCS";
            this.radioButtonCS.Size = new System.Drawing.Size(39, 19);
            this.radioButtonCS.TabIndex = 2;
            this.radioButtonCS.TabStop = true;
            this.radioButtonCS.Text = "CS";
            this.radioButtonCS.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsm
            // 
            this.radioButtonAsm.AutoSize = true;
            this.radioButtonAsm.Location = new System.Drawing.Point(170, 565);
            this.radioButtonAsm.Name = "radioButtonAsm";
            this.radioButtonAsm.Size = new System.Drawing.Size(49, 19);
            this.radioButtonAsm.TabIndex = 3;
            this.radioButtonAsm.TabStop = true;
            this.radioButtonAsm.Text = "Asm";
            this.radioButtonAsm.UseVisualStyleBackColor = true;
            this.radioButtonAsm.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // trackBarThreads
            // 
            this.trackBarThreads.LargeChange = 2;
            this.trackBarThreads.Location = new System.Drawing.Point(300, 550);
            this.trackBarThreads.Maximum = 32;
            this.trackBarThreads.Minimum = 1;
            this.trackBarThreads.Name = "trackBarThreads";
            this.trackBarThreads.Size = new System.Drawing.Size(110, 45);
            this.trackBarThreads.TabIndex = 4;
            this.trackBarThreads.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThreads.Value = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(435, 536);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(435, 569);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(41, 15);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "0.0 ms";
            // 
            // formsPlotG
            // 
            this.formsPlotG.Location = new System.Drawing.Point(525, 185);
            this.formsPlotG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotG.Name = "formsPlotG";
            this.formsPlotG.Size = new System.Drawing.Size(650, 175);
            this.formsPlotG.TabIndex = 7;
            // 
            // formsPlotB
            // 
            this.formsPlotB.Location = new System.Drawing.Point(525, 357);
            this.formsPlotB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlotB.Name = "formsPlotB";
            this.formsPlotB.Size = new System.Drawing.Size(650, 175);
            this.formsPlotB.TabIndex = 8;
            // 
            // buttonGenerateTimes
            // 
            this.buttonGenerateTimes.Location = new System.Drawing.Point(10, 536);
            this.buttonGenerateTimes.Name = "buttonGenerateTimes";
            this.buttonGenerateTimes.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateTimes.TabIndex = 9;
            this.buttonGenerateTimes.Text = "Times";
            this.buttonGenerateTimes.UseVisualStyleBackColor = true;
            this.buttonGenerateTimes.Click += new System.EventHandler(this.buttonGenerateTimes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1180, 607);
            this.Controls.Add(this.buttonGenerateTimes);
            this.Controls.Add(this.formsPlotB);
            this.Controls.Add(this.formsPlotG);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.formsPlotR);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.trackBarThreads);
            this.Controls.Add(this.radioButtonAsm);
            this.Controls.Add(this.radioButtonCS);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "HistogramCreator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormsPlot formsPlotR;
        private PictureBox pictureBox;
        private Button buttonLoad;
        private OpenFileDialog openFileDialog;
        private RadioButton radioButtonCS;
        private RadioButton radioButtonAsm;
        private TrackBar trackBarThreads;
        private Button buttonCreate;
        private Label labelTime;
        private FormsPlot formsPlotG;
        private FormsPlot formsPlotB;
        private Button buttonGenerateTimes;
    }
}