namespace newct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firewall_f = new System.Windows.Forms.Label();
            this.rule_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pa_d = new System.Windows.Forms.Label();
            this.ingo = new System.Windows.Forms.Label();
            this.path_ch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pr_fo = new System.Windows.Forms.ProgressBar();
            this.time_d = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pa_in = new System.Windows.Forms.Label();
            this.rule_d_but = new System.Windows.Forms.Button();
            this.chos_path = new System.Windows.Forms.Button();
            this.open_path = new System.Windows.Forms.OpenFileDialog();
            this.stu_pa = new System.Windows.Forms.Label();
            this.pr_t = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firewall_f
            // 
            this.firewall_f.AutoSize = true;
            this.firewall_f.Location = new System.Drawing.Point(12, 122);
            this.firewall_f.Name = "firewall_f";
            this.firewall_f.Size = new System.Drawing.Size(41, 12);
            this.firewall_f.TabIndex = 0;
            this.firewall_f.Text = "进度：";
            // 
            // rule_but
            // 
            this.rule_but.Location = new System.Drawing.Point(10, 23);
            this.rule_but.Name = "rule_but";
            this.rule_but.Size = new System.Drawing.Size(206, 67);
            this.rule_but.TabIndex = 1;
            this.rule_but.Text = "处理";
            this.rule_but.UseVisualStyleBackColor = true;
            this.rule_but.Click += new System.EventHandler(this.rule_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "程序状态：";
            // 
            // pa_d
            // 
            this.pa_d.AutoSize = true;
            this.pa_d.Location = new System.Drawing.Point(292, 23);
            this.pa_d.Name = "pa_d";
            this.pa_d.Size = new System.Drawing.Size(0, 12);
            this.pa_d.TabIndex = 3;
            this.pa_d.Click += new System.EventHandler(this.pa_d_Click);
            // 
            // ingo
            // 
            this.ingo.AutoSize = true;
            this.ingo.Location = new System.Drawing.Point(12, 15);
            this.ingo.Name = "ingo";
            this.ingo.Size = new System.Drawing.Size(29, 12);
            this.ingo.TabIndex = 4;
            this.ingo.Text = "NULL";
            // 
            // path_ch
            // 
            this.path_ch.FormattingEnabled = true;
            this.path_ch.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.path_ch.Location = new System.Drawing.Point(443, 292);
            this.path_ch.Name = "path_ch";
            this.path_ch.Size = new System.Drawing.Size(85, 20);
            this.path_ch.TabIndex = 5;
            this.path_ch.Text = "1（默认）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "位置策略：";
            // 
            // back
            // 
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("宋体", 7F);
            this.back.Location = new System.Drawing.Point(308, 292);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(58, 20);
            this.back.TabIndex = 7;
            this.back.Text = "恢复";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pr_fo);
            this.panel1.Controls.Add(this.ingo);
            this.panel1.Location = new System.Drawing.Point(27, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 163);
            this.panel1.TabIndex = 8;
            // 
            // pr_fo
            // 
            this.pr_fo.Location = new System.Drawing.Point(-1, 147);
            this.pr_fo.Name = "pr_fo";
            this.pr_fo.Size = new System.Drawing.Size(188, 14);
            this.pr_fo.TabIndex = 5;
            // 
            // time_d
            // 
            this.time_d.Tick += new System.EventHandler(this.time_d_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "目标目录：";
            // 
            // pa_in
            // 
            this.pa_in.AutoSize = true;
            this.pa_in.Location = new System.Drawing.Point(298, 67);
            this.pa_in.Name = "pa_in";
            this.pa_in.Size = new System.Drawing.Size(0, 12);
            this.pa_in.TabIndex = 10;
            // 
            // rule_d_but
            // 
            this.rule_d_but.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rule_d_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rule_d_but.Font = new System.Drawing.Font("宋体", 7F);
            this.rule_d_but.Location = new System.Drawing.Point(222, 292);
            this.rule_d_but.Name = "rule_d_but";
            this.rule_d_but.Size = new System.Drawing.Size(80, 20);
            this.rule_d_but.TabIndex = 11;
            this.rule_d_but.Text = "规则状态";
            this.rule_d_but.UseVisualStyleBackColor = true;
            this.rule_d_but.Click += new System.EventHandler(this.rule_d_but_Click);
            // 
            // chos_path
            // 
            this.chos_path.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chos_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chos_path.Font = new System.Drawing.Font("宋体", 7F);
            this.chos_path.Location = new System.Drawing.Point(443, 255);
            this.chos_path.Name = "chos_path";
            this.chos_path.Size = new System.Drawing.Size(85, 20);
            this.chos_path.TabIndex = 12;
            this.chos_path.Text = "选择路径....";
            this.chos_path.UseVisualStyleBackColor = true;
            this.chos_path.Visible = false;
            this.chos_path.Click += new System.EventHandler(this.chos_path_Click);
            // 
            // open_path
            // 
            this.open_path.FileName = "openFileDialog1";
            // 
            // stu_pa
            // 
            this.stu_pa.AutoSize = true;
            this.stu_pa.Location = new System.Drawing.Point(227, 97);
            this.stu_pa.Name = "stu_pa";
            this.stu_pa.Size = new System.Drawing.Size(0, 12);
            this.stu_pa.TabIndex = 13;
            this.stu_pa.Visible = false;
            // 
            // pr_t
            // 
            this.pr_t.Tick += new System.EventHandler(this.pr_t_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(533, 317);
            this.Controls.Add(this.stu_pa);
            this.Controls.Add(this.chos_path);
            this.Controls.Add(this.rule_d_but);
            this.Controls.Add(this.pa_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.path_ch);
            this.Controls.Add(this.pa_d);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rule_but);
            this.Controls.Add(this.firewall_f);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LTS-Stop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firewall_f;
        private System.Windows.Forms.Button rule_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pa_d;
        private System.Windows.Forms.Label ingo;
        private System.Windows.Forms.ComboBox path_ch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer time_d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pa_in;
        private System.Windows.Forms.Button rule_d_but;
        private System.Windows.Forms.Button chos_path;
        private System.Windows.Forms.OpenFileDialog open_path;
        private System.Windows.Forms.Label stu_pa;
        private System.Windows.Forms.ProgressBar pr_fo;
        private System.Windows.Forms.Timer pr_t;
    }
}

