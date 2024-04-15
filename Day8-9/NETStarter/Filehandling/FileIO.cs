class FileIO
{
    public void Createfile()
    {
        string folderPath = @"D:\Traineeship\Day8-9\NETStarter\Filehandling";
        string fileName="student.txt";
        string filePath=Path.Combine(folderPath,fileName);
        File.WriteAllText(filePath,"This is first line");
    }
    public void CreateFileWithInFolder()
    {
        string newFolderName = "Student";
        Directory.CreateDirectory(newFolderName);
        string fileName="student1.txt";
        string filePath=Path.Combine(folderPath, newFolderName, fileName);
        File.WriteAllText(filePath,"This is first line");
    }
}