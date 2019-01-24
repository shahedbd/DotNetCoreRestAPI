using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Entity
{
    public class PersonalInfoMySQL
    {
        public long id { get; set; }
        [DisplayName("First Name")]
        public string first_name { get; set; }
        [DisplayName("Last Name")]
        public string last_name { get; set; }
        [DisplayName("Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<DateTime> date_of_birth { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        [DisplayName("Mobile No")]
        public string mobile_no { get; set; }
        public string nid { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? last_modified_date { get; set; }
        public string creation_user { get; set; }
        public string last_update_user { get; set; }
        public byte status { get; set; }
    }
}
