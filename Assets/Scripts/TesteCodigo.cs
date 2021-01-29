using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteCodigo : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject gameObject2;

    void Start()
    {
		FuncaoC();
        FuncaoB();
    }

    void Update()
    {
        
    }
	
	void FuncaoB(){
		Debug.Log("Função B");
	}
	
		
	void FuncaoC(){
		Debug.Log("Função C");
	}
}
