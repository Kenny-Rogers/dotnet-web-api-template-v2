using System.ComponentModel.DataAnnotations;

namespace WebProject.Template.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}