using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admtarefas.Model
{
    internal class FubcionarioModel
    {
        public string nome { get; set; }
        public string email { get; set; }
        public int matricula { get; set; }

        public FubcionarioModel(string nome, string email, int matricula)
        {
            this.nome = nome;
            this.email = email;
            this.matricula = matricula;
        }
    }
}
