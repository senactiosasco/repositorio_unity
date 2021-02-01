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
		FuncaoCNova();
    }

    void Update()
    {
        
    }	
		
	void FuncaoCNova(){
		Debug.Log("Função C Nova");
	}
	
	void FuncaoA(){
		Debug.Log("Função A");
	}
	
	void FuncaoB(){
		Debug.Log("Função B");
	}
}
