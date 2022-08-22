using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowAction : MonoBehaviour
{
    //OVRGrabbable grabbedObject = new OVRGrabbable();
    public OVRGrabbable grabbedObject;

    public GameObject bow;
    public GameObject arrow;
    public GameObject arrowclone;
    Transform arrowStartPosition;
    bool boolgrabbed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(grabbedObject.isGrabbed){
            
        }

        if(boolgrabbed==false){
            IsGrabbed();
        }

        if(boolgrabbed){
            arrowclone = GameObject.Find("arrow(Clone)");
            if(arrowclone == null){
                arrowStartPosition = grabbedObject.grabbedTransform;
                Instantiate(arrow, arrowStartPosition.position, arrowStartPosition.rotation);
                Debug.Log("弓矢生成");
                Debug.Log(arrowStartPosition.position);
            }
        }

        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger)){
            bow.transform.position = new Vector3(0.2f,1.8f,-1.65f);
            bow.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        
    }

    private void IsGrabbed(){
        if(grabbedObject.isGrabbed){
            boolgrabbed = true;
        }else{
            boolgrabbed = false;
            }
    }
}
