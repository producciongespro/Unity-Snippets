using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
   private int energia=100;
   private int basura=0;
   public Text textBasura;
   public Text textEnergia;

    void Start()
    {
        textBasura.text="Basura";
        textEnergia.text="Energía";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sumarEnergia () {
            energia+=15;
             Debug.Log(energia);
            textEnergia.text = "Energía = " + energia.ToString();
    }

    void sumarBasura () {
            basura+=25;
            energia-=15;
            textBasura.text = "Basura = " + basura.ToString();
             textEnergia.text = "Energía = " + energia.ToString();
            Debug.Log(basura);
             Debug.Log(energia);
    }
}
