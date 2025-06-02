using UnityEngine;
public class testesoma : MonoBehaviour
{
    private int A;
    private int B;
    private int C;

    int Soma(int a, int b)
    {
        return a + b;
    }

    int Soma2(int a, int b)
    {
        int c = a + b;
        return c;
    }

    void MaiorQue(int a, int b)
    {
        if (a > b)
        {
            Debug.Log("Avariavell A armazena: " + a + " que maior que " + b + ".");
        }   
        else if (a < b)
        {
            Debug.Log("Avarievel A armazena: " + a + " que é menor que "+ b+".");  
        }
        else
        { 
            Debug.Log("Avarievel A armazena: " + a + " que é igual que "+ b+".");  
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created ;


    void Start()
    {
        A = 23;
        B = 12;
        C = A + B;
        //Debug.Log(C) :



        //C = A + B;
        //Debug.Log(Soma(13,67));
        //Debug.Log(Soma(A,B));
        //Debug.Log(Soma(89,C));

        /*
        Debug.Log(Soma2(13,67));
        Debug.Log(Soma2(A,B));
        Debug.Log(Soma2(89,C));
         */

        /*
        if (A > B)
         {
             Debug.Log("Avarievel A armazena: "
                 + A + " que é maior que "+ B+".");
         }
         else
         {
                   Debug.Log("Avarievel A armazena: "
                             + A + " que é menor que "+ B+".");
         }
         */

        MaiorQue(A, B);
        MaiorQue(23, 3);
        MaiorQue(1, 3);
        MaiorQue(1, 1);
    }

    // Update is called once per frame
        void Update()
        {

        }
    }
