/***********************
 * 
 * Teste - Diego Gaspar
 * 
 * ********************/

using System;

namespace CrudOCTOTecnologia.Models.Enumeraveis
{
    [Serializable]
    public enum TipoTelefone : byte
    {
        //Telefone do tipo celular
        celular = 0,
        
        //Telefone do tipo residencial
        Residencial = 1,

        //Telefone do tipo comercial
        Comercial = 2
    }
}
