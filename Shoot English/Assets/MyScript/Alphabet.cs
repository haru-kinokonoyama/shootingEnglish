using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Alphabet : MonoBehaviour
{
    public GameObject changetext;


    public Text text;
    public string alphabet;
    private static readonly string[] ALPHABET = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };


    // Start is called before the first frame update
    void Start()
    {
        alphabet = ALPHABET.ElementAt(Random.Range(0, ALPHABET.Count()));
        /*
         * alphabet = ALPHABET.ElementAt(Random.Range(0,ALPHABET.Count()));
        //text.text = alphabet;
        Debug.Log(text.text);
        changetext.GetComponent<TextMesh>().text = alphabet;
        */
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = alphabet;
        Debug.Log(alphabet);
        changetext.GetComponent<TextMesh>().text = alphabet;
    }
}
