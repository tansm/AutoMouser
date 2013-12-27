namespace AutoMouse {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.panMap = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rbnWall = new System.Windows.Forms.RadioButton();
            this.rbnRoad = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeigth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkStepByStep = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMap
            // 
            this.panMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMap.Location = new System.Drawing.Point(1, 80);
            this.panMap.Name = "panMap";
            this.panMap.Size = new System.Drawing.Size(1007, 648);
            this.panMap.TabIndex = 0;
            this.panMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panMap_Paint);
            this.panMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panMap_MouseMove);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(59, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "创建地图";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rbnWall
            // 
            this.rbnWall.AutoSize = true;
            this.rbnWall.Location = new System.Drawing.Point(6, 20);
            this.rbnWall.Name = "rbnWall";
            this.rbnWall.Size = new System.Drawing.Size(47, 16);
            this.rbnWall.TabIndex = 2;
            this.rbnWall.Text = "墙壁";
            this.rbnWall.UseVisualStyleBackColor = true;
            // 
            // rbnRoad
            // 
            this.rbnRoad.AutoSize = true;
            this.rbnRoad.Checked = true;
            this.rbnRoad.Location = new System.Drawing.Point(6, 43);
            this.rbnRoad.Name = "rbnRoad";
            this.rbnRoad.Size = new System.Drawing.Size(47, 16);
            this.rbnRoad.TabIndex = 3;
            this.rbnRoad.TabStop = true;
            this.rbnRoad.Text = "道路";
            this.rbnRoad.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnWall);
            this.groupBox1.Controls.Add(this.rbnRoad);
            this.groupBox1.Location = new System.Drawing.Point(140, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "鼠标绘制类型";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(12, 11);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(41, 21);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.Text = "15";
            // 
            // txtHeigth
            // 
            this.txtHeigth.Location = new System.Drawing.Point(12, 50);
            this.txtHeigth.Name = "txtHeigth";
            this.txtHeigth.Size = new System.Drawing.Size(41, 21);
            this.txtHeigth.TabIndex = 6;
            this.txtHeigth.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "×";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(288, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(288, 39);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 39);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkStepByStep
            // 
            this.chkStepByStep.AutoSize = true;
            this.chkStepByStep.Checked = true;
            this.chkStepByStep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStepByStep.Location = new System.Drawing.Point(369, 16);
            this.chkStepByStep.Name = "chkStepByStep";
            this.chkStepByStep.Size = new System.Drawing.Size(84, 16);
            this.chkStepByStep.TabIndex = 11;
            this.chkStepByStep.Text = "慢动作播放";
            this.chkStepByStep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.chkStepByStep);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHeigth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panMap);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "迷宫";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMap;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rbnWall;
        private System.Windows.Forms.RadioButton rbnRoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeigth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkStepByStep;
    }
}

