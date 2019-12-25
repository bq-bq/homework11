using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

[System.Obsolete]
public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vb;
    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("press");
    }

    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("release");
    }

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour vbb = vb.GetComponent<VirtualButtonBehaviour>();
        if (vbb)
        {
            Debug.Log("this");
            vbb.RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
