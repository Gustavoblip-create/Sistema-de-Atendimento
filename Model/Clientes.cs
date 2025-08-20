﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Atendimento.Model
{
    internal class Clientes
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string cpf_cnpj{ get; set; }
        public string tipo_pessoa{ get; set; }

        public string telefone { get; set; }
        public string celular { get; set; }

        public string cep { get; set; }
        public string endereco { get; set; }

        public string numero { get; set; }
        public string complemento{ get; set; }
        public string bairro{ get; set; }
        public string cidade{ get; set; }
        public string estado{ get; set; }
        public int ativo{ get; set; }



}
}
