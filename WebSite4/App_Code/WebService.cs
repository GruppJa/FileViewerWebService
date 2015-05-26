using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.IO;
using System.Data;
using System.Data.SqlClient;

[WebService(Namespace = "http://SuperErdogan.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class WebService : System.Web.Services.WebService {

    DirectoryInfo d = new DirectoryInfo(@"C:\Users\Hollerup\Documents\Visual Studio 2013\Projects\WebSite4\TextFiler\");
    TextFileModel model = new TextFileModel();

    public WebService () {

    }
    
    [WebMethod]
    public string getTxtFile(string filename)
    {
        try 
        { 
            string text = model.getTxtFile(filename);
            return text;
        }
        catch(SoapException e)
        {
            throw e;
        }
        catch(FileNotFoundException e)
        {
            throw e;
        }
        catch(Exception e)
        {
            throw e;
        }
    }

    [WebMethod]
    public List<string> getAllFileNames()
    {
        try
        {
            List<string> filenames = model.getAllFileNames();
            return filenames;
        }
        catch (SoapException e)
        {
            throw e;
        }
        catch (FileNotFoundException e)
        {
            throw e;
        }
        catch (Exception e)
        {
            throw e;
        }      
    }

    [WebMethod]
    public void ChangeTxtFile(string fileText, string filename)
    {
        try
        {
            model.ChangeTxtFile(fileText, filename);
        }
        catch (SoapException e)
        {
            throw e;
        }
        catch (FileNotFoundException e)
        {
            throw e;
        }
        catch (Exception e)
        {
            throw e;
        } 
    }
}
