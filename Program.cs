using Sonnerie;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

// Inputs
int customerid = 0;
var apiUri = new Uri("https://api-4117.cube256.com:37003/upload/something.json");
var filename = "HLV2824_Q_" + customerid + "_" + 0 + ".json";
var jsonPath = "order-request.json";
var bearerToken = "aGVsbG8gd29ybGQsIEkgYW0gcmVhZHk="; // test-token

// Load JSON file
string json = await File.ReadAllTextAsync(jsonPath);

var jsonopt = new JsonSerializerOptions
{
    WriteIndented = true,
    IncludeFields = true
};

// Parse JSON file, for validation
var orderrequest = JsonSerializer.Deserialize<OrderRequest>(json, jsonopt);
if (orderrequest is null)
{
    Console.WriteLine("JSON payload is invalid.");
    return;
}

// Re‑serialize to canonical JSON
json = JsonSerializer.Serialize(orderrequest, jsonopt);

Console.WriteLine("sending:\n" + json);

// Prepare HTTP content
var content = new StringContent(json, Encoding.UTF8, "application/json");

// Build client
using var http = new HttpClient();

// Add Authorization: Bearer <base64>
http.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", bearerToken);

// POST
var uploaduri = new Uri(apiUri, filename);
HttpResponseMessage resp = await http.PostAsync(uploaduri, content);

// Read response
string body = await resp.Content.ReadAsStringAsync();
Console.WriteLine($"Status: {resp.StatusCode}");
Console.WriteLine(body);
