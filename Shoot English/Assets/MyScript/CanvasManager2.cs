using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager2 : MonoBehaviour
{
    public GameObject Canvas3;
    public GameObject Canvas2;
    private bool pushFlag = true;  // ボタン押しすぎない用
    public bool check = true;       // 条件分岐用のbool変数

    // Update is called once per frame
    void Update()
    {
        // Xボタンで閉じる
        if (OVRInput.Get(OVRInput.Button.Three))
        {
            Canvas2.SetActive(false);
            Canvas3.SetActive(true);

            /*if (pushFlag == false)
            {
                pushFlag = true;
                if (!check)
                {
                    // 非表示
                    Canvas2.SetActive(false);
                    check = true;
                }
                else
                {
                    // 表示
                    Canvas2.SetActive(true);
                    if(Camera2)
                    {
                        Canvas2.transform.position = Camera2.transform.position + Camera2.transform.forward * 3.0f;
                        Quaternion CameraRot = Camera2.transform.rotation;
                        CameraRot.x = 0f;   // Canvasが斜めにならないように調整
                        CameraRot.z = 0f;   // Canvasが斜めにならないように調整
                        Canvas2.transform.rotation = CameraRot;
                        check = false;
                    }
                }
                
            }
        } else {
            pushFlag = false;
        }*/
    }
}
}