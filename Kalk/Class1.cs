using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalk
{
    class Class1
    {
        private float m_distance;
        private float m_speed;
        private string m_date;
        private float m_lapLength;
        private int m_numberOfLaps;
        private int m_minutesOfRun;
        private int m_secondsOfRun;
        private int m_minutesOfLap;
        private int m_secondsOfLap;
        private int m_timeForLapInSec;
        private int m_currentLapTime;
        private int m_timeProKmInSec;
        private float m_prefferedSpeed;
        private System.Collections.ArrayList tab;

       

        public float Distance
        {
            get { return m_distance; }
            set { m_distance = value; }
        }
        public float Speed 
        {
            get { return m_speed; }
            set { m_speed = value; }
        }
        public string Date
        {
            get { return m_date; }
            set { m_date = value; }
        }
        public float LengthOfLap
        {
            get { return m_lapLength; }
            set { m_lapLength = value; }
        }
        public int NumberOfLaps 
        {
            get { return m_numberOfLaps; }
            set { m_numberOfLaps = value; }
        }
        public int MinutesOfRun
        {
            get { return m_minutesOfRun; }
            set { m_minutesOfRun = value; }
        }
        public int SecondsOfRun
        {
            get { return m_secondsOfRun; }
            set { m_secondsOfRun = value; }
        }
        public int MinutesOfLap
        {
            get { return m_minutesOfLap; }
            set { m_minutesOfLap = value; }
        }
        public int SecondsOfLap
        {
            get { return m_secondsOfLap; }
            set { m_secondsOfLap = value; }
        }
        public int TimeForLapInSec
        {
            get { return m_timeForLapInSec; }
            set { m_timeForLapInSec = value; }
        }
        public int TimeProKmInSeconds
        {
            get { return m_timeProKmInSec; }
            set { m_timeProKmInSec = value; }
        }
        public float PrefferedSpeed
        {
            set { m_prefferedSpeed = value; }
        }
        public System.Collections.ArrayList getTableTimesForLaps
        {
            get { return tab; }
        }

        public Class1()
        {
           
        }
        public void calculateSpeed(int totaltime)
        {
            m_speed = (m_distance * 1000 / (float)totaltime) * 3.6f;
        }
        public void calculateDistance()
        {
            m_distance = (float)(m_lapLength * (float)m_numberOfLaps) / 1000;
        }

        public void calculateTimesForLaps()
        {
            tab = new System.Collections.ArrayList();
            m_currentLapTime = m_timeForLapInSec;
            for (int i = 0; i < NumberOfLaps; i++)
            {
                tab.Add((int)(m_currentLapTime / 60));
                tab.Add((int)(m_currentLapTime % 60));
                m_currentLapTime += m_timeForLapInSec;
            }
        }
        
    }
}
