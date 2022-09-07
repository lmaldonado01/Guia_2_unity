using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    public GameObject ninja;

    public void RotateLeft()
    {
        ninja.transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);
    }

    public void RotateRight()
    {
        ninja.transform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);
    }

    public void TranslateUp()
    {
        ninja.transform.Translate(Vector3.up * Time.deltaTime * 10, Space.World);
    }
    
    public void TranslateDown()
    {
        ninja.transform.Translate(Vector3.down * Time.deltaTime * 10, Space.World);
    }
    
    public void TranslateLeft()
    {
        ninja.transform.Translate(Vector3.left * Time.deltaTime * 10, Space.World);
    }
    
    public void TranslateRight()
    {
        ninja.transform.Translate(Vector3.right * Time.deltaTime * 10, Space.World);
    }
    
    public void Scale(float magnitud)
    {
        Vector3 changerscale = new Vector3(magnitud, magnitud, magnitud);
        ninja.transform.localScale += changerscale;
    }
}
