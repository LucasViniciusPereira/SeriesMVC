using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace Rotas.MVC.Models
{
    public class Noticia
    {
        public int NoticiaID { get; set; }

        public string Titulo { get; set; }

        public string Categoria { get; set; }

        public string Conteudo { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> lstNoticias()
        {
            #region Preenchendo lista com dados 
           
            var lst = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaID = 1,
                    Categoria = "Esportes",
                    Titulo = "Cruzeiro contra leandro Damião",
                    Conteudo = "Cruzeiro anuciou hoje leandro Damião, que estava insatisfeito na equipe do santos",
                    Data = new DateTime(2015,1,5)
                },
               new Noticia
                {
                    NoticiaID = 2,
                    Categoria = "Esportes",
                    Titulo = "Palmeiras anuncia 15 novos jogadores",
                    Conteudo = "O Palmeiras foi ao mercardo e anunciou 15 novos jogadores, entre eles Dudu, que estava no grêmio e era disputado por corintihans e sao paulo",
                    Data = new DateTime(2015,1,7)
                },
                new Noticia
                {
                    NoticiaID = 3,
                    Categoria = "Esportes",
                    Titulo = "Cristiano Ronaldo eleito melhor do mundo",
                    Conteudo = "O melhor do mundo de 2015 é CR7, cristiano ronaldo foi eleito com a maioria dos votos pela FIFA",
                    Data = new DateTime(2015,1,12)
                },
                new Noticia
                {
                    NoticiaID = 4,
                    Categoria = "Politica",
                    Titulo = "Deputado é preso",
                    Conteudo = "O deputado cristaldo é preso por proprina, e é condenado a 10 anos de prisão.",
                    Data = new DateTime(2015,1,2)
                },
                new Noticia
                {
                    NoticiaID = 5,
                    Categoria = "Politica",
                    Titulo = "Dilma pede para sair",
                    Conteudo = "A presidenta dilma não aguentou á presão e revogou o cargo, irá acontecer uma nova eleição em 2015.",
                    Data = new DateTime(2015,1,5)
                },
                 new Noticia
                {
                    NoticiaID = 6,
                    Categoria = "Humor",
                    Titulo = "Dilma pede para sair",
                    Conteudo = "A presidenta dilma não aguentou á presão e revogou o cargo, irá acontecer uma nova eleição em 2015.",
                    Data = new DateTime(2015,1,7)
                },
                 new Noticia
                {
                    NoticiaID = 7,
                    Categoria = "Humor",
                    Titulo = "Piada pode melhorar a vida das pesoas",
                    Conteudo = "Uma simples piada, pode fazer com as pessoas esquecam seus problemas e aumentar a vida.",
                    Data = new DateTime(2014,12,15)
                },
                 new Noticia
                {
                    NoticiaID = 8,
                    Categoria = "Tecnologia",
                    Titulo = "Tudo sobre o Zenfone 5",
                    Conteudo = "O novo smartFone é mais um dos celulares mais vendidos da ASUS, ganhando do Moto G 2x.",
                    Data = new DateTime(2015,1,14)
                },
            }; 
            #endregion

            return lst.ToList();
        }
    }
}