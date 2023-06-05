using System.Text.Json.Serialization;

namespace Umfg.Dominio.Entidades
{
    public abstract class AbstractEntidade
    {
        [JsonPropertyName("id")]
        public Guid Id { get; private set; } = Guid.NewGuid();
    }
}