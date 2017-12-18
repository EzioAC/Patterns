using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Patterns.SimpleFactory
{
    public class ShapeFactory
    {
        public static IRole CreateRole()
        {
            IRole shape = null;
            string json = File.ReadAllText(@"SimpleFactory/Config.json"); 
            Dictionary<string, string> dic=  JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            switch (dic["Role"])
            {
                case "Angle":
                    shape = new Angle();
                    break;
                case "Witch": 
                    shape = new Witch();
                    break;
                case "Hero": 
                    shape = new Hero();
                    break;
                default: 
                    throw new InvalidDataException();
            }
            return shape;
        }
    }
}