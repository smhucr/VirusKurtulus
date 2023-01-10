using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaboCheckPonit : MonoBehaviour
{
    public int locationid;
    private void Update()
    {
        string CheckPoint = PlayerPrefs.GetString("CPTriggered");
        if (locationid == PlayerPrefs.GetInt("CheckPoint"))
        {
            if (CheckPoint.Equals("true"))
            {
                GetComponent<Animator>().SetBool("isTriggered", true);
            }
        }
        else
        {
            GetComponent<Animator>().SetBool("isTriggered", false);
        }
    }
  
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Animator>().SetBool("isTriggered",true);
            PlayerPrefs.SetString("CPTriggered", "true");
            PlayerPrefs.SetInt("CheckPoint", locationid);
        }
    }
}
