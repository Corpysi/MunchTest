using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //移動
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-Speed, 0,0);
        }

       else if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(Speed, 0, 0);
        }
    }
}
