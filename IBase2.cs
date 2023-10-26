namespace Lab3_23.Models.Base
{
    public interface IBase2
    {
        Guid Id { get; set; }
        DateTime? DateTime { get; set; }
        DateTime? LastModified { get; set; }
    }
}
