using System;
using System.Collections.Generic;

namespace suaBaladaAqui.ViewsModels
{
    public partial class boxBaladaViewsModels
    {
        public boxBaladaViewsModels(string nome, DateTime data, string cidade, string local, string fleyr)
        {
            this.nome = nome;
            this.data = data;
            this.cidade = cidade;
            this.local = local;
            this.fleyr = fleyr;
        }

        public string nome { get; set; } = null!;
        public DateTime data { get; set; }
        public string cidade { get; set; } = null!;
        public string local { get; set; } = null!;
        public string fleyr { get; set; } = null!;
    }
}
