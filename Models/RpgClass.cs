using System.Text.Json.Serialization;
namespace dotnet.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]


    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}