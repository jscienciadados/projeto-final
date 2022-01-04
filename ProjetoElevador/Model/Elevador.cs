using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    /// <summary>
    /// Projeto Modelagem de um Elevador
    /// </summary>
    internal class Elevador
    {
        public int AndarAtual { get; set; }
        public int TotalDeAndares { get; set; }
        public int Capacidade { get; set; }
        Boolean up { get; init; }
        List<string> Pessoa;
        List<int> AndarEscolhido { get; set; }

        /// <summary>
        /// Constructor do Elevador icicia com a capacidade 8 pessoas e o tamanho da torre com 10 andares
        /// capacidade -> Capacidade de passageiros do elevador.
        /// totalAndares -> Total de andares da torre (edificio)
        /// </summary>
        
        public Elevador(int capacidade = 8, int totalAndares = 10)
        {
            // Cria uma nova instancia da lista de pessoa
            this.Pessoa = new List<string>();
            this.TotalDeAndares = totalAndares;
            this.Capacidade = capacidade;
            // inicia andar atual com 0
            this.AndarAtual = 0;
            // Cria uma nova instancia do andar escolhido
            this.AndarEscolhido = new List<int>();
        }
        /// <summary>
        /// Construtor vazio dando a opção de ser instanciado sem parametros.
        /// </summary>
        public Elevador()
        {

        }

        /// <summary>
        /// Informa o total de pessoas do elevador
        /// </summary>
        public int Ocupacao()
        {
            return this.Pessoa.Count;
        }

        /// <summary>
        /// Adicionar uma pessoa no elevador
        /// nome -> nome da pessoa
        /// andar -> andar de destino 
        /// </summary>
        public int addPessoa(string nome, int andar)
        {
            Pessoa.Add(nome);
            AndarEscolhido.Add(andar);
            return Pessoa.Count;
        }

        /// <summary>
        /// Método para remover uma pessoa do elevador
        /// retorna nova quantidade de pessoas
        /// </summary>
        public int Sair()
        {
            Pessoa.RemoveAt(0);
            AndarEscolhido.RemoveAt(0);
            return Pessoa.Count;
        }

        /// <summary>
        /// Método para subida do elevador
        /// </summary>
        public int Up()
        {
            return this.AndarAtual++;
        }

        /// <summary>
        /// Desce o elevador
        /// </summary>
        public int Down()
        {
            return this.AndarAtual--;
        }

        /// <summary>
        /// Mostra localização do elevador
        /// devolve a localização atual 
        /// </summary>
        public int Localizar()
        {
            return this.AndarAtual;
        }

        /// <summary>
        /// Retorna o numeros de vagas disponiveis
        /// </summary>
        public int QtdVagas()
        {
            if (QtdVagas() == 8)
            {
                return 0;
            }
            return this.Capacidade - AndarEscolhido.Count;
        }

    }
}
