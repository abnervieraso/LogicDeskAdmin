using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LogicDeskAdmin.Models
{
    public class Base
    {
        public uint Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Usuario? Creador { get; set; }
        public Usuario? Actualizador { get; set; }

        [JsonIgnore]
        public bool Marcado { get; set; }

        public bool ShouldSerializeId() => false;
        public bool ShouldSerializeCreatedAt() => false;
        public bool ShouldSerializeUpdatedAt() => false;
        public bool ShouldSerializeDeletedAt() => false;
        public bool ShouldSerializeCreador() => false;
        public bool ShouldSerializeActualizador() => false;
    }
}
