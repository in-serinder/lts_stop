using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;
using System.Net.NetworkInformation;
using System.Management;
using Microsoft.Win32;
using NetFwTypeLib;
using System.Diagnostics;
using System.Threading;
using System.Timers;






namespace newct
{

    public partial class Form1 : Form
    {
        public delegate void SetControlVlue(string value);
        string in_fw, path,ch_path;
        //adinm
        public static bool adm_fi()
        {
            WindowsIdentity fw_d = WindowsIdentity.GetCurrent();
            WindowsPrincipal win_d = new WindowsPrincipal(fw_d);
            return win_d.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public Form1()  //load
        {
            InitializeComponent();

            if (adm_fi())
            {
                pa_d.ForeColor = Color.Green;
                pa_d.Text = "管理员";
            }
            else
            {
                pa_d.ForeColor = Color.Red;
                pa_d.Text = "程序运行权限非管理员，重新运行程序";
            }

        }
        //防火墙main_p

        public static void wa_f()
        {

        }
        public static void rule_l()
        {
            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
            // 创建一个新的防火墙规则对象
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            newRule.Description = "My Firewall Rule";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            newRule.Enabled = true;
            newRule.InterfaceTypes = "All";
            newRule.Name = "stu_rule";
            newRule.ApplicationName = @"C:\Program Files\Celemony\Melodyne 5\Melodyne.exe";
            fwPolicy2.Rules.Add(newRule);
        }



        private void rule_but_Click(object sender, EventArgs e)
        {
            in_fw = "";
            pr_fo.Value = 0;
            pr_fo.Value = 0;
            pr_t.Enabled = true;
            //开关
            runshell("NetSh Advfirewall set allprofiles state on");
            in_fw += "已启用防火墙\n\n"; ingo.Text = in_fw;
            


            Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
            INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
            // 创建一个新的防火墙规则对象
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            newRule.Enabled = true;
            newRule.InterfaceTypes = "All";
            newRule.Name = "stu_rule_in";
            newRule.ApplicationName = path;
            fwPolicy2.Rules.Add(newRule);
            in_fw += "已添加入栈规则\n\n"; ingo.Text = in_fw;
            

            //out
            INetFwRule rule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwRule"));
            rule.Name = "stu_rule_out";
            rule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            rule.ApplicationName = path;
            rule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            rule.Enabled = true;
            fwPolicy2.Rules.Add(rule);
            in_fw += "已添加出栈规则\n\n"; ingo.Text = in_fw;
            

            runshell("taskkill /f /im studentmain.exe");
            in_fw += "已处理额外事项\n\n"; ingo.Text = in_fw;
            

        }

        //调用shell

        public static string runshell(string command)
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

        //委托timer


        private void Form1_Load(object sender, EventArgs e)
        {
            time_d.Enabled = true;
            time_d.Interval = 200;

            pr_t.Enabled = false;
            time_d.Interval = 256;

        }

        private void pa_d_Click(object sender, EventArgs e)
        {

        }

        private void rule_d_but_Click(object sender, EventArgs e)
        {
            rule_form fule = new rule_form();
            fule.ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            pr_fo.Value = 0;
            pr_t.Enabled = true;
            runshell("NetSh Advfirewall set allprofiles state off");
            in_fw = "";
            fw_back();
            in_fw += "已关闭防火墙\n\n已移除入栈规则\n\n已移除出栈规则\n\n";
            
            in_fw += "已回滚操作\n\n"; ingo.Text = in_fw;

            
        }

        private  void timer_p(object sender, EventArgs e)
            {
            
            
            }

        //恢复FW
        public static void fw_back()
        {
            runshell("netsh advfirewall firewall delete rule name=stu_rule_in ");
            
            runshell("netsh advfirewall firewall delete rule name=stu_rule_out ");

            
        }

        private void chos_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_f = new OpenFileDialog();
            open_f.Multiselect = true;
            open_f.Title = "选择程序位置";
            open_f.Filter = "目标程序(student.exe)|student.exe|应用程序(*.exe)|*.exe|所有文件|*.*";

            if (open_f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                ch_path = open_f.FileName;

            }

        }

        private void pr_t_Tick(object sender, EventArgs e)
        {
           
            if (pr_fo.Value==100)
            {
                pr_t.Enabled = false;
            }
            else
            {
                pr_fo.Value += 10;
            }
        }

        //ch_file
        public static void openfile()
        {
           
             
        }

        private void time_d_Tick(object sender, EventArgs e)
        {
            if (path_ch.Text == "2")
            {
                stu_pa.Visible = false;
                chos_path.Visible = false;
                pa_in.Text = "路径为\\Program Files (x86)\n\n";
                path = @"C:\Program Files (x86)\Lenovo Teaching Systeam\student.exe";
            }
            else
            {
                if (path_ch.Text == "3")
                {
                    stu_pa.Visible = false;
                    chos_path.Visible = false;
                    pa_in.Text = "路径为\\Program Files\n\n";
                    path = @"C:\Program Files\Lenovo Teaching Systeam\student.exe";
                }
                else
                {
                    if(path_ch.Text=="4")
                    {
                        pa_in.Text = "自定义路径输入\\*";
                        chos_path.Visible = true;
                        path = ch_path;
                        stu_pa.Visible = true;stu_pa.Text = "选择的路径为:"+ ch_path;

                    }
                    else
                    {
                        stu_pa.Visible = false;
                        chos_path.Visible = false;
                        pa_in.Text = "路径为\\Systeam32\n\n";
                        path = @"C:\Windows\System32\Lenovo Teaching Systeam\student.exe";
                    }

                }
            }
        }
       
    }

       
    }

