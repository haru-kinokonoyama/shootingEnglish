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
        Debug.Log("�Փ˂����I�u�W�F�N�g�F" + gameObject.name);
        Debug.Log("�Փ˂��ꂽ�I�u�W�F�N�g�F" + collision.gameObject.name);

        //source.PlayOneShot(destroyMusic);
        if(collision.gameObject.tag != "TargetWord")
        {
            GenerateEffect();

            Destroy(collision.gameObject);
            Destroy(this.gameObject);

        }

    }

 

    //�G�t�F�N�g�𐶐�����
    void GenerateEffect()
    {
        //�G�t�F�N�g�𐶐�����
        GameObject effect = Instantiate(destroyEffect) as GameObject;
        //�G�t�F�N�g����������ꏊ�����肷��(�G�I�u�W�F�N�g�̏ꏊ)
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
