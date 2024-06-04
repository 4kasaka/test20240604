using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RouletteScript : MonoBehaviour
{
    //回転速度
    float rotSpeed = 0;
    bool isStop = true;
    bool isDeceleration = false;
    // Start is called before the first frame update
    void Start()
    {
        //フレームレートを60に固定
        Application.targetFrameRate=60;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            //クリックを押して回転させる
            if (isStop == true)
            {
                
                rotSpeed = 50;//回ってる時の速度
                isStop = false;
            }
            //クリックして止める
            else if (isStop == false)
            {
                isDeceleration = true;
            }
        }

        transform.Rotate(0, 0, rotSpeed);

        if (isDeceleration == true)
        {
            
            rotSpeed *= 0.95f;
            //徐々に減速
            if (rotSpeed <= 0.01)
            {
                rotSpeed = 0;
            }
            //減速し終わったらフラグを返す
            if (rotSpeed == 0)
            {
                isStop = true;
                isDeceleration = false;
            }
        }
    }
}