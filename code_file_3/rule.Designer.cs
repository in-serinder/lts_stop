namespace newct
{
    partial class rule_form
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
            this.time_do = new System.Windows.Forms.Timer(this.components);
            this.rule_d_t = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ruler = new System.Windows.Forms.TabPage();
            this.Shell = new System.Windows.Forms.TabPage();
            this.shell_to = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shell_pr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.Ruler.SuspendLayout();
            this.Shell.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // time_do
            // 
            this.time_do.Tick += new System.EventHandler(this.time_do_Tick);
            // 
            // rule_d_t
            // 
            this.rule_d_t.AutoSize = true;
            this.rule_d_t.Location = new System.Drawing.Point(6, 12);
            this.rule_d_t.Name = "rule_d_t";
            this.rule_d_t.Size = new System.Drawing.Size(41, 12);
            this.rule_d_t.TabIndex = 0;
            this.rule_d_t.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ruler);
            this.tabControl1.Controls.Add(this.Shell);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 405);
            this.tabControl1.TabIndex = 1;
            // 
            // Ruler
            // 
            this.Ruler.AutoScroll = true;
            this.Ruler.Controls.Add(this.rule_d_t);
            this.Ruler.Location = new System.Drawing.Point(4, 22);
            this.Ruler.Name = "Ruler";
            this.Ruler.Padding = new System.Windows.Forms.Padding(3);
            this.Ruler.Size = new System.Drawing.Size(712, 379);
            this.Ruler.TabIndex = 0;
            this.Ruler.Text = "Ruler";
            this.Ruler.UseVisualStyleBackColor = true;
            // 
            // Shell
            // 
            this.Shell.Controls.Add(this.panel1);
            this.Shell.Controls.Add(this.label1);
            this.Shell.Controls.Add(this.shell_to);
            this.Shell.Location = new System.Drawing.Point(4, 22);
            this.Shell.Name = "Shell";
            this.Shell.Padding = new System.Windows.Forms.Padding(3);
            this.Shell.Size = new System.Drawing.Size(712, 379);
            this.Shell.TabIndex = 1;
            this.Shell.Text = "Shell";
            this.Shell.UseVisualStyleBackColor = true;
            // 
            // shell_to
            // 
            this.shell_to.Location = new System.Drawing.Point(55, 351);
            this.shell_to.Name = "shell_to";
            this.shell_to.Size = new System.Drawing.Size(646, 21);
            this.shell_to.TabIndex = 0;
            this.shell_to.TextChanged += new System.EventHandler(this.shell_to_TextChanged);
            this.shell_to.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shell_to_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shell:";
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.label1_PreviewKeyDown);
            // 
            // shell_pr
            // 
            this.shell_pr.AutoSize = true;
            this.shell_pr.Location = new System.Drawing.Point(6, 12);
            this.shell_pr.Name = "shell_pr";
            this.shell_pr.Size = new System.Drawing.Size(41, 12);
            this.shell_pr.TabIndex = 2;
            this.shell_pr.Text = "shell:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.shell_pr);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 348);
            this.panel1.TabIndex = 3;
            // 
            // rule_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(717, 406);
            this.Controls.Add(this.tabControl1);
            this.Name = "rule_form";
            this.Text = "rule";
            this.Load += new System.EventHandler(this.rule_form_Load);
            this.tabControl1.ResumeLayout(false);
            this.Ruler.ResumeLayout(false);
            this.Ruler.PerformLayout();
            this.Shell.ResumeLayout(false);
            this.Shell.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer time_do;
        private System.Windows.Forms.Label rule_d_t;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ruler;
        private System.Windows.Forms.TabPage Shell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shell_to;
        private System.Windows.Forms.Label shell_pr;
        private System.Windows.Forms.Panel panel1;
    }
}