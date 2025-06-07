using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace Organização
{

    // Classe auxiliar (DEVE ficar ANTES da CalculadoraPontosService)
    public class ResultadoCalculoPontos
    {
        public decimal PontosBase { get; set; }
        public decimal PontosFinais { get; set; }
        public string Mensagem { get; set; }
        public decimal Penalidade { get; set; } // Nova propriedade
    }

    public static class CalculadoraPontosService
    {
        // Tabelas de pesos
        private static readonly Dictionary<string, decimal> PesosPrioridade = new()
        {
            {"Urgente", 3.5m}, {"Alta", 3.0m}, {"Média", 2.0m}, {"Baixa", 1.0m}
        };

        private static readonly Dictionary<string, decimal> PesosPeriodicidade = new()
        {
            {"Diária", 1.5m}, {"Semanal", 2.0m}, {"Quinzenal", 2.5m}, {"Mensal", 3.0m}
        };

        private static readonly Dictionary<string, decimal> PesosCategoria = new()
        {
            {"Crítica", 4.0m}, {"Importante", 3.0m}, {"Rotina", 2.0m}, {"Opcional", 1.0m}
        };

        public static ResultadoCalculoPontos CalcularPontos(
            string prioridade,
            string periodicidade,
            string categoria,
            bool concluida,
            DateTime? dataConclusao,
            DateTime dataVencimento)
        {
            // Valores padrão para evitar erros
            prioridade ??= "Média";
            periodicidade ??= "Semanal";
            categoria ??= "Rotina";

            // Cálculo base (sem penalidades)
            decimal pontosBase = 10.0m;
            pontosBase *= PesosPrioridade.TryGetValue(prioridade, out decimal pPri) ? pPri : 1.0m;
            pontosBase *= PesosPeriodicidade.TryGetValue(periodicidade, out decimal pPer) ? pPer : 1.0m;
            pontosBase += PesosCategoria.TryGetValue(categoria, out decimal pCat) ? pCat : 0.0m;
            pontosBase = Math.Round(pontosBase, 2);

            // Inicializa o resultado
            var resultado = new ResultadoCalculoPontos
            {
                PontosBase = pontosBase,
                PontosFinais = pontosBase,
                Mensagem = "Pontuação base",
                Penalidade = 0 // Inicializa sem penalidade
            };

            // Aplica penalidades/bônus
            if (concluida && dataConclusao.HasValue)
            {
                if (dataConclusao <= dataVencimento)
                {
                    decimal bonus = pontosBase * 0.2m;
                    resultado.PontosFinais += bonus;
                    resultado.Mensagem = $"Bônus: +{bonus:F2} pts";
                }
            }
            else if (!concluida && DateTime.Today > dataVencimento)
            {
                int diasAtraso = (DateTime.Today - dataVencimento).Days;
                resultado.Penalidade = Math.Min(diasAtraso * 0.5m, pontosBase * 0.5m); // Máximo 50%
                resultado.PontosFinais = Math.Max(pontosBase - resultado.Penalidade, 5.0m); // Mínimo 5pts
                resultado.Mensagem = $"Penalidade: -{resultado.Penalidade:F2} pts";
            }

            resultado.PontosFinais = Math.Round(resultado.PontosFinais, 2);
            return resultado;
        }
    }
}