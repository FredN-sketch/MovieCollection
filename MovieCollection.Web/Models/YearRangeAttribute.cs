using System.ComponentModel.DataAnnotations;

namespace MovieCollection.Web.Models
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class YearRangeAttribute : RangeAttribute
    {
        public YearRangeAttribute(int minimum) : base(minimum, DateTime.Now.Year)
        {
        }
    }
}
