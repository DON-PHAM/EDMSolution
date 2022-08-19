using EDMSolution.Utilities.Contants;
using EDMSolution.ViewModels.System.Roles.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.ViewModels.System.Roles.Validations
{
    public class CreateRoleRequestValidator : AbstractValidator<CreateRoleRequest>
    {
        public CreateRoleRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(Message.MSG1);
            RuleFor(x => x.RoleType).NotEmpty().WithMessage(Message.MSG1);
            RuleFor(x => x).Custom((rq, context) =>
            {
                if (rq.RoleType == (int)UnitRole.CaNhan)
                {
                    if (rq.ParentId == null)
                    {
                        context.AddFailure("ParentId", Message.MSG1);
                    }
                }
            });
        }
        
    }
}
