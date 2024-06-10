namespace AnimationForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.block = new System.Windows.Forms.Panel();
            this.numDur = new System.Windows.Forms.NumericUpDown();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numWait = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkInfinity = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAnimColor = new System.Windows.Forms.Button();
            this.btnAnimXY = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAnim1 = new System.Windows.Forms.Button();
            this.btnAnim2 = new System.Windows.Forms.Button();
            this.btnAnim3 = new System.Windows.Forms.Button();
            this.btnAnim4 = new System.Windows.Forms.Button();
            this.btnAnimCustom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBack = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "AnimX";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnAnimX_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(107, 5);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(171, 20);
            this.cmbType.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picBall);
            this.panel1.Controls.Add(this.block);
            this.panel1.Location = new System.Drawing.Point(12, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 250);
            this.panel1.TabIndex = 3;
            // 
            // picBall
            // 
            this.picBall.Image = global::AnimationForm.Properties.Resources.browser;
            this.picBall.Location = new System.Drawing.Point(494, 18);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(56, 56);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBall.TabIndex = 3;
            this.picBall.TabStop = false;
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.block.Location = new System.Drawing.Point(22, 154);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(20, 20);
            this.block.TabIndex = 2;
            // 
            // numDur
            // 
            this.numDur.Location = new System.Drawing.Point(388, 5);
            this.numDur.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDur.Name = "numDur";
            this.numDur.Size = new System.Drawing.Size(175, 21);
            this.numDur.TabIndex = 4;
            this.numDur.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(107, 36);
            this.numInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(171, 21);
            this.numInterval.TabIndex = 5;
            this.numInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Animate1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkInfinity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkBack, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numInterval, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numWait, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.numDur, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 119);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wait";
            // 
            // numWait
            // 
            this.numWait.Location = new System.Drawing.Point(388, 36);
            this.numWait.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWait.Name = "numWait";
            this.numWait.Size = new System.Drawing.Size(176, 21);
            this.numWait.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "AutoBack";
            // 
            // chkInfinity
            // 
            this.chkInfinity.AutoSize = true;
            this.chkInfinity.Location = new System.Drawing.Point(107, 65);
            this.chkInfinity.Name = "chkInfinity";
            this.chkInfinity.Size = new System.Drawing.Size(15, 14);
            this.chkInfinity.TabIndex = 11;
            this.chkInfinity.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(562, 157);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 74);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAnimColor
            // 
            this.btnAnimColor.Location = new System.Drawing.Point(194, 157);
            this.btnAnimColor.Name = "btnAnimColor";
            this.btnAnimColor.Size = new System.Drawing.Size(75, 23);
            this.btnAnimColor.TabIndex = 9;
            this.btnAnimColor.Text = "AnimColor";
            this.btnAnimColor.UseVisualStyleBackColor = true;
            this.btnAnimColor.Click += new System.EventHandler(this.btnAnimColor_Click);
            // 
            // btnAnimXY
            // 
            this.btnAnimXY.Location = new System.Drawing.Point(103, 157);
            this.btnAnimXY.Name = "btnAnimXY";
            this.btnAnimXY.Size = new System.Drawing.Size(75, 23);
            this.btnAnimXY.TabIndex = 10;
            this.btnAnimXY.Text = "AnimXY";
            this.btnAnimXY.UseVisualStyleBackColor = true;
            this.btnAnimXY.Click += new System.EventHandler(this.btnAnimXY_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPos,
            this.lblColor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPos
            // 
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(32, 17);
            this.lblPos.Text = "POS";
            // 
            // lblColor
            // 
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 17);
            this.lblColor.Text = "COLOR";
            // 
            // btnAnim1
            // 
            this.btnAnim1.Location = new System.Drawing.Point(12, 208);
            this.btnAnim1.Name = "btnAnim1";
            this.btnAnim1.Size = new System.Drawing.Size(75, 23);
            this.btnAnim1.TabIndex = 12;
            this.btnAnim1.Text = "Anim1";
            this.btnAnim1.UseVisualStyleBackColor = true;
            this.btnAnim1.Click += new System.EventHandler(this.btnAnim1_Click);
            // 
            // btnAnim2
            // 
            this.btnAnim2.Location = new System.Drawing.Point(103, 208);
            this.btnAnim2.Name = "btnAnim2";
            this.btnAnim2.Size = new System.Drawing.Size(75, 23);
            this.btnAnim2.TabIndex = 13;
            this.btnAnim2.Text = "Anim2";
            this.btnAnim2.UseVisualStyleBackColor = true;
            this.btnAnim2.Click += new System.EventHandler(this.btnAnim2_Click);
            // 
            // btnAnim3
            // 
            this.btnAnim3.Location = new System.Drawing.Point(194, 208);
            this.btnAnim3.Name = "btnAnim3";
            this.btnAnim3.Size = new System.Drawing.Size(75, 23);
            this.btnAnim3.TabIndex = 14;
            this.btnAnim3.Text = "Anim3";
            this.btnAnim3.UseVisualStyleBackColor = true;
            this.btnAnim3.Click += new System.EventHandler(this.btnAnim3_Click);
            // 
            // btnAnim4
            // 
            this.btnAnim4.Location = new System.Drawing.Point(404, 208);
            this.btnAnim4.Name = "btnAnim4";
            this.btnAnim4.Size = new System.Drawing.Size(111, 23);
            this.btnAnim4.TabIndex = 15;
            this.btnAnim4.Text = "AnimParallel";
            this.btnAnim4.UseVisualStyleBackColor = true;
            this.btnAnim4.Click += new System.EventHandler(this.btnAnim4_Click);
            // 
            // btnAnimCustom
            // 
            this.btnAnimCustom.Location = new System.Drawing.Point(287, 208);
            this.btnAnimCustom.Name = "btnAnimCustom";
            this.btnAnimCustom.Size = new System.Drawing.Size(111, 23);
            this.btnAnimCustom.TabIndex = 16;
            this.btnAnimCustom.Text = "AnimCustom";
            this.btnAnimCustom.UseVisualStyleBackColor = true;
            this.btnAnimCustom.Click += new System.EventHandler(this.btnAnimCustom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "Infinity";
            // 
            // chkBack
            // 
            this.chkBack.AutoSize = true;
            this.chkBack.Location = new System.Drawing.Point(388, 65);
            this.chkBack.Name = "chkBack";
            this.chkBack.Size = new System.Drawing.Size(15, 14);
            this.chkBack.TabIndex = 17;
            this.chkBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 548);
            this.Controls.Add(this.btnAnimCustom);
            this.Controls.Add(this.btnAnim4);
            this.Controls.Add(this.btnAnim3);
            this.Controls.Add(this.btnAnim2);
            this.Controls.Add(this.btnAnim1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAnimXY);
            this.Controls.Add(this.btnAnimColor);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# easing animation";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numDur;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAnimColor;
        private System.Windows.Forms.Button btnAnimXY;
        private System.Windows.Forms.CheckBox chkInfinity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblPos;
        private System.Windows.Forms.ToolStripStatusLabel lblColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numWait;
        private System.Windows.Forms.Button btnAnim1;
        private System.Windows.Forms.Panel block;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Button btnAnim2;
        private System.Windows.Forms.Button btnAnim3;
        private System.Windows.Forms.Button btnAnim4;
        private System.Windows.Forms.Button btnAnimCustom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBack;
    }
}

