using System;

namespace GestaoBeleza.Models
{
    public class HistoricoQuimico
    {
        public int HistoricoQuimicoId { get; set; }
        public DateTime DataUltimoServicoRealizado { get; set; }
        public string EspecificacoesDosServicos { get; set; }
        public string RespectivosProfissionais { get; set; }
        public string QuimicaUtilizada { get; set; }

        public HistoricoQuimico(int historicoQuimicoId, DateTime dataUltimoServicoRealizado, string especificacoesDosServicos, string respectivosProfissionais, string quimicaUtilizada)
        {
            HistoricoQuimicoId = historicoQuimicoId;
            DataUltimoServicoRealizado = dataUltimoServicoRealizado;
            EspecificacoesDosServicos = especificacoesDosServicos;
            RespectivosProfissionais = respectivosProfissionais;
            QuimicaUtilizada = quimicaUtilizada;
        }
    }
}
