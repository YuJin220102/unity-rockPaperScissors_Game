using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject playerObj;
    /////////////////////1
    public GameObject contrl1;
    public GameObject leftKey1;
    public GameObject righttKey1;
    public GameObject upKey1;
    public GameObject downKey1;
    /////////////////////2
    public GameObject contrl2;
    public GameObject leftKey2;
    public GameObject righttKey2;
    public GameObject upKey2;
    public GameObject downKey2;


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

    public void contrl1Btn(){

        contrl1.SetActive(false);
        leftKey1.SetActive(false);
        righttKey1.SetActive(false);
        upKey1.SetActive(false);
        downKey1.SetActive(false);


        contrl2.SetActive(true);
        leftKey2.SetActive(true);
        righttKey2.SetActive(true);
        upKey2.SetActive(true);
        downKey2.SetActive(true);
    }

    public void contrl2Btn(){
        
        contrl1.SetActive(true);
        leftKey1.SetActive(true);
        righttKey1.SetActive(true);
        upKey1.SetActive(true);
        downKey1.SetActive(true);


        contrl2.SetActive(false);
        leftKey2.SetActive(false);
        righttKey2.SetActive(false);
        upKey2.SetActive(false);
        downKey2.SetActive(false);
    }
}
