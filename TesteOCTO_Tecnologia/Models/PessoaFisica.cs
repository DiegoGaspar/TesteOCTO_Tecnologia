/***********************
 * 
 * Teste - Diego Gaspar
 * 
 * ********************/
using System;

namespace CrudOCTOTecnologia.Models
{
    public class PessoaFisica : Cliente
    {
        #region Propriedades
        
        /// <summary>
        /// Data de Nascimento do Cliente Pessoa Física
        /// </summary>
        public DateTime DTNascimento { get; set; }

        /// <summary>
        /// CPF do Cliente
        /// </summary>
        public string CPF { get; set; }
        
        #endregion
    }
}
