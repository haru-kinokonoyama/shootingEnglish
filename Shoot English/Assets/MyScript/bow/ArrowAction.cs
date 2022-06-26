using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAction : MonoBehaviour
{
    public OVRGrabbable grabbedObject;
    [SerializeField] private Transform arrowLocation;
    [Tooltip("Bullet Speed")] [SerializeField] private float shotPower = 3000f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
        {
            grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
            //Calls animation on the gun that has the relevant animation events that will fire
            grabbedObject.GetComponent<Rigidbody>().AddForce(arrowLocation.forward * shotPower);
        }
    }
}
