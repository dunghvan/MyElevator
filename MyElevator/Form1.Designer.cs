namespace MyElevator
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
            this.dtgvEle1 = new System.Windows.Forms.DataGridView();
            this.Elevator1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elevator2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elevator3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMainLog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEle1DoorStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEle1CurrentFloor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEle2DoorStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEle2CurrentFloor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEle3DoorStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEle3CurrentFloor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNowIsAt = new System.Windows.Forms.ComboBox();
            this.btCallElevator = new System.Windows.Forms.Button();
            this.gboxInside = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cbGoTo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.gbNowAt = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEle1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gboxInside.SuspendLayout();
            this.gbNowAt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvEle1
            // 
            this.dtgvEle1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgvEle1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEle1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elevator1,
            this.Elevator2,
            this.Elevator3});
            this.dtgvEle1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgvEle1.EnableHeadersVisualStyles = false;
            this.dtgvEle1.Location = new System.Drawing.Point(12, 20);
            this.dtgvEle1.Name = "dtgvEle1";
            this.dtgvEle1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvEle1.RowHeadersVisible = false;
            this.dtgvEle1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgvEle1.Size = new System.Drawing.Size(301, 225);
            this.dtgvEle1.TabIndex = 3;
            this.dtgvEle1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEle1_CellValueChanged);
            // 
            // Elevator1
            // 
            this.Elevator1.HeaderText = "Elevator I";
            this.Elevator1.Name = "Elevator1";
            // 
            // Elevator2
            // 
            this.Elevator2.HeaderText = "Elevator II";
            this.Elevator2.Name = "Elevator2";
            // 
            // Elevator3
            // 
            this.Elevator3.HeaderText = "Elevator III";
            this.Elevator3.Name = "Elevator3";
            // 
            // txtMainLog
            // 
            this.txtMainLog.AcceptsReturn = true;
            this.txtMainLog.AllowDrop = true;
            this.txtMainLog.Location = new System.Drawing.Point(340, 20);
            this.txtMainLog.Multiline = true;
            this.txtMainLog.Name = "txtMainLog";
            this.txtMainLog.ReadOnly = true;
            this.txtMainLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMainLog.Size = new System.Drawing.Size(239, 225);
            this.txtMainLog.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "動作開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "動作停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "初期状態";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEle1DoorStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblEle1CurrentFloor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 43);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblEle1DoorStatus
            // 
            this.lblEle1DoorStatus.AutoSize = true;
            this.lblEle1DoorStatus.Location = new System.Drawing.Point(37, 25);
            this.lblEle1DoorStatus.Name = "lblEle1DoorStatus";
            this.lblEle1DoorStatus.Size = new System.Drawing.Size(0, 12);
            this.lblEle1DoorStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "DR";
            // 
            // lblEle1CurrentFloor
            // 
            this.lblEle1CurrentFloor.AutoSize = true;
            this.lblEle1CurrentFloor.Location = new System.Drawing.Point(35, 9);
            this.lblEle1CurrentFloor.Name = "lblEle1CurrentFloor";
            this.lblEle1CurrentFloor.Size = new System.Drawing.Size(35, 12);
            this.lblEle1CurrentFloor.TabIndex = 1;
            this.lblEle1CurrentFloor.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "NF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEle2DoorStatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblEle2CurrentFloor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(118, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 43);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lblEle2DoorStatus
            // 
            this.lblEle2DoorStatus.AutoSize = true;
            this.lblEle2DoorStatus.Location = new System.Drawing.Point(37, 25);
            this.lblEle2DoorStatus.Name = "lblEle2DoorStatus";
            this.lblEle2DoorStatus.Size = new System.Drawing.Size(0, 12);
            this.lblEle2DoorStatus.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "DR";
            // 
            // lblEle2CurrentFloor
            // 
            this.lblEle2CurrentFloor.AutoSize = true;
            this.lblEle2CurrentFloor.Location = new System.Drawing.Point(35, 9);
            this.lblEle2CurrentFloor.Name = "lblEle2CurrentFloor";
            this.lblEle2CurrentFloor.Size = new System.Drawing.Size(35, 12);
            this.lblEle2CurrentFloor.TabIndex = 1;
            this.lblEle2CurrentFloor.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "NF";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEle3DoorStatus);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblEle3CurrentFloor);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(226, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 43);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // lblEle3DoorStatus
            // 
            this.lblEle3DoorStatus.AutoSize = true;
            this.lblEle3DoorStatus.Location = new System.Drawing.Point(37, 25);
            this.lblEle3DoorStatus.Name = "lblEle3DoorStatus";
            this.lblEle3DoorStatus.Size = new System.Drawing.Size(0, 12);
            this.lblEle3DoorStatus.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "DR";
            // 
            // lblEle3CurrentFloor
            // 
            this.lblEle3CurrentFloor.AutoSize = true;
            this.lblEle3CurrentFloor.Location = new System.Drawing.Point(35, 9);
            this.lblEle3CurrentFloor.Name = "lblEle3CurrentFloor";
            this.lblEle3CurrentFloor.Size = new System.Drawing.Size(35, 12);
            this.lblEle3CurrentFloor.TabIndex = 1;
            this.lblEle3CurrentFloor.Text = "label2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "NF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "現在階";
            // 
            // cmbNowIsAt
            // 
            this.cmbNowIsAt.FormattingEnabled = true;
            this.cmbNowIsAt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNowIsAt.Location = new System.Drawing.Point(6, 30);
            this.cmbNowIsAt.Name = "cmbNowIsAt";
            this.cmbNowIsAt.Size = new System.Drawing.Size(50, 20);
            this.cmbNowIsAt.TabIndex = 11;
            this.cmbNowIsAt.Text = "--0--";
            // 
            // btCallElevator
            // 
            this.btCallElevator.Location = new System.Drawing.Point(62, 11);
            this.btCallElevator.Name = "btCallElevator";
            this.btCallElevator.Size = new System.Drawing.Size(75, 39);
            this.btCallElevator.TabIndex = 12;
            this.btCallElevator.Text = "エレベーター呼ぶ";
            this.btCallElevator.UseVisualStyleBackColor = true;
            this.btCallElevator.Click += new System.EventHandler(this.btCallElevator_Click);
            this.btCallElevator.Validating += new System.ComponentModel.CancelEventHandler(this.btCallElevator_Validating);
            // 
            // gboxInside
            // 
            this.gboxInside.Controls.Add(this.button4);
            this.gboxInside.Controls.Add(this.cbGoTo);
            this.gboxInside.Controls.Add(this.label5);
            this.gboxInside.Location = new System.Drawing.Point(191, 300);
            this.gboxInside.Name = "gboxInside";
            this.gboxInside.Size = new System.Drawing.Size(119, 57);
            this.gboxInside.TabIndex = 13;
            this.gboxInside.TabStop = false;
            this.gboxInside.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 37);
            this.button4.TabIndex = 2;
            this.button4.Text = "行く";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbGoTo
            // 
            this.cbGoTo.FormattingEnabled = true;
            this.cbGoTo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbGoTo.Location = new System.Drawing.Point(10, 29);
            this.cbGoTo.Name = "cbGoTo";
            this.cbGoTo.Size = new System.Drawing.Size(48, 20);
            this.cbGoTo.TabIndex = 1;
            this.cbGoTo.Text = "--0--";
            this.cbGoTo.SelectedIndexChanged += new System.EventHandler(this.cbGoTo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "行く階";
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 800;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 800;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 800;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 800;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // gbNowAt
            // 
            this.gbNowAt.Controls.Add(this.label3);
            this.gbNowAt.Controls.Add(this.cmbNowIsAt);
            this.gbNowAt.Controls.Add(this.btCallElevator);
            this.gbNowAt.Location = new System.Drawing.Point(22, 300);
            this.gbNowAt.Name = "gbNowAt";
            this.gbNowAt.Size = new System.Drawing.Size(147, 57);
            this.gbNowAt.TabIndex = 14;
            this.gbNowAt.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "動作ログ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 390);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbNowAt);
            this.Controls.Add(this.gboxInside);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMainLog);
            this.Controls.Add(this.dtgvEle1);
            this.Name = "Form1";
            this.Text = "エレベーター";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEle1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gboxInside.ResumeLayout(false);
            this.gboxInside.PerformLayout();
            this.gbNowAt.ResumeLayout(false);
            this.gbNowAt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEle1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elevator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elevator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elevator3;
        private System.Windows.Forms.TextBox txtMainLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEle1DoorStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEle1CurrentFloor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEle2DoorStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEle2CurrentFloor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEle3DoorStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEle3CurrentFloor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNowIsAt;
        private System.Windows.Forms.Button btCallElevator;
        private System.Windows.Forms.GroupBox gboxInside;
        private System.Windows.Forms.ComboBox cbGoTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.GroupBox gbNowAt;
        private System.Windows.Forms.Label label7;
    }
}

