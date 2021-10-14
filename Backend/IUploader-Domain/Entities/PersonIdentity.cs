using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUploader_Domain.Entities
{
    [Table("PersonIdentity", Schema = "Person")]
    public class PersonIdentity
    {
        [Key]
        public long Id { get; set; }
        public long PersonID { get; set; }
        public byte Type { get; set; }
        public string IdentityNo { get; set; }
        public string NationalID { get; set; }
        public string IssuedBy{ get; set; }
        public string Notes{ get; set; }
        public string Secretariat { get; set; }
        public string Address { get; set; }
        public string Registration { get; set; }
        public string RegistrationNo { get; set; }
        public string FaceColor { get; set; }
        public string EyeColor { get; set; }
        public string Diagnostics { get; set; }
        public string City { get; set; }
        public string Nationality { get; set; }
        public string IssueDate { get; set; }
        public string CustomReg { get; set; }
        public string CustomRegNo { get; set; }
    }
}
