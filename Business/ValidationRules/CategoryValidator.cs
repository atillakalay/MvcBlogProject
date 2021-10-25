using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).MaximumLength(50).WithMessage("Maximum 50 karekter girişi yapın!").MinimumLength(3).WithMessage("Minimum 3 karekter girişi yapın!").NotEmpty().WithMessage("Kategori Adı Boş Geçilemez!");
            RuleFor(c => c.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklaması Boş Geçilemez!");
        }
    }
}