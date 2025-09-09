using UnityEngine;

public class Chave : MonoBehaviour
{
    public GameObject textoDeVitoria;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag"(player"))
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
