using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RouletteScript : MonoBehaviour
{
    //��]���x
    float rotSpeed = 0;
    bool isStop = true;
    bool isDeceleration = false;
    // Start is called before the first frame update
    void Start()
    {
        //�t���[�����[�g��60�ɌŒ�
        Application.targetFrameRate=60;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            //�N���b�N�������ĉ�]������
            if (isStop == true)
            {
                
                rotSpeed = 50;//����Ă鎞�̑��x
                isStop = false;
            }
            //�N���b�N���Ď~�߂�
            else if (isStop == false)
            {
                isDeceleration = true;
            }
        }

        transform.Rotate(0, 0, rotSpeed);

        if (isDeceleration == true)
        {
            
            rotSpeed *= 0.95f;
            //���X�Ɍ���
            if (rotSpeed <= 0.01)
            {
                rotSpeed = 0;
            }
            //�������I�������t���O��Ԃ�
            if (rotSpeed == 0)
            {
                isStop = true;
                isDeceleration = false;
            }
        }
    }
}