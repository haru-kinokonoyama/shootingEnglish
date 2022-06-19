using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Judge : MonoBehaviour
{

    public static void judge(){
        GameObject buttoncube = GameObject.Find("AnswerButton");
        buttoncube.GetComponent<Renderer>().material.color = Color.green;
        string displayInput = string.Join("",InputAlphabet.playerInputList);
        if(displayInput==Qdictionary.ansewer){
            buttoncube.GetComponent<Renderer>().material.color = Color.white;
        } else  {
            buttoncube.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
