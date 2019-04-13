using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalk
{
    public partial class Form1 : Form
    {
        Class1 c;
        bool ntotal;
        int totaltime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new Class1();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            output.Clear();
            
                try
                {
                    c.LengthOfLap = float.Parse(this.lengthOfLap.Text);
                    c.NumberOfLaps = int.Parse(this.numberOfLaps.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nieprawidłowy parametr, wprowadź wartość liczbową");
                    return;
                }
                c.calculateDistance();
                if (this.timeBox.Text.IndexOf(":") == -1 || this.timeBox.Text.IndexOf(":") == 0 || this.timeBox.Text.IndexOf(":") == this.timeBox.Text.Length)
                {
                    MessageBox.Show("Wprowadź czas według formatu [mm:ss]");
                    return;
                }
                else
                {
                    try
                    {
                        c.MinutesOfRun = int.Parse(this.timeBox.Text.Substring(0, this.timeBox.Text.IndexOf(":")));
                        c.SecondsOfRun = int.Parse(this.timeBox.Text.Substring(this.timeBox.Text.IndexOf(":") + 1));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Nieprawidłowy parametr, wprowadź czas według formatu [mm:ss]");
                        return;
                    }
                }

                if (ntotal == false)
                {
                    totaltime = c.MinutesOfRun * 60 + c.SecondsOfRun;
                }
                else
                {
                    totaltime = (c.MinutesOfRun * 60 + c.SecondsOfRun) * c.NumberOfLaps;
                }
                c.calculateSpeed(totaltime);
                try
                {
                    c.MinutesOfLap = (totaltime / c.NumberOfLaps) / 60;
                    c.SecondsOfLap = (totaltime / c.NumberOfLaps) % 60;
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Wprowadź liczbę okrążeń");
                    return;
                }

                
                int minProK = (int)(totaltime / c.Distance) / 60;
                int secProK = (int)(totaltime / c.Distance) % 60;
                string minProKm = minProK.ToString();
                string secProKm = secProK.ToString();
                if (minProK < 10) minProKm = "0" + minProKm;
                if (secProK < 10) secProKm = "0" + secProKm;

                string smin = c.MinutesOfLap.ToString();
                string ssec = c.SecondsOfLap.ToString();
                if (c.MinutesOfLap < 10) smin = "0" + smin;
                if (c.SecondsOfLap < 10) ssec = "0" + ssec;
                c.TimeForLapInSec = c.MinutesOfLap*60+c.SecondsOfLap;
                c.calculateTimesForLaps();

                output.Text += "\n\n";
                if (c.NumberOfLaps>1)
                {
                    output.Text += "    Całkowity dystans:    " + c.Distance + " km\n";
                }
                output.Text+="    Prędkość:    " + c.Speed + " km/h\n";
                if(!ntotal)
                {
                    output.Text+="    Czas okrążenia:    "+smin+":"+ssec+"\n";
                }
                output.Text+="    Czas na 1 km:    "+minProKm+":"+secProKm+"\n\n";    
           }

        private void radioButtonTotalTime_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTotalTime.Checked)
                ntotal = false;
        }

        private void radioButtonTimeOfLap_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTimeOfLap.Checked)
                ntotal = true;
        }

        private void calculateT2_Click(object sender, EventArgs e)
        {
            outputT2.Clear();
            if (this.prefferedTime.Text.IndexOf(":") == -1 || this.prefferedTime.Text.IndexOf(":") == 0 || this.prefferedTime.Text.IndexOf(":") == this.prefferedTime.Text.Length)
            {
                MessageBox.Show("Wprowadź czas według formatu [mm:ss]");
                return;
            }
            else
            {
                try
                {
                    c.TimeProKmInSeconds=(int.Parse(this.prefferedTime.Text.Substring(0, this.prefferedTime.Text.IndexOf(":")))*60 + int.Parse(this.prefferedTime.Text.Substring(this.prefferedTime.Text.IndexOf(":") + 1)));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nieprawidłowy parametr, wprowadź czas według formatu [mm:ss]");
                    return;
                }
            }
            try
            {
                c.LengthOfLap = int.Parse(this.lengthOfLapT2.Text);
                c.NumberOfLaps = int.Parse(this.numberOfLapsT2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nieprawidłowy parametr, wprowadź wartość liczbową");
                return;
            }

            c.TimeForLapInSec = (int)(c.TimeProKmInSeconds * c.LengthOfLap) / 1000;
            c.calculateTimesForLaps();
            outputT2.Text += "\n\n";
            c.calculateDistance();
            if (c.NumberOfLaps > 1)
            {
                
                outputT2.Text += "    Całkowity dystans:\t" + c.Distance + " km\n";
            }
            c.calculateSpeed(c.TimeForLapInSec*c.NumberOfLaps);
            Console.WriteLine("speed= {0}, distance= {1}, time of lap in sec= {2}", c.Speed, c.Distance, c.TimeForLapInSec);
            outputT2.Text += "    Prędkość:\t" + c.Speed + " km/h\n\n";
            if (c.getTableTimesForLaps.Count > 1)
            {
                for (int i = 0; i < c.getTableTimesForLaps.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        outputT2.Text += "    Czas " + ((i / 2) + 1) + "-ego okrążenia :\t";
                        if ((int)c.getTableTimesForLaps[i] < 10)
                        {
                            outputT2.Text += 0;
                            outputT2.Text += (int)c.getTableTimesForLaps[i] + ":";
                        }
                        else if ((int)c.getTableTimesForLaps[i] > 60)
                        {
                            outputT2.Text += (int)c.getTableTimesForLaps[i] / 60 + ":";
                            if ((int)c.getTableTimesForLaps[i] - ((int)c.getTableTimesForLaps[i] / 60) * 60 < 10)
                            {
                                outputT2.Text += 0;
                            }
                            outputT2.Text += (int)c.getTableTimesForLaps[i] - ((int)c.getTableTimesForLaps[i] / 60) * 60 + ":";
                        }
                        else
                        {
                            outputT2.Text += (int)c.getTableTimesForLaps[i] + ":";
                        }

                        if ((int)c.getTableTimesForLaps[(i + 1)] < 10)
                        {
                            outputT2.Text += 0;
                        }
                        outputT2.Text += (int)c.getTableTimesForLaps[(i + 1)] + "\n";
                    }
                }
            }
            else
            {
                outputT2.Text += "    Czas okrążenia:\t";
                if (c.TimeForLapInSec / 60 < 10)
                    outputT2.Text += 0;
                outputT2.Text += c.TimeForLapInSec / 60+":";
                if (c.TimeForLapInSec % 60 < 10)
                    outputT2.Text += 0;
                outputT2.Text += c.TimeForLapInSec % 60;
            }
        }

        private void calculateT3_Click(object sender, EventArgs e)
        {
            resultT3.Clear();
            try
            {
                c.LengthOfLap = float.Parse(this.lapLengthT3.Text);
                c.NumberOfLaps = int.Parse(this.numberOfLapsT3.Text);
                try
                {
                    c.Speed = float.Parse(this.prefferedSpeed.Text);
                    c.calculateDistance();

                    c.TimeForLapInSec = (int)(((float)c.Distance / c.Speed) * 3600);
                    resultT3.Text += "\n\n\n\n";
                    if (!(c.LengthOfLap == 1000 && c.NumberOfLaps == 1))
                    {
                        resultT3.Text += "    Całkowity dystans:\t" + c.Distance + " km\n";
                        resultT3.Text += "    Całkowity czas:\t";
                        if (c.TimeForLapInSec / 60 < 10)
                            resultT3.Text += 0;
                        resultT3.Text += c.TimeForLapInSec / 60 + ":";
                        if (c.TimeForLapInSec % 60 < 10)
                            resultT3.Text += 0;
                        resultT3.Text += c.TimeForLapInSec % 60 + "\n";
                        if (c.NumberOfLaps > 1 && c.LengthOfLap != 1000)
                        {
                            c.TimeForLapInSec /= c.NumberOfLaps;
                            resultT3.Text += "    Czas okrążenia:\t";
                            if (c.TimeForLapInSec / 60 < 10)
                                resultT3.Text += 0;
                            resultT3.Text += c.TimeForLapInSec / 60 + ":";
                            if (c.TimeForLapInSec % 60 < 10)
                                resultT3.Text += 0;
                            resultT3.Text += c.TimeForLapInSec % 60 + "\n";
                        }
                    }
                    c.Distance = 1;
                    c.TimeForLapInSec = (int)(((float)c.Distance / c.Speed) * 3600);
                    resultT3.Text += "    Czas na 1 km:\t";
                    if (c.TimeForLapInSec / 60 < 10)
                        resultT3.Text += 0;
                    resultT3.Text += c.TimeForLapInSec / 60 + ":";
                    if (c.TimeForLapInSec % 60 < 10)
                        resultT3.Text += 0;
                    resultT3.Text += c.TimeForLapInSec % 60 + "\n";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Niewłaściwy format parametru, użyj przecinka do oddzielenia miejsc dziesiętnych");                    
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Niewłaściwy format parametru");                
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            output.Clear();
            outputT2.Clear();
            resultT3.Clear();
            lengthOfLap.ResetText();
            lengthOfLapT2.ResetText();
            lapLengthT3.Text="1000";
            numberOfLaps.Text="1";
            numberOfLapsT2.Text = "1";
            numberOfLapsT3.Text = "1";
            prefferedSpeed.ResetText();
            prefferedTime.ResetText();
            timeBox.ResetText();
            radioButtonTotalTime.Checked=true;
        }

        
    }
}
