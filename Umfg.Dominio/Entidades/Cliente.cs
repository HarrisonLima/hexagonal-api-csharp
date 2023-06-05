using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Umfg.Dominio.Entidades
{
    public sealed class Cliente : AbstractEntidade
    {
        [JsonPropertyName("documento")]
        public string Documento { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("celular")]
        public string Celular { get; set; }

        [JsonPropertyName("endereco")]
        public string Endereco { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("observacao")]
        public string Observacao { get; set; }

    }
}
