﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atika_simulator
{


    // kedv nincs megcsinálvaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    // vagy bármi más nincs megcsinálvaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    internal class Irodalom
    {
        public static void IrodalomGame()
        {
            Console.WriteLine("Tiktokozol? (igen/nem)");
            string tiktokAnswer = Console.ReadLine().ToLower();

            if (tiktokAnswer == "nem")
            {
                // Random kérdés
                RandomQuestionSimulator randomSimulator = new RandomQuestionSimulator();
                randomSimulator.AskRandomQuestion();
            }
            else
            {
                Console.WriteLine("Ügyes vagy Tiktokozásban!");
            }
        }
    }
    class RandomQuestionSimulator
    {
        private string correctAnswer = "Sándor Petőfi";
        private string userAnswer;

        public void AskRandomQuestion()
        {
            Console.WriteLine("Ki írta az 'Estve' című verset?");
            Console.WriteLine("a) Attila József");
            Console.WriteLine("b) Sándor Petőfi");
            Console.WriteLine("c) Endre Ady");
            Console.WriteLine("d) József Attila");

            Console.Write("Válasz (a/b/c/d): ");
            userAnswer = Console.ReadLine().ToLower();

            CheckAnswer();
        }

        private void CheckAnswer()
        {
            if (userAnswer == "b")
            {
                Console.WriteLine("Gratulálok! Helyes válasz!");
            }
            else
            {
                Console.WriteLine($"Sajnálom, helytelen válasz. A helyes válasz: {correctAnswer}");
            }
        }
    }
}