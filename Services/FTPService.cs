using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Tamir.SharpSsh;

namespace IQISService.Services
{
    public class FTPService
    {

        Sftp sftp;

        public FTPService()
        {
            sftp = new Sftp("", "", "");
            sftp.Connect();
        }

        public void connect()
        {
            if (!sftp.Connected)
            {
                
                sftp.Connect();
            }
            
        }

        public string uploadFile(string fileString,string bodyNo)
        {
            if (!sftp.Connected)
            {
               // sftp = new Sftp("10.114.24.71", "wasadmin", "Webapp01#");
                sftp.Connect();
            }


            //convert the filestring into byte array
            byte[] file = Convert.FromBase64String(fileString);

            //filename
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + DateTime.Now.Millisecond + "_" + bodyNo + ".JPG";

            string localpath = AppDomain.CurrentDomain.BaseDirectory  + fileName;
            string remotePath = "//wasapp//newIQIS//webpic//M//30//DEFCTIMG//1//" + fileName.Substring(0, 4) + "//" + fileName.Substring(4, 2) + "//" + fileName;

            File.WriteAllBytes(localpath, file);
            
            //transfer to was
            sftp.Put(localpath, remotePath);
            sftp.Close();

            //delete local file
            File.Delete(localpath);

            return fileName;
        }

        public string uploadFile(string fileString, string bodyNo, string path, string process)
        {
            if (!sftp.Connected)
            {
               
                sftp.Connect();
            }
            //convert the filestring into byte array
            byte[] file = Convert.FromBase64String(fileString);
            //filename
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + DateTime.Now.Millisecond + "_" + bodyNo + ".JPG";
            string localpath = "D:\\FeedbackData\\" + process + "\\" + DateTime.Now.Year.ToString() + "\\" + DateTime.Now.Month.ToString() + "\\" + fileName;
            bool exist = System.IO.Directory.Exists("D:\\FeedbackData\\" + process + "\\" + DateTime.Now.Year.ToString() + "\\" + DateTime.Now.Month.ToString() + "\\");
            if (!exist)
                System.IO.Directory.CreateDirectory("D:\\FeedbackData\\" + process + "\\" + DateTime.Now.Year.ToString() + "\\" + DateTime.Now.Month.ToString() + "\\");

            File.WriteAllBytes(localpath, file);

            //transfer to was
            sftp.Put(localpath, "//wasapp//newIQIS//webpic"+path);
            sftp.Close();
            //delete local file
            //File.Delete(localpath);

            return fileName;
        }

        public string downloadFile(string fileName)
        {
            if (fileName.Equals(" "))
            {
                return "";
            }
            else
            {
                if (!sftp.Connected)
                {
                  
                    sftp.Connect();
                }
                string localpath = AppDomain.CurrentDomain.BaseDirectory  + fileName;
                string remotePath = "//wasapp//newIQIS//webpic//M//30//DEFCTIMG//1//" + fileName.Substring(0, 4) + "//" + fileName.Substring(4, 2) + "//" + fileName;
                sftp.Get(remotePath, localpath);


                string fileString = Convert.ToBase64String(File.ReadAllBytes(localpath));


                sftp.Close();
                File.Delete(localpath);
                return fileString;
            }
           
        }


    }
}