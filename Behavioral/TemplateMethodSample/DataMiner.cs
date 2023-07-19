namespace TemplateMethodSample;
public abstract class DataMiner
{
    public void Mine(string filePath)
    {
        Stream fs = OpenFile(filePath);
        Dictionary<string, string> data = ExtractData(fs);
        string analysis = AnalyzeData(data);
        SendReport(analysis);
        CloseFile(fs);
    }

    protected abstract Stream OpenFile(string filePath);
    protected abstract Dictionary<string, string> ExtractData(Stream stream);

    private string AnalyzeData(Dictionary<string, string> data)
    {
        return data["FileType"];
    }
    private void SendReport(string analysis)
    {
        Console.WriteLine($"Report sent with analysis = '{analysis}'");
    }

    protected abstract void CloseFile(Stream fs);
}