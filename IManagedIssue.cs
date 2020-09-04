namespace Bam.Control
{
    public interface IManagedIssue
    {
        string Id { get; set; }
        string Title { get; set; }
        string Body { get; set; }
    }
}