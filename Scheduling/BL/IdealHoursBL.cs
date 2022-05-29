using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class IdealHoursBL
    {
        
    /// <summary>
    /// checks if the hour is ideal for the teacher
    /// </summary>
    /// <param name="code"></param>
    /// <param name="codeH"></param>
    /// <returns></returns>
        public static bool FitsToProff(int code,int codeH )
        {
            SchedulingEntities schoolEntities = new SchedulingEntities();
            List<IdealHour> list = schoolEntities.IdealHours.Where(i => i.codeProf == code).ToList();
            foreach (var item in list)

                if ((item.numOfHours == codeH))
                    return true;

            return false;
        }
    }
}
