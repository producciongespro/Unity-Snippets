using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaCaja : MonoBehaviour  
{
    public int vX=0;
    public int vY=0;
    public int vZ=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(vX, vY, vZ) * Time.deltaTime);
    }
}
