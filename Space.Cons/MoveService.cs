using Involved.HTF.Common;
using Involved.HTF.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.Cons
{
    public class MoveService : HttpClient
    {
        static async Task Move(int grade, string speed)
        {


            //Product product = null;
            //HttpResponseMessage response = await client.GetAsync(path);
            //if (response.IsSuccessStatusCode)
            //{
            //    product = await response.Content.ReadAsAsync<Product>();
            //}
            //return product;

            //var response = await GetAsync($"/api/team/token?teamname={teamname}&password={password}");
            //if (!response.IsSuccessStatusCode)
            //    throw new Exception("You weren't able to log in, did you provide the correct credentials?");
            //var token = await response.Content.ReadAsStringAsync();
            //DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }
    }
}
