using System;

class MainClass {
  public static void Main (string[] args) {
    /*
    1 - Construa um programa em Csharp que, tendo como dados de
    entrada dois pontos quaisquer no plano, P(x1,y1) e P(x2,y2)
    escreva a distância entre eles.
    */

    Console.WriteLine("Digite as coordenadas do ponto 1 e ponto 2. Sendo primeiro o X e depois o Y");

    int x1 = int.Parse(Console.ReadLine());
    int y1 = int.Parse(Console.ReadLine());
    int x2 = int.Parse(Console.ReadLine());
    int y2 = int.Parse(Console.ReadLine());

    int subX = (int) Math.Pow((x2-x1), 2);
    int subY = (int) Math.Pow((y2-y1), 2);
    int distancia = (int)Math.Sqrt(subX+subY);

    Console.WriteLine ($"A distância entre os pontos é: {distancia}");
  }
}