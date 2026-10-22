using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Inventario : MonoBehaviour
{
  
    public List<string> itens = new List<string>();

    [Header("Interface (UI)")]
    public GameObject painelInventario;   
    public TextMeshProUGUI textoItens;    

    void Start()
    {
        painelInventario.SetActive(false); 
        AtualizarTela();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            painelInventario.SetActive(!painelInventario.activeSelf);
        }
    }
    public void AdicionarItem(string nomeDoItem)
    {
        itens.Add(nomeDoItem);
        Debug.Log("Guardou no inventário: " + nomeDoItem);
        AtualizarTela();
    }

    void AtualizarTela()
    {
        if (itens.Count == 0)
        {
            textoItens.text = "Inventário vazio";
            return;
        }

        string texto = "INVENTÁRIO (" + itens.Count + " itens)\n\n";
        foreach (string item in itens)
        {
            texto += "- " + item + "\n";
        }
        textoItens.text = texto;
    }
}  