using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower_triggerFinish : MonoBehaviour
{
    GameObject Underwater;
    // Start is called before the first frame update
    void Start()
    {
        Underwater = GameObject.Find("Underwater");
    }

    void OnTriggerEnter(Collider other)
    {
        Underwater.GetComponent<UpSeaSurface>().enabled = true;
        Underwater.GetComponent<BGM>().PlaySoundSea();

    }
}
