namespace CashFlow.Exception.ExceptionsBase;

public class CashFlowException : SystemException
{
    public CashFlowException(string? message) : base(message)
    {
    }
}
