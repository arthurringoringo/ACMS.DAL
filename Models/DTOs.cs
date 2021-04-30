using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace ACMS.DAL.Models
{
    public partial class AvailableClassDTO
    {

        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<PaidSession> PaidSessions { get; set; }
        public virtual ICollection<RegistredClass> RegistredClasses { get; set; }
        public virtual ICollection<SessionSchedule> SessionSchedules { get; set; }
    }
    public partial class AvailableClassDGO
    {

        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string TeacherId { get; set; }
    }
    public partial class ClassCategoryDTO : Entity, IAggregateRoot
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal? IncomeInstructor { get; set; }
        public decimal? IncomeAiu { get; set; }
        public decimal? TotalTutionFee { get; set; }
        public decimal? DiscountedFee { get; set; }
    }
    public partial class ClassCategoryDGO 
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
   
    }
    public partial class ClassReportDTO : Entity, IAggregateRoot
    {

        public string ClassReportId { get; set; }
        public string Remarks { get; set; }
    }
    public partial class PaidSessionDTO
    {
        //public Guid StudentId { get; set; }
        //[Required(ErrorMessage ="Please select your class.")]
        //public Guid ClassId { get; set; }
        [Required(ErrorMessage = "Please select your class.")]
        public string RegistredClassId{ get; set; }
        public string PictureLink { get; set; }
        [Required(ErrorMessage = "Please Select the month")]
        public string PaymentsMonth { get; set; }
        [Required(ErrorMessage = "Please Select A photo")]
        public MemoryStream Image{ get; set; }
    }
    public partial class PaidSessionDTOs
    {
        [Required(ErrorMessage = "Please select your class.")]
        public string RegistredClassId { get; set; }

        public string PictureLink { get; set; }
        [Required(ErrorMessage = "Please Select the month")]
        public string PaymentsMonth { get; set; }
        [Required(ErrorMessage = "Please Select A photo")]
        public IFormFile Image { get; set; }



    }
    public partial class PaymentMethodDTO : Entity, IAggregateRoot
    {

        public string PaymentMethodId { get; set; }
        public string MethodName { get; set; }
        public int? Terms { get; set; }
    }

    public partial class RegistredClassDTO
    {

        public string StudentId { get; set; }
        [Required(ErrorMessage ="Please Select a Category")]
        public string CategoryId { get; set; }
        [Required(ErrorMessage = "Please Select a Class")]

        public string ClassId { get; set; }
        
        public DateTime? AssessmentDate { get; set; }
        //public string Day { get; set; }
        //public TimeSpan? Time { get; set; }
        [Required(ErrorMessage = "Please Select a Payment Method")]

        public string PaymentMethodId { get; set; }

    }
    public partial class SessionScheduleDTO : Entity, IAggregateRoot
    {
        public string ScheduleId { get; set; }
        public string TeacherId { get; set; }
        public string ClassId { get; set; }
        public string StudentId { get; set; }
        public TimeSpan? Time { get; set; }
        public string Day { get; set; }
        public string Remarks { get; set; }
    }
    public partial class StudentDTO : Entity, IAggregateRoot
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Sex { get; set; }
        public string ParentGuardianName { get; set; }
        public string Address { get; set; }
        public string HomeNumber { get; set; }
        public string SchoolName { get; set; }
        public int UserId { get; set; }
    }
    public partial class TeacherDTO : Entity, IAggregateRoot
    {
        public string TeacherId { get; set; }
        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string HomeNumber { get; set; }
        public int UserId { get; set; }
    }
    public class EmailDto
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Cc{ get; set; }

    }



}
