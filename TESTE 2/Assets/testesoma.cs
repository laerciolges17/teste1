using UnityEngine;

public class testesoma : MonoBehaviour
{
    private int A;
    private int B;
    private int C;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created ;
                                                                                                       
    
    void Start()
    {
        A = 23;
        B = 12;


        //C = A + B;
        C = Soma(A, B);
        
        Debug.Log(C);
    }

    int Soma(int a, int b)
    {
        return a + b;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
