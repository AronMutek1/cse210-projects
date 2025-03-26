public class Reference
{
    public string ReferenceText { get; set; }

    // Constructor for single verse or verse range
    public Reference(string referenceText)
    {
        ReferenceText = referenceText;
    }
}
