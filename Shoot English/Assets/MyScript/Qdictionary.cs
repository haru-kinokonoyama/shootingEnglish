using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using UnityEngine;

public class Qdictionary : MonoBehaviour
{
    public string japanese;
    private static readonly string[] JAPANESE = new string[] { "���", "�݂���", "�o�i�i" };
    public string ansewer;
    Dictionary<string, string> dict = new Dictionary<string,string>();

    public List<string> Keys;
    public string ShowKey;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        japanese = JAPANESE.ElementAt(Random.Range(0, JAPANESE.Count()));
        dict.Add("���","apple");
        dict.Add("�݂���", "orange");
        dict.Add("�o�i�i", "banana");

        //text.text = japanese;

    }

    // Update is called once per frame
    void Update()
    {
        text.text = japanese;
        ansewer = dict[japanese];
        for(int i = 0; i < ansewer.Length-1; i++)
        {

        }
        
    }
}
