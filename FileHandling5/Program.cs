class Example
{
    public static void Main()
    {
        DirectoryInfo currDir = new DirectoryInfo(@"C:\Users\sport\Documents\ACS\Others\Copy");

        currDir.Create();

        string path = @"C:\Users\sport\Documents\ACS\Others\Copy\copy.txt";
        string path2 = @"C:\Users\sport\Documents\ACS\Others\Copy\paste.txt";


        try
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }

            if (File.Exists(path2))
            {
                File.Delete(path2);
            }

            File.Copy(path, path2);
            Console.WriteLine($"File '{path}' has been copied and pasted to '{path2}'");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }

}



