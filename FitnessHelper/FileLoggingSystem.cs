﻿using System;
using System.IO;

namespace FitnessHelper
{
    class FileLoggingSystem
    {
        #region Variables
        private string eventFile = "protocoll.log";
        #endregion


        public void CheckForLogFile()
        {
            if (!File.Exists(eventFile))
            {
                using (StreamWriter sw = File.CreateText(eventFile))
                {
                    sw.WriteLine(DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss:ms] ") + "Logging file created");
                }
            }
        }


        public void Log(string _loggingText)
        {
            if (File.Exists(eventFile))
            {
                using (StreamWriter sw = File.AppendText(eventFile))
                {
                    sw.WriteLine(DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss:ms] ") + _loggingText);
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(eventFile))
                {
                    sw.WriteLine(DateTime.Now.ToString("[yyyy.MM.dd - hh:mm:ss] ") + "Logging file created");
                    sw.WriteLine(DateTime.Now.ToString("[yyyy.MM.dd - hh:mm:ss] ") + _loggingText);
                }
            }
        }
    }
}
