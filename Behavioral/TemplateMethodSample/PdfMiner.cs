namespace TemplateMethodSample;
public class PdfMiner : DataMiner
{
    protected override Dictionary<string, string> ExtractData(Stream fs)
    {
        return new Dictionary<string, string>()
        {
            { "FileType", "PDF" }
        };
    }

    protected override Stream OpenFile(string filePath)
    {
        return Stream.Null;
    }

    protected override void CloseFile(Stream stream)
    {
        stream.Dispose();
    }
}
