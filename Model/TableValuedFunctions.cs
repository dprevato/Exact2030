using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

[NotMapped]
public class ActiveGuard(string fullName)
{
    public string FullName { get; set; } = fullName;
}
