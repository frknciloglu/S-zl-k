using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçilemez");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçilemez");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen max 100 karakter giriniz");

        }

    }
}
