using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

   //La referencia hacia un objeto puede tener cualuier nombre
   /* Pero es práctico que se llame igual */
   public GameObject GameController;


    // Start is called before the first frame update
    void Start()
    {
     GameController = GameObject.FindWithTag("GC");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 



void OnCollisionEnter (Collision  otro) {
    if (otro.gameObject.name == "energia") {
        Debug.Log("Obtienes energía");
         GameController.SendMessage("sumarEnergia");
        Destroy(otro.gameObject);
        
        

    }
        if (otro.gameObject.name == "basura") {
        Debug.Log("Obtienes basura");
        GameController.SendMessage("sumarBasura");
        Destroy(otro.gameObject);
    }
    
}

}
