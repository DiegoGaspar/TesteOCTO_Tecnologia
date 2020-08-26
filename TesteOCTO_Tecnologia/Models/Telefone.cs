using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudOCTOTecnologia.Models.Enumeraveis;

namespace TesteOCTO_Tecnologia.Models
{
    public class Telefone
    {
        public int ID { get; set; }
        /// <summary>
        /// Tipo de telefone
        /// </summary>
        public TipoTelefone tipoTelefone { get; set; }

        /// <summary>
        /// DDD
        /// </summary>
        public int DDD { get; set; }

        /// <summary>
        /// número
        /// </summary>
        public int Numero { get; set; }


    }
}
