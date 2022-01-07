using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject playerObj;
    public void Left(){
        playerObj.transform.Translate(-player.left, 0, 0);
    }
    public void Right(){
        playerObj.transform.Translate(player.right, 0, 0);
    }
    public void Down(){
        playerObj.transform.Translate(0, -player.down, 0);
    }
    public void Up(){
        playerObj.transform.Translate(0, player.up, 0);
    }
}
