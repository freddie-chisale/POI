using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POI.HRMSApp.Entities.Models;

public class Department
{
  [Column("DepartmentId")]
  public Guid Id { get; set; }

  [Required(ErrorMessage = "DepartmentName is required.")]
  [MaxLength(50, ErrorMessage = "Maximum length of departmentName is 50 characters long")]
  public string? DepartmentName { get; set; }

  public ICollection<Employee>? Employees { get; set; }
}