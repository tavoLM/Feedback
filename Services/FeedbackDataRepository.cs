using IQISService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IQISService.Services
{
    public class FeedbackDataRepository
    {
        private feedbackEntities db = new feedbackEntities();

        public FeedbackDto Post(FeedbackDto feedback)
        {
            try
            {
                //set picture name
                string serverPath = "//M/30//FBACKIMG//1//" + DateTime.Now.Year.ToString() + "//" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "//";
                FTPService ftpService = new FTPService();

                //load picture to server
                string pictureName = ftpService.uploadFile(feedback.imageString, string.Concat(feedback.CAR_TYPE, feedback.BODY_NO), serverPath, feedback.PROCESS);
                feedback.PICTURE = pictureName;
                feedback.PICTUREPATH = serverPath;

                feedback.STDT = getSTDT();
                feedback.ENDT = feedback.STDT.Value.AddDays(1);
                feedback.RGDT = DateTime.Now;
                feedback.ROUND = getRound();
                feedback.SHIFT = getShift();

                FEEDBACK_DATA fd = new FEEDBACK_DATA();
                AutoMapper.Mapper.Map(feedback, fd);

                db.FEEDBACK_DATA.Add(fd);
                db.SaveChanges();

            }
            catch (Exception ex) { return new FeedbackDto(); }
            

            return feedback;
        }

        public FeedbackDto Put(FeedbackDto feedback)
        {
            try
            {
                //set picture name
                string serverPath = "//M/30//FBACKIMG//1//" + DateTime.Now.Year.ToString() + "//" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "//";
                FTPService ftpService = new FTPService();

                //load picture to server
                string pictureName = ftpService.uploadFile(feedback.imageString, string.Concat(feedback.CAR_TYPE, feedback.BODY_NO), serverPath, feedback.PROCESS);
                feedback.PICTURE = pictureName;
                feedback.PICTUREPATH = serverPath;

                feedback.STDT = getSTDT();
                feedback.ENDT = feedback.STDT.Value.AddDays(1);
                feedback.RGDT = DateTime.Now;
                feedback.ROUND = getRound();
                feedback.SHIFT = getShift();

                FEEDBACK_DATA fd = new FEEDBACK_DATA();
                AutoMapper.Mapper.Map(feedback, fd);

                db.Entry(fd).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                

            }
            catch (Exception ex) { return new FeedbackDto(); }
            return feedback;
        }

        private DateTime getSTDT()
        {
            DateTime dTime = DateTime.Now;            

            TimeSpan start_time = db.rounds.Where(r => r.Round1 == 1 && r.Shift.Equals("1")).Select(s => s.Start_time).SingleOrDefault();

            if (dTime.TimeOfDay < start_time)
            {
                return DateTime.Now.AddDays(-1);
            }
            else
            {
                return dTime;
            }

        }

        private string getRound()
        {
            TimeSpan dTime = DateTime.Now.TimeOfDay;
            int round = db.rounds.Where(r => r.Start_time <= dTime && r.Finish_time >= dTime).Select(s => s.Round1).SingleOrDefault();

            if (round == 0)
            {
                round = db.rounds.Where(r => r.Start_time > r.Finish_time && (r.Start_time <= dTime || r.Finish_time > dTime)).Select(s => s.Round1).SingleOrDefault();
            }

            return round.ToString();
        }

        private int getShift()
        {
            TimeSpan dTime = DateTime.Now.TimeOfDay;
            string shift = db.rounds.Where(r => r.Start_time <= dTime && r.Finish_time > dTime).Select(s => s.Shift).SingleOrDefault();
            
            if (string.IsNullOrEmpty(shift))
            {
                shift = db.rounds.Where(r => r.Start_time > r.Finish_time && (r.Start_time <= dTime || r.Finish_time > dTime)).Select(s => s.Shift).SingleOrDefault();
            }

            return Convert.ToInt32(shift);
        }
    }
}