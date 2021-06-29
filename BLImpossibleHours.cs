using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{ 
    public class BLImpossibleHours
    {
        //private Days Day;
        public int Day { get; set; }
        public int Hour { get; set; }
        public BLImpossibleHours(int d, int h)
        {
            Day = d;
            Hour = h;
        }
        public BLImpossibleHours()
        {
        }
        /// <summary>
        /// פונקציה המחזירה רשימה של שעות לא אפשריות לפי מורה
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static List<BLImpossibleHours> GetNotPosibleHours(teacher t)
        {
            SchedulingEntities schoolEntities = new SchedulingEntities();
            try { 
            List<ImpossibleHour> list = schoolEntities.ImpossibleHours.Where(i => i.codeTeach == t.code).ToList();
            List<BLImpossibleHours> newl = new List<BLImpossibleHours>();
                foreach (var item in list)
                {
                        newl.Add(new BLImpossibleHours((int)item.day, (int)item.hourOfTheDay));
                }
           return newl;
             } catch { return null; }
           
        }
        /// <summary>
        /// מחזיר true or false האם השעה הזו אפשרית למורה הזו
        /// </summary>
        /// <param name="code"></param>
        /// <param name="d"></param>
        /// <param name="hour"></param>
        /// <returns></returns>
        public static bool FitsToTeacher(int code, int d, int hour)
        {
            SchedulingEntities schoolEntities = new SchedulingEntities();
            ImpossibleHour list = schoolEntities.ImpossibleHours.ToList().Find(i => i.codeTeach ==code);
                if ((list.day == d) && (list.hourOfTheDay == hour))
                    return true; 
            return false;
        }
        /// <summary>
        /// הפונקציה מוחקת שעה בלתי אפשרית שנשלחה כפרמטר
        /// </summary>
        /// <param name="n"></param>
        /// <param name="t"></param>
        public static void Remove(BLImpossibleHours n, teacher t)
        {
            SchedulingEntities schoolEntities = new SchedulingEntities();
            ImpossibleHour NPH = schoolEntities.ImpossibleHours.Where(i => i.day == n.Day).Where(i => i.hourOfTheDay == n.Hour).Where(i => i.codeTeach == t.code).First();
            try
            {
                schoolEntities.ImpossibleHours.Remove(NPH);
                schoolEntities.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        /// <summary>
        /// מוסיפה לבסיס הנתונים את את השעה הבלתי אפשרית שנשלחה עליה
        /// </summary>
        /// <param name="code"></param>
        /// <param name="d"></param>
        /// <param name="hour"></param>
        /// <returns></returns>
        public static void AddNotPosiblHour(BLImpossibleHours n, teacher t)
        {
            SchedulingEntities schoolEntities = new SchedulingEntities();
            ImpossibleHour NPH = new ImpossibleHour() { day = n.Day, hourOfTheDay = n.Hour, codeTeach = t.code };
            try
            {
                schoolEntities.ImpossibleHours.Add(NPH);
                schoolEntities.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        /// <summary>
        /// מחזירה true or false אם התאריך הזה קיים ברשימת השעות הבלתי אפשריות
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool NPHExists(int d, int h, teacher t)
        {
            if (GetAllNPH(t).ToList().Find(j => j.day == d && j.hourOfTheDay == h) != null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// מחזירה רשימה של שעות בלתי אפשריות עפ"י מורה שהתקבל
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static List<ImpossibleHour> GetAllNPH(teacher t)
        {
            SchedulingEntities schoolEntities = new SchedulingEntities();
               return schoolEntities.ImpossibleHours.Where(i => i.codeTeach == t.code).ToList();
        }
        /// <summary>
        /// מחזיר שם מורה עפ"י הקוד שלה
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
    public static string getCodeByTeach(int code)
     {
    SchedulingEntities schoolEntities = new SchedulingEntities();
     string s= schoolEntities.ImpossibleHours.ToList().Find(i => i.codeTeach == code).ToString();
    return s;
     }
}

}