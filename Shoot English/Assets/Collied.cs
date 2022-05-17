using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collied : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject destroyEffect;

    public AudioClip destroyMusic;
    public AudioSource source;

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("衝突したオブジェクト：" + gameObject.name);
        Debug.Log("衝突されたオブジェクト：" + collision.gameObject.name);

        //source.PlayOneShot(destroyMusic);
        if(collision.gameObject.tag != "TargetWord")
        {
            GenerateEffect();

            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }

    }

 

    //エフェクトを生成する
    void GenerateEffect()
    {
        //エフェクトを生成する
        GameObject effect = Instantiate(destroyEffect) as GameObject;
        //エフェクトが発生する場所を決定する(敵オブジェクトの場所)
        effect.transform.position = new Vector3 (this.gameObject.transform.position.x+1.0f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        /*if (this.gameObject.transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }*/

    }


}
