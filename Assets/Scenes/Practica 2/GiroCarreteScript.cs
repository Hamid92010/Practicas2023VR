using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroCarreteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, -5f, 0f) * Time.deltaTime); //Rotar objeto en el eje "y" con un par de 5 multiplicado por el tiempo entre frame y frame
    }
}
