/***********************
 * 
 * Teste - Diego Gaspar
 * 
 * ********************/

using System.Collections.Generic;
using CrudOCTOTecnologia.Models.Enumeraveis;
using TesteOCTO_Tecnologia.Models;

namespace CrudOCTOTecnologia.Models
{
    public abstract class Cliente
    {
        #region Propriedades

        /// <summary>
        /// Id do cliente
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Endereco do cliente
        /// </summary>
        public List<Endereco> Enderecos { get; set; }

        /// <summary>
        /// Telefone do cliente
        /// </summary>
        public List<Telefone> Telefones { get; set; }

        #endregion
    }
}
