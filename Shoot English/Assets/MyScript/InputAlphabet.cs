using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class InputAlphabet : MonoBehaviour
{
    public GameObject changetext;

    //入力されたアルファベット
    public static List<string> playerInputList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //一時的に入力文字列を保存する配列
        //string[] data = inputAlphabet.ToArray();
        string displayInput = string.Join("",playerInputList);
        changetext.GetComponent<Text>().text = displayInput;
        //ebug.Log(displayInput);
        
    }

    //入力されたアルファベット取得
    public static void inputAlphabetList(GameObject alphabet){
        playerInputList.Add(alphabet.GetComponent<TextMesh>().text.ToString());
    }
}
