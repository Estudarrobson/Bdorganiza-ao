using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organização
{
    internal class TarefaComUsuario
    {
        public int Id { get; set; }
        public int Responsavel { get; set; }
        public int Quem { get; set; }
        public string TarefaMes { get; set; }
        public string Categoria { get; set; }
        public string NomeTarefa { get; set; }
        public string Prioridade { get; set; }
        public string Periodicidade { get; set; }
        public DateTime Vencimento { get; set; }
        public string BuscarNome { get; set; }
        public DateTime Data { get; set; }
        public decimal Pontuacao { get; set; }
        public bool Concluida { get; set; }
        public DateTime? DataConclusao { get; set; }
        public decimal PontosBase { get; set; }
        public decimal Penalidade { get; set; }

        // Propriedades do usuário
        public string NomeUsuario { get; set; }
        public byte[] Foto { get; set; }
    }
}



