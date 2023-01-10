using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public Transform[] checkPoints;
    public GameObject player;
    public bool spawnPoint = true;
    void Start()
    {
        if (spawnPoint)
        {
            int tempCheckPoint = PlayerPrefs.GetInt("CheckPoint");
            player.transform.position = checkPoints[tempCheckPoint].position;
            //kontrol noktasýnda dogma komutu false ile kapýtýlýr
        }
    }
}
