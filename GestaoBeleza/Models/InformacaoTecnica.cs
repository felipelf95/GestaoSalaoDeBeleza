using GestaoBeleza.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoBeleza.Models
{
    public class InformacaoTecnica
    {
        [Key]
        public int InformacaoTecnicaId { get; set; }
        public TipoCabelo TipoDeCabelo { get; set; }
        public string Textura { get; set; }
        public string Densidade { get; set; }
        public string Porosidade { get; set; }
        public string Elasticidade { get; set; }
        public string CondicaoCouroCabeludo { get; set; }

        [ForeignKey("HistoricoQuimico")]
        public int HistoricoQuimicoId { get; set; }
        public virtual HistoricoQuimico HistoricoQuimico { get; set; }


        public InformacaoTecnica(int informacaoTecnicaId, TipoCabelo tipoDeCabelo, string textura, string densidade, string porosidade, string elasticidade, string condicaoCouroCabeludo)
        {
            InformacaoTecnicaId = informacaoTecnicaId;
            TipoDeCabelo = tipoDeCabelo;
            Textura = textura;
            Densidade = densidade;
            Porosidade = porosidade;
            Elasticidade = elasticidade;
            CondicaoCouroCabeludo = condicaoCouroCabeludo;
        }
    }
}
