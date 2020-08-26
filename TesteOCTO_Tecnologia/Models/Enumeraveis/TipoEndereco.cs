/***********************
 * 
 * Teste - Diego Gaspar
 * 
 * ********************/

using System;

namespace CrudOCTOTecnologia.Models.Enumeraveis
{
    [Serializable]
    public enum TipoEndereco : byte
    {
        //Endereço de correspondencia
        Correspondencia = 3,
        
        //Endereço comercial
        Comercial = 4,

        //Endereço de cobrança
        Cobranca = 5,

        //Endereço de entrega
        Entrega = 6,


        //Endereço resodencial
        Residencial = 7
    }
}
