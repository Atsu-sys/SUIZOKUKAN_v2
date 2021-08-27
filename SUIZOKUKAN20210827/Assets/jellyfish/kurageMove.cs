using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kurageMove : MonoBehaviour
{
    private float timeleft;

    private float randomX;
    private float randomY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //6-8•b‚²‚Æ‚Éˆ—‚ğs‚¤
        timeleft -= Time.deltaTime;
        if (timeleft <= 0.0)
        {
            float x = Random.Range(0.0004f, -0.0004f);
            float z = Random.Range(0.0004f, -0.0004f);
            float time = Random.Range(6.0f, 8.0f);

            Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody‚ğæ“¾
            Vector3 force = new Vector3(x, 0.0004f, z);    // —Í‚ğİ’è
            rb.AddForce(force, ForceMode.Force);
            timeleft = time;
        }
    }
}
