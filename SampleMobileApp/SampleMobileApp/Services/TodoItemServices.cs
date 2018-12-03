using Newtonsoft.Json;
using SampleMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SampleMobileApp.Services
{
    public class TodoItemServices
    {
        private HttpClient _client;
        public List<TodoItem> Items { get; set; }
        public TodoItemServices()
        {
            _client = new HttpClient();
        }

        public async Task<List<TodoItem>> GetAllData()
        {
            Items = new List<TodoItem>();
            var uri = new Uri(Helpers.RestUrl);
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<TodoItem>>(content);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
            return Items;
        }

        public async Task Insert(TodoItem item)
        {
            var uri = new Uri(Helpers.RestUrl);
            try
            {
                var jsonData = JsonConvert.SerializeObject(item);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await _client.PostAsync(uri, content);
                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Gagal menambahkan data...");
            }
            catch (Exception ex) 
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
    }
}
