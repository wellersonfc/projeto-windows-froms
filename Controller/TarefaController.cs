using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importando Model
using admtarefas.Model;

namespace admtarefas.Controller
{
    internal class TarefaController
    {
        List<TarefaModel> listaTarefaModel = new List<TarefaModel>();
         

        public void cadastrarTarefa(string nomeTarefa, string data , string status) {

            if (string.IsNullOrEmpty(nomeTarefa) || string.IsNullOrEmpty(data) || string.IsNullOrEmpty(status))
            { 
                return;
            }
            TarefaModel tarefas = new TarefaModel(nomeTarefa, data, status);
            listaTarefaModel.Add(tarefas);
        }

        public List<TarefaModel> listarTarefa() { 
            return listaTarefaModel;
        
        }
    }
}
