using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonColor : MonoBehaviour
{

    //[SerializeField] Material selectColor;
    [SerializeField] private Material[] _material; 

    // Start is called before the first frame update
    void Awake()
    {
         // マテリアルの配列をmaterialsという名前に与える
        Material[] materials = GetComponent<Renderer>().sharedMaterials;
        // materialsの18番をReflectorLampRedON（[SerializeField] Material で名前変えたらここも変えないといけないよ）に置き換える
        materials[1] = _material[Random.Range(1,3)];
        // sharedMaterials機能をmaterialsに与える
        GetComponent<Renderer>().sharedMaterials = materials;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
