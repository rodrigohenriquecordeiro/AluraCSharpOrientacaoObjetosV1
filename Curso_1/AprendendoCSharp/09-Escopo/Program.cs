﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 09 - Escopo\n");

            int idadeJoao = 18; bool acompanhado = true; string mensagemAdicional;

            if (acompanhado == true) mensagemAdicional = "João está acompanhado";
            else mensagemAdicional = "João não está acompanhado";
            
            if (idadeJoao >= 18 || acompanhado == true) Console.WriteLine($"João pode entrar. {mensagemAdicional}");
            else Console.WriteLine("João não pode entrar.");

            Console.ReadLine();
        }
    }
}