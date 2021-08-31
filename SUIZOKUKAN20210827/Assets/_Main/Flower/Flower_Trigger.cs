using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Flower_Trigger : MonoBehaviour
{
    [SerializeField] private AudioSource a;//AudioSource型の変数aを宣言 使用するAudioSourceコンポーネントをアタッチ必要
    [SerializeField] private AudioClip b1;//AudioClip型の変数b1を宣言 使用するAudioClipをアタッチ必要
    GameObject child;

    private void Start()
    {
       child = transform.GetChild(0).gameObject;
    }
    void OnTriggerEnter(Collider other)
    {
        GetComponent<VisualEffect>().enabled = true;
        GetComponent<AudioSource>().enabled = true;
        GetComponent<AudioSource>().enabled = true;

        child.GetComponent<Light>().enabled = true;
        
        a.PlayOneShot(b1);
    }
}