namespace HotClicker
{
    partial class Form1
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
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblDelayBetweenClicks = new System.Windows.Forms.Label();
            this.txtDelayBetweenClicks = new System.Windows.Forms.TextBox();
            this.tmrClicker = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddMouseL = new System.Windows.Forms.Button();
            this.btnAddMouseR = new System.Windows.Forms.Button();
            this.lblMousePosition = new System.Windows.Forms.Label();
            this.tmrMousePosition = new System.Windows.Forms.Timer(this.components);
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(12, 285);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(100, 23);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblDelayBetweenClicks
            // 
            this.lblDelayBetweenClicks.AutoSize = true;
            this.lblDelayBetweenClicks.Location = new System.Drawing.Point(10, 10);
            this.lblDelayBetweenClicks.Name = "lblDelayBetweenClicks";
            this.lblDelayBetweenClicks.Size = new System.Drawing.Size(59, 13);
            this.lblDelayBetweenClicks.TabIndex = 1;
            this.lblDelayBetweenClicks.Text = "Delay (MS)";
            // 
            // txtDelayBetweenClicks
            // 
            this.txtDelayBetweenClicks.Location = new System.Drawing.Point(94, 10);
            this.txtDelayBetweenClicks.Name = "txtDelayBetweenClicks";
            this.txtDelayBetweenClicks.Size = new System.Drawing.Size(180, 20);
            this.txtDelayBetweenClicks.TabIndex = 2;
            // 
            // tmrClicker
            // 
            this.tmrClicker.Tick += new System.EventHandler(this.tmrClicker_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(289, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstCommands
            // 
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.Location = new System.Drawing.Point(13, 96);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(375, 160);
            this.lstCommands.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(94, 39);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(180, 20);
            this.txtAdd.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(13, 66);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddMouseL
            // 
            this.btnAddMouseL.Location = new System.Drawing.Point(100, 65);
            this.btnAddMouseL.Name = "btnAddMouseL";
            this.btnAddMouseL.Size = new System.Drawing.Size(84, 23);
            this.btnAddMouseL.TabIndex = 11;
            this.btnAddMouseL.Text = "Add Mouse L";
            this.btnAddMouseL.UseVisualStyleBackColor = true;
            this.btnAddMouseL.Click += new System.EventHandler(this.btnAddMouseL_Click);
            // 
            // btnAddMouseR
            // 
            this.btnAddMouseR.Location = new System.Drawing.Point(190, 66);
            this.btnAddMouseR.Name = "btnAddMouseR";
            this.btnAddMouseR.Size = new System.Drawing.Size(84, 23);
            this.btnAddMouseR.TabIndex = 12;
            this.btnAddMouseR.Text = "Add Mouse R";
            this.btnAddMouseR.UseVisualStyleBackColor = true;
            this.btnAddMouseR.Click += new System.EventHandler(this.btnAddMouseR_Click);
            // 
            // lblMousePosition
            // 
            this.lblMousePosition.AutoSize = true;
            this.lblMousePosition.Location = new System.Drawing.Point(13, 266);
            this.lblMousePosition.Name = "lblMousePosition";
            this.lblMousePosition.Size = new System.Drawing.Size(35, 13);
            this.lblMousePosition.TabIndex = 13;
            this.lblMousePosition.Text = "label1";
            // 
            // tmrMousePosition
            // 
            this.tmrMousePosition.Interval = 20;
            this.tmrMousePosition.Tick += new System.EventHandler(this.tmrMousePosition_Tick);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(335, 5);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(53, 20);
            this.txtX.TabIndex = 14;
            this.txtX.Text = "txtX";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(335, 30);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(53, 20);
            this.txtY.TabIndex = 15;
            this.txtY.Text = "txtY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mouse X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mouse Y";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 314);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(377, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Location = new System.Drawing.Point(118, 285);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(24, 13);
            this.lblTimeRemaining.TabIndex = 19;
            this.lblTimeRemaining.Text = "0\\0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 351);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblMousePosition);
            this.Controls.Add(this.btnAddMouseR);
            this.Controls.Add(this.btnAddMouseL);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCommands);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDelayBetweenClicks);
            this.Controls.Add(this.lblDelayBetweenClicks);
            this.Controls.Add(this.btnStartStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hotket Clicker - By Haxorico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblDelayBetweenClicks;
        private System.Windows.Forms.TextBox txtDelayBetweenClicks;
        private System.Windows.Forms.Timer tmrClicker;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstCommands;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddMouseL;
        private System.Windows.Forms.Button btnAddMouseR;
        private System.Windows.Forms.Label lblMousePosition;
        private System.Windows.Forms.Timer tmrMousePosition;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTimeRemaining;
    }
}

