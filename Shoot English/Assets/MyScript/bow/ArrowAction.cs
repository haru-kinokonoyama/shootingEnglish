using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAction : MonoBehaviour
{
    public OVRGrabbable grabbedObject;
    [SerializeField] private Transform arrowLocation;
    [Tooltip("Bullet Speed")] [SerializeField] private float shotPower = 3000f;
    [SerializeField] private Rigidbody m_rigit;
    [SerializeField] private BoxCollider collider;
    bool fly = false;

    public AudioClip Music;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponentInChildren<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(grabbedObject.isGrabbed){
            if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
            {
                source.PlayOneShot(Music);
                grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
                collider.isTrigger = false;
                //Calls animation on the gun that has the relevant animation events that will fire
                grabbedObject.GetComponent<Rigidbody>().AddForce(arrowLocation.forward * shotPower);
                fly = true;

            }
        //}

        if(fly){
            var ver = m_rigit.velocity;
            var falldir = ver.normalized;
            m_rigit.MoveRotation (Quaternion.LookRotation (falldir));
        }

        if (this.gameObject.transform.position.y <= 0 )
        {
            Destroy(this.gameObject);
        }

        if (this.gameObject.transform.position.x < -15 ||this.gameObject.transform.position.x > 15 )
        {
            Destroy(this.gameObject);
        }

        if (this.gameObject.transform.position.z < -10 ||this.gameObject.transform.position.z > 15 )
        {
            Destroy(this.gameObject);
        }

    }
    

}
