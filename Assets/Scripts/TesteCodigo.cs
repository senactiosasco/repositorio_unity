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
    }

    void Update()
    {
        
    }
	
	void FuncaoB(){
		Debug.Log("Função B");
	}
}
