using UnityEngine;

public class questão : MonoBehaviour
{
    public int resposta;
   void Start()
    {
        resposta = 0;
    }

   void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            resposta = 1;
        }
        else if (Input.GetKeyDown(KeyCode.B)) 

        {
            resposta = 2;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("A resposta é "+resposta+" !");
        }
    }
}
