using Composite_Pattern;

public interface DocumentComponent
{
    void Add(DocumentComponent component);
    void Remove(DocumentComponent component);
    void Display(int value);
}


class Program
{
    static void Main(string[] args)
    {
        Document document = new Document();

        Section section1 = new Section("Введение");
        section1.Add(new Paragraph("параграф введения №1."));
        section1.Add(new Paragraph("параграф введения №2."));
        section1.Add(new Paragraph("параграф введения №3."));
        section1.Add(new Paragraph("параграф введения №4."));

        Section section2 = new Section("Методы");
        section2.Add(new Paragraph("параграф методов №1."));
        section2.Add(new Paragraph("параграф методов №2."));

        Section subsection = new Section("Термины");
        subsection.Add(new Paragraph("параграф раздела терминов в разделе Методов."));
        section2.Add(subsection);

        document.Add(section1);
        document.Add(section2);

        document.Display(0);
    }
}