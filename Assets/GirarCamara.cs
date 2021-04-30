using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarCamara : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    public int speed;
    public void GirarDerecha()
    
    {
        gameObject.transform.RotateAround(transform.position,Vector3.right,180);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}