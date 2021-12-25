using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CurrentValidation : AbstractValidator<Currents>
    {
        public CurrentValidation()
        {
            RuleFor(x => x.CurrentName).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.CurrentNo).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.CurrentTitle).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.Adress1).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.TaxOffice).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.Id_TaxNo).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.CurrentPhone).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.CurrentMail).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.AuthorizedName1).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.AuthorizedDepartment).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.AuthorizedMPhone1).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.AuthorizedPhone1).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
            RuleFor(x => x.AuthorizedMail1).NotEmpty().WithMessage("{0} Boş Geçirelemez.");
        }
    }
}
