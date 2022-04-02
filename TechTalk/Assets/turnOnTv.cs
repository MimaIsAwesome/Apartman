using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnTv : MonoBehaviour
{

    public GameObject tv;
    public Material green;
    public Material red;
    public GameObject cube;
    bool idk = false;

   void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "hand" )
        {
            idk = !idk;
            if (idk)
            {
                cube.GetComponent<Renderer>().material = green;
            }
            else
            {
                cube.GetComponent<Renderer>().material = red;
            }
            tv.SetActive(idk);
        }
    }
}
