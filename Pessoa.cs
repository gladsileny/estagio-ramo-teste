using System;
using System.Collections.Generic;
using System.Globalization;

namespace Teste {
    class Pessoa {
        // Classe que irá guardar os dados do arquivo.

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Pessoa(int id, string nome, double valor) {
            Id = id;
            Nome = nome;
            Valor = valor;
        }

        public override string ToString() {
            return Id + "\t" + Nome + "\t" + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
