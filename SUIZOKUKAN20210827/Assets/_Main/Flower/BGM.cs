using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class BGM : MonoBehaviour
{
    [SerializeField] private AudioSource a;//AudioSource型の変数aを宣言 使用するAudioSourceコンポーネントをアタッチ必要
    [SerializeField] private AudioClip b1;//AudioClip型の変数b1を宣言 使用するAudioClipをアタッチ必要
    [SerializeField] private AudioClip b2;//AudioClip型の変数b1を宣言 使用するAudioClipをアタッチ必要

    public void Start()
    {
        GetComponent<AudioSource>().enabled = true;

        a.PlayOneShot(b1);
    }


    public void PlaySoundSea()
    {
        a.Stop();
        GetComponent<AudioSource>().enabled = true;        
        a.PlayOneShot(b2);
    }
}