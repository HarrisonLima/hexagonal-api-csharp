using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Umfg.Dominio.Entidades
{
    public sealed class Produto : AbstractEntidade
    {
        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("codigoBarra")]
        public string CodigoBarra { get; set; }

        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
    }
}