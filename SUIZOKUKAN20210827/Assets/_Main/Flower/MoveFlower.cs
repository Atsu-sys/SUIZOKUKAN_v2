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
        // ���[���h��y���ɉ�����1�b�Ԃ�90�x��]
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.World);      
    }
}