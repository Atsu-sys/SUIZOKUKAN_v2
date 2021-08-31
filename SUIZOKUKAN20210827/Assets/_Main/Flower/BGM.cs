using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class BGM : MonoBehaviour
{
    [SerializeField] private AudioSource a;//AudioSource�^�̕ϐ�a��錾 �g�p����AudioSource�R���|�[�l���g���A�^�b�`�K�v
    [SerializeField] private AudioClip b1;//AudioClip�^�̕ϐ�b1��錾 �g�p����AudioClip���A�^�b�`�K�v
    [SerializeField] private AudioClip b2;//AudioClip�^�̕ϐ�b1��錾 �g�p����AudioClip���A�^�b�`�K�v

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