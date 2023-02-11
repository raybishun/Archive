using System.Data;
using System.Web.Services;
using Newtonsoft.Json;

namespace WebSvc
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Sum(int a, int b)
        {
            return a + b;
        }

        DataTable Countries = new DataTable();

        [WebMethod]
        public string GetCountries()
        {
            Countries.Columns.Add("CountryName");
            Countries.Columns.Add("Continent");

            Countries.Rows.Add("Canada", "North America");
            Countries.Rows.Add("United States", "North America");
            Countries.Rows.Add("Mexico", "North America");
            Countries.Rows.Add("Brazil", "South America");
            Countries.Rows.Add("China", "Asia");

            return JsonConvert.SerializeObject(Countries);
        }
    }
}
