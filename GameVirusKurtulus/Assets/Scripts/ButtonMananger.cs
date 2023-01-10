using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonMananger : MonoBehaviour
{
    public Transform toGo;
    public GameObject player;
    public Text text;
    
    public void teleportToNext()
    {
        player.transform.position = toGo.position;
    }
    //Button'a eklenecek bu script sonra on click eventtan bu button uzerine suruklenip fonsiyon secilcek
}
