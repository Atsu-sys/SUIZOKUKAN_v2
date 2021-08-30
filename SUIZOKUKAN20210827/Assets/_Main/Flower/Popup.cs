using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{

    private float timeleft = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeleft -= Time.deltaTime;

        if(timeleft >= 0.0f)
        {
            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody‚ğæ“¾
            Vector3 force = new Vector3(0, 3.0f, 0);    // —Í‚ğİ’è
            rb.AddForce(force, ForceMode.Force);

            Debug.Log(timeleft);
        }

        else
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
