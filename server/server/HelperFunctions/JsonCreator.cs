using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using server.Models;
using System;


namespace server.HelperFunctions
{
    public static class JsonFileUtils
    {
        private static readonly JsonSerializerSettings _options
            = new() { NullValueHandling = NullValueHandling.Ignore };

        public static void jsonEditor(Demo obj)
        {
            var jsonData = System.IO.File.ReadAllText(path: "./HelperFunctions/Omar.json");

            var userList = JsonConvert.DeserializeObject<List<StoredJson>>(jsonData)
                                  ?? new List<StoredJson>();
            int count = userList.Count;
            userList.Add(new StoredJson()
            {
                name = obj.name,
                msg = obj.msg,
                id = count + 1
            });
            //save for the delete method
            /*            count++;
                        Console.WriteLine(userList.Count);
                        for (int i = 0; i<count; i++)
                        {
                            if (userList[i].msg == "me")
                            {
                                userList.RemoveAt(i);
                                i--;
                                count--;
                            }
                        }*/
            jsonData = JsonConvert.SerializeObject(userList, Formatting.Indented, _options);
            System.IO.File.WriteAllText("./HelperFunctions/Omar.json", jsonData);
            Console.WriteLine(userList[0].msg);
        }
        public static List<StoredJson> getHandler()
        {
            List<StoredJson> omar = new List<StoredJson>();
            omar.Add(new StoredJson()
            {
                id = 1,
                msg = "helo",
                name = "ji"
            });
 

            return omar;
        }
    }
}
