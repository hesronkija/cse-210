using System.IO;

class FileManager
{
    public string ReadFromFile(string fileName)
    {
        string journalText = File.ReadAllText(fileName);
        
        return journalText;
    }

    public void Save(string fileName, string content)
{
    if (!File.Exists(fileName))
    {
        File.WriteAllText(fileName, content);
    }
    else
    {
        File.AppendAllText(fileName, $"\n{content}\n");
    }
}

}
