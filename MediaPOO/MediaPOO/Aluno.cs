﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPOO
{
    internal class Aluno
    {
        public string Nome { get; set; }

        private double[] _notas;

        public double media
        {
            get
            {
                return calcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];
        }

        public void inserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Nota #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine());

            }

        }

        private double calcularMedia()
        {
            double total = 0;

            for (int i = 0 ; i < _notas.Length ; i++)
            {
                total += _notas[i];
            }
            return total / _notas.Length;
        }
    }
}
