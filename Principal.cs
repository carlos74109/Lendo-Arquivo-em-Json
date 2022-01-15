using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.LendoDadosJson
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\LendoDadosJson\dados.json");

            var user = JsonConvert.DeserializeObject<List<Usuarios>>(json);

            Usuarios usuarios = new Usuarios("henrique", 4567);
            
            user.Add(usuarios);

            var json_serializado = JsonConvert.SerializeObject(user);

            Console.WriteLine(json_serializado);

            
            
                
            
            

        }
    }
}
