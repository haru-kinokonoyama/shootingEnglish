using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
            StartCoroutine("Wait");
            //buttoncube.GetComponent<Renderer>().material.color = Color.white;
        } else  {
            incosource.PlayOneShot(incorrect);
            //buttoncube.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    private IEnumerator Wait(){
    //2秒待つ
    yield return new WaitForSeconds(2.0f);
    //2秒待った後の処理
    InputAlphabet.playerInputList.Clear();
    SceneManager.LoadSceneAsync("ReplayMenu");
    }
}
