using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{
    public void GirarDerecha()
    {
        gameObject.transform.RotateAround(transform.position,Vector3.up,90);
    }
    
    public void GirarIzquierda()
    {
        gameObject.transform.RotateAround(transform.position,Vector3.up,-90);
    }
}
