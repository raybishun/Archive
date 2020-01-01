using System;

namespace Ch01_WelcomeDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


/*
*** In the C# Interactive Window type:
    
#r "System.Net.Http"
using System.Net.Http; 

// declare & instantiate an HTTP client variable
var client = new HttpClient(); 

// set the client's base address
client.BaseAddress = new Uri("http://www.microsoft.com/");

// asynchronously wait for a response to a GET request
var response = await client.GetAsync("about");

// read the status code returned by the web server
response.StatusCode


// read the content type header
response.Content.Headers.GetValues("Content-Type");

// read the contents of the HTML page as a string
await response.Content.ReadAsStringAsync();
*/
