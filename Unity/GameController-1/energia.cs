using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energia : MonoBehaviour
{
    Vector3 posEnergia;
   
    // Start is called before the first frame update
    void Start()
    {
      //  posEnergia = new Vector3(-14f,14f,243f);
        
      //  transform.position=posEnergia;
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 180*Time.deltaTime, 0);
    }
}
