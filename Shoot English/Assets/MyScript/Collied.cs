using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collied : MonoBehaviour
{
    void Start()
    {
        
    }

    public GameObject inputText;

    public GameObject destroyEffect;

    public GameObject destroyMusicObj;
    //public AudioClip destroyMusic;
    //public AudioSource source;

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("衝突したオブジェクト：" + gameObject.name);
        Debug.Log("衝突されたオブジェクト：" + collision.gameObject.name);

        //source.PlayOneShot(destroyMusic);
        if(collision.gameObject.tag != "TargetWord")
        {
            //source.PlayOneShot(destroyMusic);
            Instantiate(destroyMusicObj,transform.position, transform.rotation);
            GenerateEffect();
            //文字取得
            InputAlphabet.inputAlphabetList(this.gameObject);

            Destroy(collision.gameObject);
            this.gameObject.SetActive(false);
            StartCoroutine("Wait");

        }

    }

    private IEnumerator Wait(){
    //3秒待つ
    yield return new WaitForSeconds(3.0f);
    //3秒待った後の処理
    Destroy(this.gameObject);
    }

 

    //エフェクトを生成する
    void GenerateEffect()
    {
        //エフェクトを生成する
        GameObject effect = Instantiate(destroyEffect) as GameObject;
        //エフェクトが発生する場所を決定する(オブジェクトの場所)
        effect.transform.position = new Vector3 (this.gameObject.transform.position.x+1.0f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        if (this.gameObject.transform.position.y > 30)
        {
            Destroy(this.gameObject);
        }

    }


}
