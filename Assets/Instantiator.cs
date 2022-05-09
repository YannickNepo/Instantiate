using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;

    public int cantidad;
    public void CloneObject()

    {
        int i = 0;
        while (i < cantidad)
        {
            Instantiate(objectToClone);
            i++;
        }
     }
   
}
