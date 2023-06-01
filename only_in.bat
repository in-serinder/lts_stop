NetSh Advfirewall set allprofiles state on
netsh advfirewall firewall add rule dir=in action=block name=stu_in program=C:\Program Files (x86)\Lenovo teaching system\student.exe
netsh advfirewall firewall add rule dir=out action=block name=stu_out program=C:\Program Files (x86)\Lenovo teaching system\student.exe



