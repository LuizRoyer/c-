using System;

namespace SelecaoDejogador.Dto
{

    public class JogadorDto
    {
        private int idJogador;
        private String _nome;
        private String _sobrenome;
        private String _posicao;
        private byte _idade;
        private char _genero;
        private float _altura;
        private float _peso;

        private int _golsMarcados;
        private int _numeroDeJogos;
        private int _quantidadeCartaoAmarelo;
        private int _quantidadeCartaoVermelho;
        private int _quantidadeExpulsao;

        public JogadorDto() { }


        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public String Sobrenome { get => _sobrenome; set => _sobrenome = value; }
        public String Posicao { get => _posicao; set => _posicao = value; }
        public byte Idade { get => _idade; set => _idade = value; }
        public char Genero { get => _genero; set => _genero = value; }
        public float Altura { get => _altura; set => _altura = value; }
        public float Peso { get => _peso; set => _peso = value; }
        public int GolsMarcados { get => _golsMarcados; set => _golsMarcados = value; }
        public int NumeroDeJogos { get => _numeroDeJogos; set => _numeroDeJogos = value; }
        public int QuantidadeCartaoAmarelo { get => _quantidadeCartaoAmarelo; set => _quantidadeCartaoAmarelo = value; }
        public int QuantidadeCartaoVermelho { get => _quantidadeCartaoVermelho; set => _quantidadeCartaoVermelho = value; }
        public int QuantidadeExpulsao { get => _quantidadeExpulsao; set => _quantidadeExpulsao = value; }

    }
}
