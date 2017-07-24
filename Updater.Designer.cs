namespace Updater
{
    partial class Updater
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
            this.timerUpdater = new System.Windows.Forms.Timer(this.components);
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblContactValue = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEstimatedTransFileSizeValue = new System.Windows.Forms.Label();
            this.lblEstimatedHydroFileSizeValue = new System.Windows.Forms.Label();
            this.lblMikeScenarioIDValue = new System.Windows.Forms.Label();
            this.lblEstimatedTransFileSize = new System.Windows.Forms.Label();
            this.lblEstimatedHydroFileSize = new System.Windows.Forms.Label();
            this.lblMikeScenarioID = new System.Windows.Forms.Label();
            this.lblTransFileNameValue = new System.Windows.Forms.Label();
            this.lblHydroFileNameValue = new System.Windows.Forms.Label();
            this.lblCurrentFileValue = new System.Windows.Forms.Label();
            this.lblAppTaskIDValue = new System.Windows.Forms.Label();
            this.lblTransFileName = new System.Windows.Forms.Label();
            this.lblHydroFileName = new System.Windows.Forms.Label();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.lblAppTaskID = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerUpdater
            // 
            this.timerUpdater.Tick += new System.EventHandler(this.timerUpdater_Tick);
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(465, 680);
            this.richTextBoxStatus.TabIndex = 0;
            this.richTextBoxStatus.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblContactValue
            // 
            this.lblContactValue.AutoSize = true;
            this.lblContactValue.Location = new System.Drawing.Point(147, 59);
            this.lblContactValue.Name = "lblContactValue";
            this.lblContactValue.Size = new System.Drawing.Size(42, 13);
            this.lblContactValue.TabIndex = 7;
            this.lblContactValue.Text = "[Empty]";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(75, 57);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "User Name";
            // 
            // lblEstimatedTransFileSizeValue
            // 
            this.lblEstimatedTransFileSizeValue.AutoSize = true;
            this.lblEstimatedTransFileSizeValue.Location = new System.Drawing.Point(147, 179);
            this.lblEstimatedTransFileSizeValue.Name = "lblEstimatedTransFileSizeValue";
            this.lblEstimatedTransFileSizeValue.Size = new System.Drawing.Size(42, 13);
            this.lblEstimatedTransFileSizeValue.TabIndex = 3;
            this.lblEstimatedTransFileSizeValue.Text = "[Empty]";
            // 
            // lblEstimatedHydroFileSizeValue
            // 
            this.lblEstimatedHydroFileSizeValue.AutoSize = true;
            this.lblEstimatedHydroFileSizeValue.Location = new System.Drawing.Point(147, 155);
            this.lblEstimatedHydroFileSizeValue.Name = "lblEstimatedHydroFileSizeValue";
            this.lblEstimatedHydroFileSizeValue.Size = new System.Drawing.Size(42, 13);
            this.lblEstimatedHydroFileSizeValue.TabIndex = 3;
            this.lblEstimatedHydroFileSizeValue.Text = "[Empty]";
            // 
            // lblMikeScenarioIDValue
            // 
            this.lblMikeScenarioIDValue.AutoSize = true;
            this.lblMikeScenarioIDValue.Location = new System.Drawing.Point(147, 35);
            this.lblMikeScenarioIDValue.Name = "lblMikeScenarioIDValue";
            this.lblMikeScenarioIDValue.Size = new System.Drawing.Size(42, 13);
            this.lblMikeScenarioIDValue.TabIndex = 3;
            this.lblMikeScenarioIDValue.Text = "[Empty]";
            // 
            // lblEstimatedTransFileSize
            // 
            this.lblEstimatedTransFileSize.AutoSize = true;
            this.lblEstimatedTransFileSize.Location = new System.Drawing.Point(10, 177);
            this.lblEstimatedTransFileSize.Name = "lblEstimatedTransFileSize";
            this.lblEstimatedTransFileSize.Size = new System.Drawing.Size(125, 13);
            this.lblEstimatedTransFileSize.TabIndex = 2;
            this.lblEstimatedTransFileSize.Text = "Estimated Trans File Size";
            // 
            // lblEstimatedHydroFileSize
            // 
            this.lblEstimatedHydroFileSize.AutoSize = true;
            this.lblEstimatedHydroFileSize.Location = new System.Drawing.Point(9, 153);
            this.lblEstimatedHydroFileSize.Name = "lblEstimatedHydroFileSize";
            this.lblEstimatedHydroFileSize.Size = new System.Drawing.Size(126, 13);
            this.lblEstimatedHydroFileSize.TabIndex = 2;
            this.lblEstimatedHydroFileSize.Text = "Estimated Hydro File Size";
            // 
            // lblMikeScenarioID
            // 
            this.lblMikeScenarioID.AutoSize = true;
            this.lblMikeScenarioID.Location = new System.Drawing.Point(9, 33);
            this.lblMikeScenarioID.Name = "lblMikeScenarioID";
            this.lblMikeScenarioID.Size = new System.Drawing.Size(126, 13);
            this.lblMikeScenarioID.TabIndex = 2;
            this.lblMikeScenarioID.Text = "Mike Scenario TVItem ID";
            // 
            // lblTransFileNameValue
            // 
            this.lblTransFileNameValue.AutoSize = true;
            this.lblTransFileNameValue.Location = new System.Drawing.Point(147, 131);
            this.lblTransFileNameValue.Name = "lblTransFileNameValue";
            this.lblTransFileNameValue.Size = new System.Drawing.Size(42, 13);
            this.lblTransFileNameValue.TabIndex = 1;
            this.lblTransFileNameValue.Text = "[Empty]";
            // 
            // lblHydroFileNameValue
            // 
            this.lblHydroFileNameValue.AutoSize = true;
            this.lblHydroFileNameValue.Location = new System.Drawing.Point(147, 107);
            this.lblHydroFileNameValue.Name = "lblHydroFileNameValue";
            this.lblHydroFileNameValue.Size = new System.Drawing.Size(42, 13);
            this.lblHydroFileNameValue.TabIndex = 1;
            this.lblHydroFileNameValue.Text = "[Empty]";
            // 
            // lblCurrentFileValue
            // 
            this.lblCurrentFileValue.AutoSize = true;
            this.lblCurrentFileValue.Location = new System.Drawing.Point(147, 83);
            this.lblCurrentFileValue.Name = "lblCurrentFileValue";
            this.lblCurrentFileValue.Size = new System.Drawing.Size(42, 13);
            this.lblCurrentFileValue.TabIndex = 1;
            this.lblCurrentFileValue.Text = "[Empty]";
            // 
            // lblAppTaskIDValue
            // 
            this.lblAppTaskIDValue.AutoSize = true;
            this.lblAppTaskIDValue.Location = new System.Drawing.Point(147, 11);
            this.lblAppTaskIDValue.Name = "lblAppTaskIDValue";
            this.lblAppTaskIDValue.Size = new System.Drawing.Size(42, 13);
            this.lblAppTaskIDValue.TabIndex = 1;
            this.lblAppTaskIDValue.Text = "[Empty]";
            // 
            // lblTransFileName
            // 
            this.lblTransFileName.AutoSize = true;
            this.lblTransFileName.Location = new System.Drawing.Point(48, 129);
            this.lblTransFileName.Name = "lblTransFileName";
            this.lblTransFileName.Size = new System.Drawing.Size(87, 13);
            this.lblTransFileName.TabIndex = 0;
            this.lblTransFileName.Text = "Trans File Name:";
            // 
            // lblHydroFileName
            // 
            this.lblHydroFileName.AutoSize = true;
            this.lblHydroFileName.Location = new System.Drawing.Point(47, 105);
            this.lblHydroFileName.Name = "lblHydroFileName";
            this.lblHydroFileName.Size = new System.Drawing.Size(88, 13);
            this.lblHydroFileName.TabIndex = 0;
            this.lblHydroFileName.Text = "Hydro File Name:";
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(33, 81);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(102, 13);
            this.lblCurrentFile.TabIndex = 0;
            this.lblCurrentFile.Text = "M21fm or M3fm File:";
            // 
            // lblAppTaskID
            // 
            this.lblAppTaskID.AutoSize = true;
            this.lblAppTaskID.Location = new System.Drawing.Point(68, 9);
            this.lblAppTaskID.Name = "lblAppTaskID";
            this.lblAppTaskID.Size = new System.Drawing.Size(67, 13);
            this.lblAppTaskID.TabIndex = 0;
            this.lblAppTaskID.Text = "App Task ID";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.lblAppTaskID);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstimatedTransFileSizeValue);
            this.splitContainer1.Panel1.Controls.Add(this.lblContactValue);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstimatedTransFileSize);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstimatedHydroFileSizeValue);
            this.splitContainer1.Panel1.Controls.Add(this.lblAppTaskIDValue);
            this.splitContainer1.Panel1.Controls.Add(this.lblUserName);
            this.splitContainer1.Panel1.Controls.Add(this.lblEstimatedHydroFileSize);
            this.splitContainer1.Panel1.Controls.Add(this.lblMikeScenarioID);
            this.splitContainer1.Panel1.Controls.Add(this.lblTransFileNameValue);
            this.splitContainer1.Panel1.Controls.Add(this.lblMikeScenarioIDValue);
            this.splitContainer1.Panel1.Controls.Add(this.lblHydroFileNameValue);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentFile);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentFileValue);
            this.splitContainer1.Panel1.Controls.Add(this.lblHydroFileName);
            this.splitContainer1.Panel1.Controls.Add(this.lblTransFileName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxStatus);
            this.splitContainer1.Size = new System.Drawing.Size(968, 680);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 2;
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 680);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Updater";
            this.Text = "Mike Scenario Updater";
            this.Load += new System.EventHandler(this.Updater_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerUpdater;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Label lblAppTaskIDValue;
        private System.Windows.Forms.Label lblAppTaskID;
        private System.Windows.Forms.Label lblMikeScenarioIDValue;
        private System.Windows.Forms.Label lblMikeScenarioID;
        private System.Windows.Forms.Label lblEstimatedHydroFileSizeValue;
        private System.Windows.Forms.Label lblEstimatedHydroFileSize;
        private System.Windows.Forms.Label lblEstimatedTransFileSizeValue;
        private System.Windows.Forms.Label lblEstimatedTransFileSize;
        private System.Windows.Forms.Label lblTransFileNameValue;
        private System.Windows.Forms.Label lblHydroFileNameValue;
        private System.Windows.Forms.Label lblCurrentFileValue;
        private System.Windows.Forms.Label lblTransFileName;
        private System.Windows.Forms.Label lblHydroFileName;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.Label lblContactValue;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

