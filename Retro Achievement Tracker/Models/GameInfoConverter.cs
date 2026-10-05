using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Retro_Achievement_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Retro_Achievement_Tracker
{
    public class GameInfoConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            GameInfo GameInfo = existingValue != null ? (GameInfo)existingValue : new GameInfo();

            if (reader.TokenType == JsonToken.StartObject)
            {
                JObject item = JObject.Load(reader);

                JToken ID = item["ID"],
                    GameID = item["GameID"],
                    Title = item["Title"],
                    ConsoleID = item["ConsoleID"],
                    ImageIcon = item["ImageIcon"],
                    ImageTitle = item["ImageTitle"],
                    ImageIngame = item["ImageIngame"],
                    ImageBoxArt = item["ImageBoxArt"],
                    Publisher = item["Publisher"],
                    Developer = item["Developer"],
                    Genre = item["Genre"],
                    Released = item["Released"],
                    LastPlayed = item["LastPlayed"],
                    Achievements = item["Achievements"];

                if (Released != null)
                {
                    GameInfo.Released = Released.ToString();
                }

                if (Genre != null)
                {
                    GameInfo.Genre = Genre.ToString();
                }

                if (Developer != null)
                {
                    GameInfo.Developer = Developer.ToString();
                }
                if (Publisher != null)
                {
                    GameInfo.Publisher = Publisher.ToString();
                }

                if (ImageBoxArt != null)
                {
                    GameInfo.ImageBoxArt = Constants.RETRO_ACHIEVEMENTS_MEDIA_URL + ImageBoxArt.ToString();
                }

                if (ImageIngame != null)
                {
                    GameInfo.ImageIngame = Constants.RETRO_ACHIEVEMENTS_MEDIA_URL + ImageIngame.ToString();
                }

                if (ImageTitle != null)
                {
                    GameInfo.ImageTitle = Constants.RETRO_ACHIEVEMENTS_MEDIA_URL + ImageTitle.ToString();
                }

                if (ImageIcon != null)
                {
                    GameInfo.BadgeUri = Constants.RETRO_ACHIEVEMENTS_MEDIA_URL + ImageIcon.ToString();
                }

                if (Title != null)
                {
                    GameInfo.Title = Title.ToString();
                }

                if (ConsoleID != null)
                {
                    GameInfo.ConsoleId = Convert.ToInt32(ConsoleID);
                }

                if (ID != null)
                {
                    GameInfo.Id = Convert.ToInt32(ID);
                }

                if (GameID != null)
                {
                    GameInfo.Id = Convert.ToInt32(GameID);
                }

                if (LastPlayed != null)
                {
                    GameInfo.LastPlayed = DateTime.Parse(LastPlayed.ToString());
                }

                if (Achievements != null)
                {
                    GameInfo.Achievements = new List<Achievement>();
                    foreach (JToken jobject in Achievements.Children<JToken>())
                    {
                        foreach (JToken jobjectJr in jobject.Children<JToken>())
                        {
                            GameInfo.Achievements.Add(jobjectJr.ToObject<Achievement>());
                        }
                    }
                }
            }
            else if (reader.TokenType == JsonToken.StartArray)
            {
                JArray item = JArray.Load(reader);
                for (int i = 0; i < item.Count; i++)
                {
                    GameInfo.Claims.Add(item[i].ToObject<Claim>());
                }
            }

            return GameInfo;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JObject jo = new JObject();
            Type type = value.GetType();

            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (!prop.CanRead)
                {
                    continue;
                }

                object propVal = prop.GetValue(value, null);
                if (propVal != null && !propVal.GetType().Name.Equals("List`1"))
                {
                    jo.Add(char.ToLowerInvariant(prop.Name[0]) + prop.Name.Substring(1), JToken.FromObject(propVal, serializer));
                }
            }
            jo.WriteTo(writer);
        }
    }
}
