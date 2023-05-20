using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatorialProblem
{
    internal class DbSaving
    {
        public void SaveException(Exception ex)
        {
            using (PlacingContext db = new PlacingContext())
            {
                UserException exception = new UserException
                {
                    Message = ex.Message,
                    TargetSite = ex.TargetSite.ToString(),
                    DateTimeExc = DateTime.Now
                };
                db.UserExceptions.AddRange(exception);
                db.SaveChanges();
            }
        }
        public void SaveResult(int holesCount, int ballsCount, int res)
        {
            using (PlacingContext db = new PlacingContext())
            {
                Result result1 = new Result
                {
                    HolesCount = holesCount,
                    BallsCount = ballsCount,
                    Result1 = res,
                    DateTime = DateTime.Now
                };
                db.Results.AddRange(result1);
                db.SaveChanges();
            }
        }
    }
}
