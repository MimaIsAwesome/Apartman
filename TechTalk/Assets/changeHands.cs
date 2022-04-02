using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeHands : MonoBehaviour
{
    public GameObject showSticks;
    bool isEnabled = false;
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            isEnabled = !isEnabled;
            showSticks.SetActive(isEnabled);
        }
    }
}
