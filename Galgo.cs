﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalosTrabalho
{
    [Serializable]
    public class Galgo
    {
        private string nome;
        private int velocidade;
        private int stamina;
        private int idade;
        private float preco;

        public Galgo(string nome, int velocidade, int stamina, int idade, float preco)
        {
            this.nome = nome;
            this.velocidade = velocidade;
            this.stamina = stamina;
            this.idade = idade;
            this.preco = preco;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public int Idade { get => idade; set => idade = value; }
        public float Preco { get => preco; set => preco = value; }
    }
}
