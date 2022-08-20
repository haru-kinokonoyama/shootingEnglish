using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DeleteChara : MonoBehaviour
{
    public AudioClip de;
    public AudioSource source;

    public void delete(){
        source.PlayOneShot(de);
        InputAlphabet.playerInputList.RemoveAt(InputAlphabet.playerInputList.Count-1);
    }
}
