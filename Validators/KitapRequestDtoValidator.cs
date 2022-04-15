using BootcampAPIProje.DTOs;
using FluentValidation;

namespace BootcampAPIProje.Validators
{
    public class KitapRequestDtoValidator : AbstractValidator<KitapRequestDto>
    {
        public KitapRequestDtoValidator()
        {
            RuleFor(x => x.KitapAdi).NotNull().WithMessage("Kitap adı alanı boş olamaz").NotEmpty().WithMessage("Kitap adı alanı boş olamaz");

            RuleFor(x => x.YazarAdi).NotNull().WithMessage("Yazar adı alanı boş olamaz");
        }
    }
}