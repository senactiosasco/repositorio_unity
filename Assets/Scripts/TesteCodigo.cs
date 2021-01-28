using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteCodigo : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject gameObject2;

    void Start()
    {
        FuncaoA();
		FuncaoC();
    }

    void Update()
    {
        
    }
	
	void FuncaoA(){
		Debug.Log("Função A");
	}
	
		
	void FuncaoC(){
		Debug.Log("Função C");
	}
}
