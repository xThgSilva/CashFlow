using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Title).NotEmpty().WithMessage("O titulo não pode ser vazio.");
        RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("O valor deve ser maior que 0.");
        RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("A data não pode ser relacionada ao futuro.");
        RuleFor(expense => expense.PaymentType).IsInEnum().WithMessage("O tipo de pagamento é inválido.");
    }
}
