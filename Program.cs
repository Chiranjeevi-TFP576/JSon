using Newtonsoft.Json;
using Json_Demo;

namespace Json_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            JsonInventoryMain Json = new JsonInventoryMain();
            Json.Convert("D:\\Batch 244\\Json_Demo\\Inventory.json");
        }
    }
}