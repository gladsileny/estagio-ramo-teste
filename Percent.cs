using System;
using System.Collections.Generic;
using System.Globalization;

namespace Teste {
    class Percent {
        // Classe que irá guardar os percentuais com seus respectivos nomes.

        public double Percentual { get; set; }
        public string Nome { get; set; }

        public Percent(double percentual, string nome) {
            Percentual = percentual;
            Nome = nome;
        }

        public override string ToString() {
            return Percentual.ToString("F2", CultureInfo.InvariantCulture) + "%\t" + Nome;
        }
    }
}
