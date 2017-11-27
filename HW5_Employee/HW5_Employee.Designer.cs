namespace HW5_Employee
{
    partial class HW5_Employee
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HW5_Employee));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.HiredateTime = new System.Windows.Forms.DateTimePicker();
            this.Titlecombo = new System.Windows.Forms.ComboBox();
            this.Salarytext = new System.Windows.Forms.TextBox();
            this.EMPtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Autotool = new System.Windows.Forms.ToolStripButton();
            this.Sorttool = new System.Windows.Forms.ToolStripButton();
            this.Searhtool = new System.Windows.Forms.ToolStripButton();
            this.txttool = new System.Windows.Forms.ToolStripTextBox();
            this.Deletetool = new System.Windows.Forms.ToolStripButton();
            this.Addtool = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Cleartool = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer3.Size = new System.Drawing.Size(655, 448);
            this.splitContainer3.SplitterDistance = 156;
            this.splitContainer3.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(655, 156);
            this.listBox1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.HiredateTime);
            this.splitContainer2.Panel1.Controls.Add(this.Titlecombo);
            this.splitContainer2.Panel1.Controls.Add(this.Salarytext);
            this.splitContainer2.Panel1.Controls.Add(this.EMPtext);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(902, 448);
            this.splitContainer2.SplitterDistance = 243;
            this.splitContainer2.TabIndex = 0;
            // 
            // HiredateTime
            // 
            this.HiredateTime.Location = new System.Drawing.Point(27, 158);
            this.HiredateTime.Name = "HiredateTime";
            this.HiredateTime.Size = new System.Drawing.Size(200, 22);
            this.HiredateTime.TabIndex = 7;
            // 
            // Titlecombo
            // 
            this.Titlecombo.FormattingEnabled = true;
            this.Titlecombo.Location = new System.Drawing.Point(27, 214);
            this.Titlecombo.Name = "Titlecombo";
            this.Titlecombo.Size = new System.Drawing.Size(200, 20);
            this.Titlecombo.TabIndex = 6;
            // 
            // Salarytext
            // 
            this.Salarytext.Location = new System.Drawing.Point(27, 277);
            this.Salarytext.Name = "Salarytext";
            this.Salarytext.Size = new System.Drawing.Size(200, 22);
            this.Salarytext.TabIndex = 5;
            // 
            // EMPtext
            // 
            this.EMPtext.Location = new System.Drawing.Point(27, 80);
            this.EMPtext.Name = "EMPtext";
            this.EMPtext.Size = new System.Drawing.Size(200, 22);
            this.EMPtext.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "薪資";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "職謂";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "聘用日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "員工";
            // 
            // Autotool
            // 
            this.Autotool.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autotool.Image = ((System.Drawing.Image)(resources.GetObject("Autotool.Image")));
            this.Autotool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Autotool.Name = "Autotool";
            this.Autotool.Size = new System.Drawing.Size(87, 40);
            this.Autotool.Text = "自動輸入";
            this.Autotool.Click += new System.EventHandler(this.Autotool_Click);
            // 
            // Sorttool
            // 
            this.Sorttool.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sorttool.Image = ((System.Drawing.Image)(resources.GetObject("Sorttool.Image")));
            this.Sorttool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sorttool.Name = "Sorttool";
            this.Sorttool.Size = new System.Drawing.Size(57, 40);
            this.Sorttool.Text = "排序";
            this.Sorttool.Click += new System.EventHandler(this.Sorttool_Click);
            // 
            // Searhtool
            // 
            this.Searhtool.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searhtool.Image = ((System.Drawing.Image)(resources.GetObject("Searhtool.Image")));
            this.Searhtool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Searhtool.Name = "Searhtool";
            this.Searhtool.Size = new System.Drawing.Size(57, 40);
            this.Searhtool.Text = "尋找";
            this.Searhtool.Click += new System.EventHandler(this.Searhtool_Click);
            // 
            // txttool
            // 
            this.txttool.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttool.Name = "txttool";
            this.txttool.Size = new System.Drawing.Size(80, 43);
            // 
            // Deletetool
            // 
            this.Deletetool.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletetool.Image = ((System.Drawing.Image)(resources.GetObject("Deletetool.Image")));
            this.Deletetool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Deletetool.Name = "Deletetool";
            this.Deletetool.Size = new System.Drawing.Size(57, 40);
            this.Deletetool.Text = "刪除";
            this.Deletetool.Click += new System.EventHandler(this.Deletetool_Click);
            // 
            // Addtool
            // 
            this.Addtool.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addtool.Image = ((System.Drawing.Image)(resources.GetObject("Addtool.Image")));
            this.Addtool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Addtool.Name = "Addtool";
            this.Addtool.Size = new System.Drawing.Size(57, 40);
            this.Addtool.Text = "新增";
            this.Addtool.Click += new System.EventHandler(this.Addtool_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addtool,
            this.Deletetool,
            this.txttool,
            this.Searhtool,
            this.Cleartool,
            this.Sorttool,
            this.Autotool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(902, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Cleartool
            // 
            this.Cleartool.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cleartool.Image = ((System.Drawing.Image)(resources.GetObject("Cleartool.Image")));
            this.Cleartool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cleartool.Name = "Cleartool";
            this.Cleartool.Size = new System.Drawing.Size(57, 40);
            this.Cleartool.Text = "清空";
            this.Cleartool.Click += new System.EventHandler(this.Cleartool_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(902, 495);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 1;
            // 
            // HW5_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 495);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HW5_Employee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HW5_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DateTimePicker HiredateTime;
        private System.Windows.Forms.ComboBox Titlecombo;
        private System.Windows.Forms.TextBox Salarytext;
        private System.Windows.Forms.TextBox EMPtext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton Autotool;
        private System.Windows.Forms.ToolStripButton Sorttool;
        private System.Windows.Forms.ToolStripButton Searhtool;
        private System.Windows.Forms.ToolStripTextBox txttool;
        private System.Windows.Forms.ToolStripButton Deletetool;
        private System.Windows.Forms.ToolStripButton Addtool;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Cleartool;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

