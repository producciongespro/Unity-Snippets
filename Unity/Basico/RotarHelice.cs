using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class RotarHelice : MonoBehaviour

{

    public int velocidad = 0;
 

    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    
     
        //3 parametros:
        //1: Punto por el que queremos rotar (nuestro propio centro)
        //2: eje que queremos rotar
        //3: el angulo
        transform.RotateAround(transform.position, Vector3.down, velocidad * Time.deltaTime);
    }
}
