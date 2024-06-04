using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Roulette : MonoBehaviour
{//’Ç‰Á
    float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //’Ç‰Á
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = -100;


           
        }
        transform.Rotate(0, 0, this.speed);

        
        this.speed *= 0.96f;

        //’Ç‰Á
        
        
        
    }

}
