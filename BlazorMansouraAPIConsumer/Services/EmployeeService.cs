using BlazorMansouraAPIConsumer.Models;
using System.Net.Http.Json;

namespace BlazorMansouraAPIConsumer.Services
{
    public class EmployeeService : IService<Employee>
    {
        HttpClient client;
        public EmployeeService(HttpClient client)//inject ==>register
        {
            this.client = client;
            //client = new HttpClient();//dont create but ask (inject)
            //client.BaseAddress = new Uri("http://localhost:63289");
        }

        public async Task Delete(int id)
        {
           await client.DeleteAsync($"/api/Employees/{id}");
        }

        public async Task<List<Employee>> GetAll()
        {
            List<Employee> Emplist=
                await client.GetFromJsonAsync<List<Employee>>("/api/Employees");
            return Emplist;
        }

        public async Task<Employee> GetByID(int id)
        {
            Employee emp=await client.GetFromJsonAsync<Employee>($"/api/Employees/{id}");
            return emp;
        }

        public async Task Insert(Employee obj)
        {
          var response=  await client.PostAsJsonAsync<Employee>("/api/Employees", obj);
            #region Check Success Add
            //if(response.IsSuccessStatusCode==true)
            //{

            //}
            //else
            //{
            //    response.Content.ReadAsStringAsync();
            //}
            #endregion
        }

        public async Task Update(int id,Employee obj)
        {
          await  client.PutAsJsonAsync<Employee>($"/api/Employees/{id}", obj);
        }
    }
}
