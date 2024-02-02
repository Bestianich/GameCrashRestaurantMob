using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 5;                

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void MoveHorizontal(){
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal") , 0 , 0) * speed * Time.deltaTime;
        transform.Translate(direction , Space.Self);
    }

    void MoveVertical(){
        Vector3 direction = new Vector3(0 , Input.GetAxis("Vertical") , 0) * speed * Time.deltaTime;
        transform.Translate(direction , Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        MoveVertical();
    }
}
