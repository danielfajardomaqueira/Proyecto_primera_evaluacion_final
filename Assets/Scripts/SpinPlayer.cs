using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPlayer : MonoBehaviour
{
    public int rotSpeed = 100;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spin del personaje
        transform.Rotate(Vector3.right * rotSpeed * Time.deltaTime * verticalInput);
    }
}
