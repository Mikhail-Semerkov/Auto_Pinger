using System;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using Microsoft.Win32;
using System.Net;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ping
{
    public partial class AutoPinger : Form
    {

        LogConnect forms_log_gonnect_object = new LogConnect();
        bool ping_sost_flag = false;
        bool ping_ok;
        int ping_count;

        int Errors_Ping_Session;
        int Max_Ping_Session;
        int Min_Ping_Session;
        String Time_Ping_Sessions;
        int Hours, Minutes, Seconds;
        String str_hourse, str_minutes, str_seconds;







        readonly AutoResetEvent resetEvent = new AutoResetEvent(false);

        public AutoPinger()
        {
            InitializeComponent();
            OnPingRButton.Checked = true;
            PoVerhOkonCheckBox.Checked = true;
            Zaderjka_label.Visible = false;
            ClearButton.Focus();
            Min_Ping_Session = 100;

            forms_log_gonnect_object.chart1.Series[0].LegendText = "Connect";

            Series PingError = new Series("Disconnect");
            forms_log_gonnect_object.chart1.Series.Add(PingError);



            forms_log_gonnect_object.chart1.Series[0].ChartType = SeriesChartType.Line;
            forms_log_gonnect_object.chart1.Series[0].BorderWidth = 3;



            forms_log_gonnect_object.chart1.Series[1].ChartType = SeriesChartType.Line;
            forms_log_gonnect_object.chart1.Series[1].BorderWidth = 3;

        }

        private void PingTimer_Tick(object sender, EventArgs e)
        {

            IPAddress ip_label = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
            label_ip_adrr.Text = "Текущий IP адресс компьютера: " + ip_label.ToString();


            if (OnPingRButton.Checked == true && IPTextBox.Text.Length > 3 && IPTextBox.Text.Length != 0 && IPTextBox.Text.Contains("."))
            {
                SendPing();
            }

            Seconds++;
 

            if (Seconds > 59)
            {
                Minutes++;
                
                Seconds = 0;
            }
            if(Minutes > 59)
            {
                Hours++;
                
                Minutes = 0;
            }
            if (Hours > 24)
            {

                Hours = 0;
                Minutes = 0;
                Seconds = 0;
            }

            str_seconds = Seconds.ToString();
            str_minutes = Minutes.ToString();
            str_hourse = Hours.ToString();


            if (str_hourse.Length < 2)
            {
                str_hourse = "0" + str_hourse;
            }

            if (str_minutes.Length < 2)
            {
                str_minutes = "0" + str_minutes;
            }

            if (str_seconds.Length < 2)
            {
                str_seconds = "0" + str_seconds;
            }



            //Time_Ping_Sessions = str_seconds + ":" + str_minutes + ":" + str_hourse;

            Time_Ping_Sessions = str_hourse + ":" + str_minutes + ":" + str_seconds;

        }

        private void RadioButtonClick(object sender, EventArgs e)
        {
            if (OffPingRButton.Checked == true)
            {
                Zaderjka_label.Visible = false;
                ResponseTextBox.AppendText("Auto Ping остановлен!\r\n");
                IPTextBox.BackColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void SendPing()
        {
            try
            {
                System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping();
                pingSender.PingCompleted += new PingCompletedEventHandler(PingSender_Complete);
                byte[] packetData = Encoding.ASCII.GetBytes(".......................");
                PingOptions packetOptions = new PingOptions(50, true);
                pingSender.SendAsync(IPTextBox.Text, 1700, packetData, packetOptions, resetEvent);
            }

            catch (System.Net.NetworkInformation.PingException)
            {
                ResponseTextBox.AppendText("Ошибка подсети, проверте ваш статический IP\r\n");
                IPTextBox.BackColor = Color.FromArgb(255, 0, 0);
            }

        }
    
        




        private void PingSender_Complete(object sender, PingCompletedEventArgs e)
        {

            if (e.Cancelled)
            {
                ResponseTextBox.AppendText("Пинг отменен...\r\n");
                ((AutoResetEvent)e.UserState).Set();
                IPTextBox.BackColor = Color.FromArgb(255, 0, 0);
            }
            else if (e.Error != null)
            {
                ResponseTextBox.AppendText("Произошла ошибка: " + e.Error + "\r\n");
                ((AutoResetEvent)e.UserState).Set();
                IPTextBox.BackColor = Color.FromArgb(255, 0, 0);
            }
            else
            {
                PingReply pingResponse = e.Reply;
                ShowPingResults(pingResponse);
            }
        }

        private void ToolStripMenuItem_Click()
        {

            if (ping_ok == true)
            {
                forms_log_gonnect_object.chart1.Series[0].Color = Color.Green;
                forms_log_gonnect_object.chart1.Series[1].Color = Color.Red;
                forms_log_gonnect_object.chart1.Series[0].Points.Add(ping_count);
                forms_log_gonnect_object.chart1.Series[1].Points.Add(0);
                
            }

            if (ping_ok == false)
            {
                
                forms_log_gonnect_object.chart1.Series[0].Color = Color.Green;
                forms_log_gonnect_object.chart1.Series[1].Color = Color.Red;

                forms_log_gonnect_object.chart1.Series[0].Points.Add(0);
                forms_log_gonnect_object.chart1.Series[1].Points.Add(100);
            }
        }



        public void ShowPingResults(PingReply pingResponse)
        {

            if (pingResponse.Status == IPStatus.Success)
            {
                ping_ok = true;

                ResponseTextBox.AppendText("Пинг " + pingResponse.Address.ToString() + ": байт = " + pingResponse.Buffer.Length + "; мс = " + pingResponse.RoundtripTime + "; TTL = " + pingResponse.Options.Ttl + "\r\n");
                string TimePingString = pingResponse.RoundtripTime.ToString();
                int TimePing = int.Parse(TimePingString);
                Zaderjka_label.Visible = true;
                Zaderjka_label.Text = "Задержка: " + TimePingString + " мс";

                ping_count = TimePing + 1;

                forms_log_gonnect_object.label1.Text = "IP: " + IPTextBox.Text;


                if (TimePing >= 0)
                {
                    IPTextBox.BackColor = Color.FromArgb(0, 255, 0);
                }

                if (TimePing >= 20)
                {
                    IPTextBox.BackColor = Color.FromArgb(50, 255, 0);
                }

                if (TimePing >= 40)
                {
                    IPTextBox.BackColor = Color.FromArgb(100, 255, 0);
                }

                if (TimePing >= 60)
                {
                    IPTextBox.BackColor = Color.FromArgb(150, 255, 0);
                }

                if (TimePing >= 80)
                {
                    IPTextBox.BackColor = Color.FromArgb(200, 255, 0);
                }
                
                if (TimePing >= 100)
                {
                    IPTextBox.BackColor = Color.FromArgb(255, 255, 0);
                }

                if (TimePing >= 120)
                {
                    IPTextBox.BackColor = Color.FromArgb(255, 200, 0);
                }

                if (TimePing >= 140)
                {
                    IPTextBox.BackColor = Color.FromArgb(255, 150, 0);
                }

                if (TimePing >= 160)
                {
                    IPTextBox.BackColor = Color.FromArgb(255, 100, 0);
                }

                if (TimePing >= 180)
                {
                    IPTextBox.BackColor = Color.FromArgb(255, 80, 0);
                }

                if(ping_sost_flag == false)
                {

                    forms_log_gonnect_object.LogConnectTextBox.Text += "Connected (" + "IP: " + IPTextBox.Text + ") [" + DateTime.Now.ToString("dd MMMM yyyy") + ", " + DateTime.Now.ToString("HH:mm:ss") + "]\r\n";

                    ping_sost_flag = true;
                }

            }
            else
            {

                Errors_Ping_Session++;
                ping_ok = false;
                ping_count = 10;
                ResponseTextBox.AppendText("В данный момент адрес " + IPTextBox.Text + " недоступен!\r\n");
                Zaderjka_label.Visible = false;
                IPTextBox.BackColor = Color.FromArgb(255, 0, 0);

                if (ping_sost_flag == true)
                {

                    forms_log_gonnect_object.LogConnectTextBox.Text += "Error connect("+ "IP: " + IPTextBox.Text + ") [" + DateTime.Now.ToString("dd MMMM yyyy") + ", " + DateTime.Now.ToString("HH:mm:ss") + "]\r\n";

                    ping_sost_flag = false;
                }

            }

            ToolStripMenuItem_Click();

            if (ping_count > Max_Ping_Session)
            {
                Max_Ping_Session = ping_count;
                forms_log_gonnect_object.label_max_ping.Text = "MAX PING: " + Max_Ping_Session.ToString();
            }

            if (ping_count < Min_Ping_Session)
            {
                Min_Ping_Session = ping_count;
                forms_log_gonnect_object.label_min_ping.Text = "MIN PING: " + Min_Ping_Session.ToString();
            }


            forms_log_gonnect_object.label_errors_ping.Text = "ERRORS: " + Errors_Ping_Session.ToString();


        

            forms_log_gonnect_object.label_time_sessions.Text = "TIME SESSION: " + Time_Ping_Sessions;




        }

        ////////Сохранение в реестр при выходе из программы/////////
        private void Program_FormClosing(object sender, FormClosingEventArgs e)
        {


            RegistryKey key = Registry.CurrentUser.CreateSubKey("Option_Pinger");
            key.SetValue("ip", IPTextBox.Text);
            key.Close();


        }

        ////////Загрузка с реестра при входе в программу/////////
        private void Program_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey op = Registry.CurrentUser.OpenSubKey("Option_Pinger");

                if (op != null)
                {
                    string ip = (string)op.GetValue("ip");
                    IPTextBox.Text = ip;
                }


            }
            catch { }


            IPAddress ip_label = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
            label_ip_adrr.Text = "Текущий IP адресс компьютера: " + ip_label.ToString();

            forms_log_gonnect_object.LogConnectTextBox.Text += "Запуск программы" + " [" + DateTime.Now.ToString("dd MMMM yyyy") + ", " + DateTime.Now.ToString("HH:mm:ss") + "]\r\n";

        }

        private void PoVerchOkon_CheckedChanged(object sender, EventArgs e)
        {
            if (PoVerhOkonCheckBox.Checked == true)
            {
                TopMost = true;
                
            }
            else
            {
                TopMost = false;

            }
        }

        private void NewPageButton_Click(object sender, EventArgs e)
        {
            AutoPinger form = new AutoPinger();
            form.Show();
          
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            if (PoVerhOkonCheckBox.Checked == true)
            {
                //TopMost = true;
                forms_log_gonnect_object.TopMost = true;
            }
            else
            {
                //TopMost = false;
                forms_log_gonnect_object.TopMost = false;

            }
            ResponseTextBox.Clear();
           
            forms_log_gonnect_object.ShowDialog();
        }

    }
}