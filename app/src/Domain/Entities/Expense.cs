namespace Domain.Entities;
public class Expense : BaseEntity<int>
{
    public string Description { get; set; } = String.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Amount { get; set; }
    public bool Status { get; set; }

}
