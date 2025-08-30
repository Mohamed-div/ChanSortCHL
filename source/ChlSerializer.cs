// ChlSerializer.cs
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChanSort.Loader
{
    public class ChlSerializer // TODO: extend proper base class from ChanSort
    {
        public string DisplayName => "CHL (concatenated JSON)";
        public string FileFilter => "CHL files (*.chl)|*.chl";

        public (List<JObject> sats, List<JObject> tps, List<JObject> favs, List<JObject> chs) ParseChl(string path)
        {
            var text = File.ReadAllText(path, Encoding.UTF8);
            var reader = new JsonTextReader(new StringReader(text)) { SupportMultipleContent = true };
            var sats = new List<JObject>();
            var tps  = new List<JObject>();
            var favs = new List<JObject>();
            var chs  = new List<JObject>();
            while (reader.Read())
            {
                var token = JToken.ReadFrom(reader);
                if (!(token is JObject obj)) continue;
                var type = (obj.Value<string>("Type") ?? obj.Value<string>("type") ?? "").ToLowerInvariant();
                switch (type)
                {
                    case "sat": sats.Add(obj); break;
                    case "tp":  tps.Add(obj); break;
                    case "fav": favs.Add(obj); break;
                    case "ch":  chs.Add(obj); break;
                    case "index": break;
                    default: break;
                }
            }
            return (sats, tps, favs, chs);
        }

        public void LoadChlToChanSortStructures(string fileName)
        {
            var (sats, tps, favs, chs) = ParseChl(fileName);
            // TODO: Map JObjects to ChanSort's internal Channel structures
        }

        public void SaveChanSortToChl(string fileName)
        {
            throw new NotImplementedException("Implement mapping back to .chl JSON");
        }
    }
}
