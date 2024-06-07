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
            this.block = new System.Windows.Forms.Label();
            this.cmbType1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numDur1 = new System.Windows.Forms.NumericUpDown();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkInfinity = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbType2 = new System.Windows.Forms.ComboBox();
            this.numDur2 = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAnimColor = new System.Windows.Forms.Button();
            this.btnAnimXY = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblX = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblY = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDur2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 148);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "AnimX";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnAnimX_Click);
            // 
            // block
            // 
            this.block.AutoSize = true;
            this.block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.block.ForeColor = System.Drawing.SystemColors.Control;
            this.block.Location = new System.Drawing.Point(25, 28);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(23, 12);
            this.block.TabIndex = 1;
            this.block.Text = "   ";
            // 
            // cmbType1
            // 
            this.cmbType1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType1.FormattingEnabled = true;
            this.cmbType1.Location = new System.Drawing.Point(66, 34);
            this.cmbType1.Name = "cmbType1";
            this.cmbType1.Size = new System.Drawing.Size(224, 20);
            this.cmbType1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.block);
            this.panel1.Location = new System.Drawing.Point(12, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 173);
            this.panel1.TabIndex = 3;
            // 
            // numDur1
            // 
            this.numDur1.Location = new System.Drawing.Point(298, 34);
            this.numDur1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDur1.Name = "numDur1";
            this.numDur1.Size = new System.Drawing.Size(104, 21);
            this.numDur1.TabIndex = 4;
            this.numDur1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numInterval
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numInterval, 2);
            this.numInterval.Dock = System.Windows.Forms.DockStyle.Top;
            this.numInterval.Location = new System.Drawing.Point(66, 5);
            this.numInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(342, 21);
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
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Animate1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Controls.Add(this.chkInfinity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbType1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbType2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numDur1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.numDur2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.numInterval, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 118);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // chkInfinity
            // 
            this.chkInfinity.AutoSize = true;
            this.chkInfinity.Location = new System.Drawing.Point(66, 92);
            this.chkInfinity.Name = "chkInfinity";
            this.chkInfinity.Size = new System.Drawing.Size(15, 14);
            this.chkInfinity.TabIndex = 11;
            this.chkInfinity.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Infinity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Animate2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Interval";
            // 
            // cmbType2
            // 
            this.cmbType2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType2.FormattingEnabled = true;
            this.cmbType2.Location = new System.Drawing.Point(66, 63);
            this.cmbType2.Name = "cmbType2";
            this.cmbType2.Size = new System.Drawing.Size(224, 20);
            this.cmbType2.TabIndex = 9;
            // 
            // numDur2
            // 
            this.numDur2.Location = new System.Drawing.Point(298, 63);
            this.numDur2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDur2.Name = "numDur2";
            this.numDur2.Size = new System.Drawing.Size(104, 21);
            this.numDur2.TabIndex = 10;
            this.numDur2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(350, 148);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAnimColor
            // 
            this.btnAnimColor.Location = new System.Drawing.Point(194, 148);
            this.btnAnimColor.Name = "btnAnimColor";
            this.btnAnimColor.Size = new System.Drawing.Size(75, 23);
            this.btnAnimColor.TabIndex = 9;
            this.btnAnimColor.Text = "AnimColor";
            this.btnAnimColor.UseVisualStyleBackColor = true;
            this.btnAnimColor.Click += new System.EventHandler(this.btnAnimColor_Click);
            // 
            // btnAnimXY
            // 
            this.btnAnimXY.Location = new System.Drawing.Point(103, 148);
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
            this.lblX,
            this.lblY,
            this.lblColor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(441, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblX
            // 
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(16, 17);
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 17);
            this.lblY.Text = "Y";
            // 
            // lblColor
            // 
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(33, 17);
            this.lblColor.Text = "RGB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 417);
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDur2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label block;
        private System.Windows.Forms.ComboBox cmbType1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numDur1;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cmbType2;
        private System.Windows.Forms.NumericUpDown numDur2;
        private System.Windows.Forms.Button btnAnimColor;
        private System.Windows.Forms.Button btnAnimXY;
        private System.Windows.Forms.CheckBox chkInfinity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblX;
        private System.Windows.Forms.ToolStripStatusLabel lblY;
        private System.Windows.Forms.ToolStripStatusLabel lblColor;
    }
}

