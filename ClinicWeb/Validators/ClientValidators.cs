using FluentValidation;
using ClinicWeb.Models;

namespace ClinicWeb.Validators
{

    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("ФИО обязательно для заполнения")
                .MaximumLength(150).WithMessage("ФИО не должно превышать 150 символов");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Телефон обязателен")
                .Matches(@"^\+?[0-9\s\-()]{10,20}$").WithMessage("Введите корректный номер телефона");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Некорректный формат Email")
                .MaximumLength(100).WithMessage("Email не более 100 символов");
        }
    }
}