using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using WeatherApp;

string key = File.ReadAllText("appsettings.json");

string apiKey = JObject.Parse(key).GetValue("DefaultKey").ToString();

Console.WriteLine("Enter zipcode: ");

string zipCode = Console.ReadLine();

var apiCall = $"https://api.openweathermap.org/data/2.5/weather?units=imperial&zip={zipCode}&appid={apiKey}";


Console.WriteLine($"It is currently {Weathermap.GetTemp(apiCall)} degrees F in your location");

