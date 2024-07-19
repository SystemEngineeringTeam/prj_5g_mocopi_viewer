using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    private GameObject player;   //ユニティちゃんのオブジェクト情報を格納

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!player)
        {
            //ユニティちゃんのオブジェクト情報を格納
            GameObject parent = GameObject.Find("SD_unitychan_humanoid");
            GameObject skeletonRoot = parent.transform.Find("SkeletonRoot").gameObject;
            player = skeletonRoot.transform.Find("root").gameObject;
        }
        
        // キャラクターの後ろを追尾してください。
        // カメラの位置をユニティちゃんの後ろにする 
        // y軸は固定してください
        transform.position = player.transform.TransformPoint(Vector3.back * 3f);
        var vector3 = transform.position;
        vector3.y = 1.5f;
        transform.position = vector3;
        
        // Rotateはユニティちゃんの回転をそのままカメラに反映させる x軸 y軸は固定
        transform.rotation = Quaternion.Euler(0, player.transform.eulerAngles.y, 0);
        
        
    }
}