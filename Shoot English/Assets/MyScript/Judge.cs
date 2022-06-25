using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Judge : MonoBehaviour
{
    /*public static AudioClip correct;
    public static AudioSource cosource;
    public static AudioClip incorrect;
    public static AudioSource incosource;*/

    [SerializeField] AudioClip correct;
    [SerializeField] AudioClip incorrect;
    [SerializeField] AudioSource cosource;
    [SerializeField] AudioSource incosource;

    public void judge(){
        GameObject buttoncube = GameObject.Find("AnswerButton");
        buttoncube.GetComponent<Renderer>().material.color = Color.green;
        string displayInput = string.Join("",InputAlphabet.playerInputList);
        if(displayInput==Qdictionary.ansewer){
            cosource.PlayOneShot(correct);
            buttoncube.GetComponent<Renderer>().material.color = Color.white;
        } else  {
            incosource.PlayOneShot(incorrect);
            buttoncube.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
