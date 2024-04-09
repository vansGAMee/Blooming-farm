using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saunds : MonoBehaviour{
    public AudioClip din;
    void Start() {   //при старте
        if(this.name == "din") {     //вставка mp3
            GetComponent<AudioSource>().PlayOneShot(din);     // получаем AudioSource
        }
    }
}