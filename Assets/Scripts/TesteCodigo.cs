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
		FuncaoB();
		FuncaoC();
    }

    void Update()
    {
        
    }	
		
	void FuncaoC(){
		Debug.Log("Função C");
	}
	
	void FuncaoA(){
		Debug.Log("Função A");
	}
	
	void FuncaoB(){
		Debug.Log("Função B");
	}
}
