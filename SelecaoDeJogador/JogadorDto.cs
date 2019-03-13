using System;

namespace SelecaoDejogador.Dto
{

    public class JogadorDto
    {
        private int idJogador;
        private String _nome;
        privateString _sobrenome;
        privateString _posicao;
        private byte _idade;
        privatechar _genero;
        private float _altura;
        privatefloat _peso;

        privateint _golsMarcados;
        privateint _numeroDeJogos;
        privateint _quantidadeCartaoAmarelo;
        private int _quantidadeCartaoVermelho;
        privateint _quantidadeExpulsao;

        public JogadorDto() { }


        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public privateString Sobrenome { get => _sobrenome; set => _sobrenome = value; }
        public privateString Posicao { get => _posicao; set => _posicao = value; }
        public byte Idade { get => _idade; set => _idade = value; }
        public privatechar Genero { get => _genero; set => _genero = value; }
        public float Altura { get => _altura; set => _altura = value; }
        public privatefloat Peso { get => _peso; set => _peso = value; }
        public privateint GolsMarcados { get => _golsMarcados; set => _golsMarcados = value; }
        public privateint NumeroDeJogos { get => _numeroDeJogos; set => _numeroDeJogos = value; }
        public privateint QuantidadeCartaoAmarelo { get => _quantidadeCartaoAmarelo; set => _quantidadeCartaoAmarelo = value; }
        public int QuantidadeCartaoVermelho { get => _quantidadeCartaoVermelho; set => _quantidadeCartaoVermelho = value; }
        public privateint QuantidadeExpulsao { get => _quantidadeExpulsao; set => _quantidadeExpulsao = value; }

    }
}
