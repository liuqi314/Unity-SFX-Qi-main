using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPause : MonoBehaviour
{
    public AudioSource MusicPlayer;

    private void OnTriggerEnter()
    {
       MusicPlayer.Pause();
        
    }


    private void OnTriggerExit()
    {
      
        MusicPlayer.Play();
    }



}
