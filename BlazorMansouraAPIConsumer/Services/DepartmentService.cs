using BlazorMansouraAPIConsumer.Models;
using System.Net.Http.Json;

namespace BlazorMansouraAPIConsumer.Services
{
    public class DepartmentService : IService<Department>
    {
        //private readonly HttpClient httpClient;
        //public DepartmentService(HttpClient _httpClient)
        //{
        //    httpClient = _httpClient;
        //}
        HttpClient _httpClient = null;
        public DepartmentService(HttpClient client)//inject 
        {
            _httpClient = client;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAll()
        {
           List<Department>DeptList=await _httpClient.GetFromJsonAsync<List<Department>>("/api/Department");
           return DeptList;
        }

        public Task<Department> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Department obj)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Department obj)
        {
            throw new NotImplementedException();
        }
    }
}
