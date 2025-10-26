﻿using CashFlow.Communication.Enums;

namespace CashFlow.Communication.Responses;

public class ResponseExpenseJson
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public PaymentType PaymentType { get; set; }
}
