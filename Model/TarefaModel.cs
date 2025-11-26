using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admtarefas.Model
{
    internal class TarefaModel
    {
        public string nomeTarefa { get; set; }
        public string data { get; set; }
        public string status { get; set; }

        public  TarefaModel(string nomeTarefa, string data, string status) { 
            this.nomeTarefa = nomeTarefa;
            this.data = data;
            this.status = status;
        }

    }
}
