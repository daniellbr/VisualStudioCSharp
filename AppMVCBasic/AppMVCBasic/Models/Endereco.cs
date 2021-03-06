﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AppMVCBasic.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo é {0} obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo é {0} obrigatório")]
        [StringLength(30, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Numero { get; set; }
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo é {0} obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter {1} caracteres ", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo é {0} obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo é {0} obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo é {0} obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres ", MinimumLength = 2)]
        public string Estado { get; set; }

        /* EF Relations 1=>1 */
        public Fornecedor Fornecedor { get; set; }
    }
}
