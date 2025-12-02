using AITech.WebUI.DTOs.ProjectDtos;
using FluentValidation;
using Microsoft.AspNetCore.Rewrite;

namespace AITech.WebUI.Validators
{
    public class ProjectValidator: AbstractValidator<CreateProjectDto>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("başlık boş bırakılamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("resim boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("kategori boş bırakılamaz");
        }
    }
}
