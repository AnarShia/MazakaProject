using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NuGet.Protocol;
using Todoist.Net;
using Todoist.Net.Models;
using Task = MazakaNet.Models.Task.Task;

namespace MazakaNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TodoIstApiController : Controller
    {
        private static IConfiguration _configuration;
        
        public TodoIstApiController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        
        public async void AddItems(string content, string description)
        {
            var token = _configuration.GetValue<string>("Todoist:Token");
             ITodoistClient client = new TodoistClient(token);
            var newItem = new Item(content);
            newItem.Description = description;
            newItem.Collapsed = false;

                        var task = await client.Items.AddAsync(newItem);
                        
        }

        [HttpGet]
        public async Task<IActionResult> AddProject()
        {
            string randomGuid = new Guid().ToString();
            var token = _configuration.GetValue<string>("Todoist:Token");
            HttpClient client = new HttpClient();
client.DefaultRequestHeaders.Add("Authorization","Bearer "+token);
client.DefaultRequestHeaders.Add("X-Request-Id", randomGuid);
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

var response=await client.PostAsJsonAsync("https://api.todoist.com/rest/v2/projects",new
{
name="Cagri Karaca"

});

response.EnsureSuccessStatusCode();
var result = await response.Content.ReadAsStreamAsync();

return Ok(result);
        }

        //[HttpGet]
        //public async Task<IActionResult> updateAssigner()
        //{
        //    var token = _configuration.GetValue<string>("Todoist:Token");

        //    string randomGuid = new Guid().ToString();
        //    string projectId = (await new TodoistClient(token).Items.GetAsync()).FirstOrDefault(project=>project.Content=="des")?.Id.ToString();

        //    HttpClient client = new HttpClient();
        //    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
        //    client.DefaultRequestHeaders.Add("X-Request-Id", randomGuid);
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    var response = await client.PostAsJsonAsync("https://api.todoist.com/rest/v2/tasks/"+projectId, new
        //    {
                
        //        description="Yeni degiştirilen kod"

        //    });

        //    response.EnsureSuccessStatusCode();
        //    var result = await response.Content.ReadAsStreamAsync();

        //    return Ok(result);
        //}

        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var token = _configuration.GetValue<string>("Todoist:Token");
            ITodoistClient client = new TodoistClient(token);

            var projects = await client.Projects.GetAsync();
            return View(projects);
        }
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var token = _configuration.GetValue<string>("Todoist:Token");
            ITodoistClient client = new TodoistClient(token);

            var user = await client.Users.GetCurrentAsync();
            return Ok(user);
        }
        [HttpGet]
        public async Task<IActionResult> getItems()
        {
            var token = _configuration.GetValue<string>("Todoist:Token");
            ITodoistClient client = new TodoistClient(token);
var items = await client.Items.GetAsync();

return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> getAllResources()
        {
            var token = _configuration.GetValue<string>("Todoist:Token");
            ITodoistClient client = new TodoistClient(token);
            
            var resources = await client.GetResourcesAsync();

            return View(resources);
        }
    }
}

