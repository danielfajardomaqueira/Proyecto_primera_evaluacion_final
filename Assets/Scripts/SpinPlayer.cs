using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlayer : MonoBehaviour
{
    public int speedRot = 350;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            spinPlayer();
        }
    }

    private void spinPlayer()
    {
        //Spin del personaje
        //transform.(Vector3.right * rotSpeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.left, speedRot * Time.deltaTime);
    }
}
