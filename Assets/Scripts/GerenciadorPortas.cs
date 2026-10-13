using UnityEngine;

// Vai em um objeto vazio "Gerenciador". Sorteia qual porta é a certa.
public class GerenciadorPortas : MonoBehaviour
{
    public Porta[] portas; // arraste as 3 portas aqui no Inspector

    void Start()
    {
        int sorteada = Random.Range(0, portas.Length); // 0, 1 ou 2

        for (int i = 0; i < portas.Length; i++)
        {
            portas[i].correta = (i == sorteada);
        }

        Debug.Log("Porta certa: " + (sorteada + 1)); // dica para o professor no Console
    }
}