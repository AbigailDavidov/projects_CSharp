using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{ 
    public class BLProffesion
    {
        static SchedulingEntities schoolEntities = new SchedulingEntities();

        /// <summary>
        /// returns profession list
        /// </summary>
        /// <returns> techer list</returns>
        public static List<Profession> GetAllSubjects()
        {
            return schoolEntities.Professions.ToList();
        }

        /// <summary>
        /// removes profession from the list
        /// </summary>
        /// <param name="s"></param>
        public static void Remove(Profession s)
        {
            try
            {
                schoolEntities.Professions.Remove(s);
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
        ///  adds profession
        /// </summary>
        public static bool Add(Profession s)
        {
            try
            {
                schoolEntities.Professions.Add(s);
                schoolEntities.SaveChanges();
                return true;
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
                return false;
            }
            
        }

       /// <summary>
       /// returs code of profession  
       /// </summary>
       /// <param name="prof"></param>
       /// <returns></returns>
        public static Profession GetMember(string prof)
        {
            SchedulingEntities schoolEntities = new SchedulingEntities();
            var r = schoolEntities.Professions.ToList();
            Profession code = r.Find(a => a.professionName == prof);
          
            return code;

        }
    }
}
