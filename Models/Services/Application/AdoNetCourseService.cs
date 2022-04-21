namespace MyCourse.Models.Services.Application 
{
    public class AdoNetCourseService : ICourseService
    {
        private readonly IDatabaseConnection db;
        
        public AdoNetCourseService(IDatabaseConnection db) 
        {
            this.db = db;
        }
    }
}