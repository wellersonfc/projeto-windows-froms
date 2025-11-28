using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admtarefas.Controller
{
    internal class FuncionarioController
    {
        List<string> listaFuncionario = new List<string>();
        public void cadastrarFuncionario(string nomeFuncionario,  string email, int matricula)
        {
            if (string.IsNullOrEmpty(nomeFuncionario) || string.IsNullOrEmpty(email) || matricula == null)
            {
                return;
            }
            listaFuncionario.Add(nomeFuncionario);
        }

        public List<string> listarFuncionario()
        {
            return listaFuncionario;
        }
    }
}
