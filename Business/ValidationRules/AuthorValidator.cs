using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
  public  class AuthorValidator:AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(a => a.AuthorName).NotEmpty().WithMessage("Yazar Adı Boş Geçilemez!").MinimumLength(3).WithMessage("Minimum 3 karekter girişi yapın!");
            RuleFor(a => a.AuthorAbout).NotEmpty().WithMessage("Yazar Bilgileri Boş Geçilemez!").MinimumLength(3).WithMessage("Minimum 3 karekter girişi yapın!");
        }
    }
}
