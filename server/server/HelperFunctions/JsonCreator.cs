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
            int count=userList.Count;
            int id;
            if (userList.Count == 0)
            {
                id = 0;
            }
            else
            {
                id = userList[count - 1].id + 1;
            }
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
            var jsonData = System.IO.File.ReadAllText(path: "./HelperFunctions/Omar.json");
            List<StoredJson> userList = JsonConvert.DeserializeObject<List<StoredJson>>(jsonData);

            return userList;
        }
        public static void jsonDeleter(int id)
        {
            var jsonData = System.IO.File.ReadAllText(path: "./HelperFunctions/Omar.json");

            var userList = JsonConvert.DeserializeObject<List<StoredJson>>(jsonData)
                                  ?? new List<StoredJson>();


            //save for the delete method
            int count= userList.Count;
            Console.WriteLine(userList.Count);
            for (int i = 0; i < count; i++)
            {
                if (userList[index: i].id == id)
                {
                    userList.RemoveAt(i);
                    break;
                }
            }
            jsonData = JsonConvert.SerializeObject(userList, Formatting.Indented, _options);
            System.IO.File.WriteAllText("./HelperFunctions/Omar.json", jsonData);
        }
    }
}
