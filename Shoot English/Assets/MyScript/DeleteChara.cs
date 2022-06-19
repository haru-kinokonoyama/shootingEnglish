using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteChara : MonoBehaviour
{
    public static void delete(){
        InputAlphabet.playerInputList.RemoveAt(InputAlphabet.playerInputList.Count-1);
    }
}
