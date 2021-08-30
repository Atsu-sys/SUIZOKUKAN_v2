using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFlower : MonoBehaviour
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
        // ƒ[ƒ‹ƒh‚Ìy²‚É‰ˆ‚Á‚Ä1•bŠÔ‚É90“x‰ñ“]
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.World);      
    }
}