using System;
using System.ComponentModel.DataAnnotations;

namespace JpvView.Model
{
    public class PessoaModel
    {
        public Guid Id { get; set; }
        public string Nome { get;  set; }

        public DateTime Nascimento { get;  set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public double Renda { get;  set; }

        public string Cpf { get;  set; }
    }
}
