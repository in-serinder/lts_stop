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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.rule_d_t.Location = new System.Drawing.Point(9, 7);
            this.rule_d_t.Name = "rule_d_t";
            this.rule_d_t.Size = new System.Drawing.Size(41, 12);
            this.rule_d_t.TabIndex = 0;
            this.rule_d_t.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.rule_d_t);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 384);
            this.panel1.TabIndex = 1;
            // 
            // rule_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 386);
            this.Controls.Add(this.panel1);
            this.Name = "rule_form";
            this.Text = "rule";
            this.Load += new System.EventHandler(this.rule_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer time_do;
        private System.Windows.Forms.Label rule_d_t;
        private System.Windows.Forms.Panel panel1;
    }
}