using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;


public class TextFileModel
{
    DirectoryInfo d = new DirectoryInfo(@"C:\Users\Hollerup\Documents\Visual Studio 2013\Projects\WebSite4\TextFiler\");


	public void ChangeTxtFile(string fileText, string filename)
    {
        FileInfo[] Files = d.GetFiles("*.txt");

        foreach (FileInfo file in Files)
        {
            if (file.Name.Equals(filename))
            {
                try
                {
                    using (StreamWriter writer = file.CreateText())
                    {
                        writer.WriteLine(fileText);
                    }
                }
                catch (FileNotFoundException e)
                {
                    throw e;
                }
            }
        }
	}

    public string getTxtFile(string filename)
    {
        FileInfo[] Files = d.GetFiles("*.txt");
        String text = null;

        foreach (FileInfo file in Files)
        {
            if (file.Name.Equals(filename))
            {
                try
                {
                    using (StreamReader read = file.OpenText())
                    {
                        text = read.ReadToEnd();
                        return text;
                    }
                }
                catch (FileNotFoundException e)
                {
                    throw e;
                }
            }
        }
        return text;
    }

    public List<string> getAllFileNames()
    {
        DirectoryInfo d = new DirectoryInfo(@"C:\Users\Hollerup\Documents\Visual Studio 2013\Projects\WebSite4\TextFiler\");
        List<string> filenames = new List<string>();
        FileInfo[] Files;

        try
        {
            Files = d.GetFiles("*.txt");
        }
        catch(FileNotFoundException e)
        {
            throw e;
        }
        if (Files != null)
        {
            foreach (FileInfo file in Files)
            {
                filenames.Add(file.Name);
            }
        }
       
        return filenames;
    }
}