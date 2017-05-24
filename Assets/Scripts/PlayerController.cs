using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody2D rb = new Rigidbody2D();
    BackpackBehaviour backpack;
	void Update () {
        //sets variable x to the value 
        CharacterMove();
        
	}

    void CharacterMove()
    {
        float speed = 3.0f;
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = 12.0f;
        }
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

    }
    void FixedUpdate()
    {
        
    } 
}
