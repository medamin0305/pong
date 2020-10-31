using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{ public int a;
public int b;
    int Sum(int a, int b)
    {
        return a + b;
    }



    int Prod(int a, int b)
    {
        return a * b;
    }


    int Div(int a, int b)
    {
       return a / b; 
}

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sum(5, 10));

        Debug.Log(Prod(4, 8));

         Debug.Log(Div(6, 7));




    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
