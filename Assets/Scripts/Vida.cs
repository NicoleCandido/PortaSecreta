using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Vida : MonoBehaviour
{
    public int vidaMaxima = 100;
    public int vidaAtual;
    public TextMeshProUGUI textoVida;   

    void Start()
    {
        vidaAtual = vidaMaxima;   
        AtualizarTela();
    }

    public void TomarDano(int dano)
    {
        vidaAtual -= dano;
        if (vidaAtual < 0) vidaAtual = 0;   

        Debug.Log("Tomou " + dano + " de dano!");
        AtualizarTela();

        if (vidaAtual == 0)
        {
            Morrer();
        }
    }

    public void Curar(int cura)
    {
        vidaAtual += cura;
        if (vidaAtual > vidaMaxima) vidaAtual = vidaMaxima;   

        Debug.Log("Curou " + cura + " de vida!");
        AtualizarTela();
    }

    public bool EstaComVidaCheia()
    {
        return vidaAtual == vidaMaxima;
    }

    void Morrer()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void AtualizarTela()
    {
        textoVida.text = "Vida: " + vidaAtual + " / " + vidaMaxima;
    }
}