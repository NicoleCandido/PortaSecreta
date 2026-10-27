using UnityEngine;

public class ItemDano : MonoBehaviour
{
    public int dano = 20;
    public bool someAoTocar = true;   

    void OnTriggerEnter(Collider outro)
    {
        Debug.Log("Encostou no item de dano: " + outro.name);

        // Procura a Vida no objeto que encostou OU nos "pais" dele
        Vida vida = outro.GetComponentInParent<Vida>();
        if (vida != null)
        {
            vida.TomarDano(dano);

            if (someAoTocar)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Debug.LogWarning(outro.name + " não tem o script Vida!");
        }
    }
}