using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Flower_Trigger : MonoBehaviour
{
    [SerializeField] private AudioSource a;//AudioSource�^�̕ϐ�a��錾 �g�p����AudioSource�R���|�[�l���g���A�^�b�`�K�v
    [SerializeField] private AudioClip b1;//AudioClip�^�̕ϐ�b1��錾 �g�p����AudioClip���A�^�b�`�K�v

    void OnTriggerEnter(Collider other)
    {
        GetComponent<VisualEffect>().enabled = true;
        GetComponent<AudioSource>().enabled = true;

        a.PlayOneShot(b1);
    }
}