using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudOCTOTecnologia.Models.Enumeraveis;

namespace TesteOCTO_Tecnologia.Models
{
    public class Endereco
    {
        public int ID { get; set; }
        /// <summary>
        /// Tipo de endereço
        /// </summary>
        public TipoEndereco tipoEndereco { get; set; }

        /// <summary>
        /// Cep
        /// </summary>
        public string CEP { get; set; }

        /// <summary>
        /// Nome da rua ou avenida
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// numero da casa
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// complemento
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// bairro
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        public string Cidade { get; set; }


    }
}
