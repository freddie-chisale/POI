using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POI.HRMSApp.Entities.Models;

public class Employee
{
  [Column("EmployeeId")]
  public Guid Id { get; set; }

  [Required(ErrorMessage = "Firstname is required.")]
  [MaxLength(50, ErrorMessage = "Maximum length of firstname is 50 characters long")]
  public string? FirstName { get; set; }

  [Required(ErrorMessage = "Lastname is required.")]
  [MaxLength(50, ErrorMessage = "Maximum length of lastname is 50 characters long")]
  public string? LastName { get; set; }

  [ForeignKey(nameof(Department))]
  public Guid DepartmentId { get; set; }
  public Department? Department { get; set; }
}