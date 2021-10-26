

using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(b => b.BlogTitle).NotEmpty().WithMessage("Blog Başlığı Boş Geçilemez!").MinimumLength(3).WithMessage("Minimum 3 karekter girişi yapın!");
            RuleFor(b => b.BlogContent).NotEmpty().WithMessage("Blog İçeriği Boş Geçilemez!").MinimumLength(3).WithMessage("Minimum 3 karekter girişi yapın!");
        }
    }
}
