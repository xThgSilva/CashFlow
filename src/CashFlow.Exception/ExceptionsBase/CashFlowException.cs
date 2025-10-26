namespace CashFlow.Exception.ExceptionsBase;

public class CashFlowException : SystemException
{
    protected CashFlowException(string? message) : base(message)
    {
    }
}
