using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteCodigo : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject gameObject2;

    void Start()
    {
		FuncaoB();
		FuncaoAC();
    }

    void Update()
    {
        
    }	
		
	void FuncaoAC(){
		Debug.Log("Função C");
		FuncaoA();
	}
	
	void FuncaoA(){
		Debug.Log("Função A");
	}
	
	void FuncaoB(){
		Debug.Log("Função B");
	}
}
