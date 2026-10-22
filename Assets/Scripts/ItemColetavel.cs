using UnityEngine;

public class ItemColetavel : MonoBehaviour
{
    public string nomeDoItem = "Chave";   
    public float velocidadeGiro = 90f;    

    void Update()
    {
        transform.Rotate(0, velocidadeGiro * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider outro)
    {              
        Inventario inventario = outro.GetComponent<Inventario>();
        if (inventario != null)
        {
            inventario.AdicionarItem(nomeDoItem);
            Destroy(gameObject); 
        }
    }
}