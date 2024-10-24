using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeScript : MonoBehaviour
{
    Rigidbody Ana;
    // Start is called before the first frame update
    void Start()
    {
        
        
        Ana = GetComponent<Rigidbody>();
        Ana.AddForce(10*transform.forward, ForceMode.Impulse);
    
}
}

    // Update is called once per frame

 