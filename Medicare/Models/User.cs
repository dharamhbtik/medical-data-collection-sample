using System;
namespace Medicare.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string SourceType { get; set; }
        public string SourceName { get; set; }

        public  string ToDataString()
        {
            return $"Name : {this.FullName}, Address : {this.Address}, Email : {this.EmailAddress}";
        }
    }
}
