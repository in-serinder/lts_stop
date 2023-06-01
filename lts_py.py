import os
import time


ch=input("1：解除，2：恢复\n\n")
if ch==1:
    os.system("NetSh Advfirewall set allprofiles state on")
    print("防火墙已开启")
    os.system("netsh advfirewall firewall add rule dir=in action=block name=stu_in program=C:\Program Files (x86)\Lenovo teaching systeam\student.exe")
    os.system("netsh advfirewall firewall add rule dir=out action=block name=stu_out program=C:\Program Files (x86)\Lenovo teaching systeam\student.exe")
    print("规则添加状态:\n\n","出栈状态:\n",os.system("netsh advfirewall firewall show rule=stu_in"),"入栈状态：\n",os.system("netsh advfirewall firewall show rule=stu_out"))
    print("已完成规则添加")
else:
    os.system("NetSh Advfirewall set allprofiles state off")
    print("防火墙已开启")
    os.system(
        "netsh advfirewall firewall delete rule name=stu_in")
    os.system(
        "netsh advfirewall firewall delete rule name=stu_out")
    print("规则添加状态:\n\n", "出栈状态:\n", os.system("netsh advfirewall firewall show rule=stu_in"), "入栈状态：\n",
          os.system("netsh advfirewall firewall show rule=stu_out"))
    print("已经完成回滚")

j=10
for i in range(10):

    print(j)
    time.sleep(1)
    j = j - 1
