/***********************
 * 
 * Teste - Diego Gaspar
 * 
 * ********************/
using System;

namespace CrudOCTOTecnologia.Models
{
    public class PessoaJuridica : Cliente
    {
        #region Propriedades
        
        /// <summary>
        /// Razão solcial do Cliente Pessoa Jurídica
        /// </summary>
        public string RazaoSocial { get; set; }

        /// <summary>
        /// CNPJ do Cliente
        /// </summary>
        public string CNPJ { get; set; }
        
        #endregion
    }
}
