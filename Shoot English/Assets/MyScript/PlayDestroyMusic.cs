using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDestroyMusic : MonoBehaviour
{
    public AudioClip destroyMusic;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source.PlayOneShot(destroyMusic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
