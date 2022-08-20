using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Alphabet2 : MonoBehaviour
{
    public GameObject changetext;

    public Text text;
    public string alphabet;
    private static readonly string[] ALPHABET = new string[] { "i", "j", "k", "l", "m", "n", "o", "p" };

    // Start is called before the first frame update
    void Start()
    {
        alphabet = ALPHABET.ElementAt(Random.Range(0, ALPHABET.Count()));

    }

    // Update is called once per frame
    void Update()
    {
        changetext.GetComponent<TextMesh>().text = alphabet;
    }
}
