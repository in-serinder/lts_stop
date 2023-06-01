using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace newct
{
    public partial class rule_form : Form
    {
        public rule_form()
        {
            InitializeComponent();

           
            Dictionary<string, string> ControlsInfo = new Dictionary<string, string>();
  

        }
   

        private void rule_form_Load(object sender, EventArgs e)
        {
            rule_d_t.Text = "入栈规则状态：" + runshell( "netsh advfirewall firewall show rule name=stu_rule_in")+ "出栈规则状态："+runshell("netsh advfirewall firewall show rule name=stu_rule_out");
        }

            private string runshell(string command)
        {
            
            Process p = new Process();
            p.StartInfo.FileName = "powershell.exe";        
            p.StartInfo.Arguments = "/c " + command;   
            p.StartInfo.UseShellExecute = false;     
            p.StartInfo.RedirectStandardInput = true; 
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;  
            p.StartInfo.CreateNoWindow = true;        
            p.Start();
            return p.StandardOutput.ReadToEnd();      
        }


        private void time_do_Tick(object sender, EventArgs e)
        {
           

        }

        private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void shell_in(object sender, EventArgs e)
        {
            
        }

        private void shell_to_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                shell_pr.Text = runshell(shell_to.Text);
                shell_to.Text = "";
            }
        }

        private void shell_to_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

