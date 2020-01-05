using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ses : MonoBehaviour
{
    public void OnPlay() {
        GetComponent<AudioSource>().pitch=1f;
        
        GetComponent<AudioSource>().Play();
       


    }
   
}
