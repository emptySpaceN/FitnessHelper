using System;
using System.IO;
using System.Windows.Forms;

namespace FitnessHelper
{
    class FileLocking
    {
        private FileStream configurationFile;
        public FileStream LockedFile
        {
            get
            {
                configurationFile.Position = 0;
                return configurationFile;
            }
        }


        public void Dispose()
        {
            configurationFile.Dispose();
        }


        public bool ReadFile(string _FilePath, ref int _ErrResult)
        {
            try
            {
                FileHandling_Ini test = new FileHandling_Ini(_FilePath);
                MessageBox.Show((test.IniReadValue("FileLocking", "CurrentUser")));

                return true;
                //configurationFile.Unlock(1, configurationFile.Length);
                //using (FileStream bufferStream = new FileStream(_FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                //{
                //    using (StreamReader sr = new StreamReader(bufferStream))
                //    {
                //        string line;
                //        while ((line = sr.ReadLine()) != null)
                //        {
                //            CustomMessageBox.Show(line);
                //        }
                //    }




                //    ////// In my case it always the case, o/w you can read file line-by-line 
                //    ////byte[] fileBytes = new byte[bufferStream.Length];

                //    ////int amountOfBytes = bufferStream.Read(fileBytes, 0, (int)bufferStream.Length);

                //    ////System.Text.UTF7Encoding utf7 = new System.Text.UTF7Encoding();

                //    ////string errorFileContext = utf7.GetString(fileBytes, 0, amountOfBytes);

                //    ////CustomMessageBox.Show(errorFileContext);




                //    int currentUserIndex = Array.FindIndex(iniFileContent, row => row.Contains(_IniFileKey));

                //    string currentUser = iniFileContent[currentUserIndex].Substring(_IniFileKey.Length, iniFileContent[currentUserIndex].Length - _IniFileKey.Length);
                //    CustomMessageBox.Show("The current user of the application is: " + test.IniReadValue("Test", "CurrentUser"));
                //}
                //return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "test");
                _ErrResult = err.HResult;
                return false;
            }
        }


        public bool OpenAndLock(string _FilePath, FileAccess _FileAccessMode, FileShare _FileShareMode, ref int _ErrResult)
        {
            try
            {
                configurationFile = new FileStream(_FilePath, FileMode.Open, _FileAccessMode, _FileShareMode);
                return true;
            }
            catch (Exception err)
            {
                _ErrResult = err.HResult;
                return false;
            }
        }


        public bool CreateAndLock(string _FilePath, FileAccess _FileAccessMode, FileShare _FileShareMode, ref int _ErrResult)
        {
            try
            {
                configurationFile = new FileStream(_FilePath, FileMode.CreateNew, _FileAccessMode, _FileShareMode);
                return true;
            }
            catch (Exception err)
            {
                _ErrResult = err.HResult;
                return false;
            }
        }
    }
}
