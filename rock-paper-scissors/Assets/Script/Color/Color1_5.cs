using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color1_5 : MonoBehaviour
{
    // public GameObject a;
    // bool ok;
    static public bool ok;
    private void Update() {
        if(Color1_1.ok == false){
            GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f);
        }
    //     if(a.transform.position == new Vector3(0.77f, 2.31f, 0))ok = true;
    //     else{
    //         ok = false;
    //         GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f);
    //     }
    }


    private void OnTriggerEnter2D(Collider2D other) {
        // rock이 0의 자리일 때
       if(player.rand[0] == 4){
           if(player.Rptrand == 0){
               GetComponent<Image>().color = new Color(255/255f, 255/255f, 74/255f, 255/255f);
               Debug.Log("무승부");
           }
           if(player.Rptrand == 1){
               GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);
               Debug.Log("졌음");
           }
           if(player.Rptrand == 2){
               GetComponent<Image>().color = new Color(98/255f, 225/255f, 255/255f, 255/255f);
               player.timer += 4f;
                player.timer2 += 4f;
               Debug.Log("이김");
           }
       }
       // paper이 0의 자리일 때
       if(player.rand[1] == 4){
           if(player.Rptrand == 0){
               GetComponent<Image>().color = new Color(98/255f, 225/255f, 255/255f, 255/255f);
               player.timer += 4f;
                player.timer2 += 4f;
               Debug.Log("이김");
           }
           if(player.Rptrand == 1){
               GetComponent<Image>().color = new Color(255/255f, 255/255f, 74/255f, 255/255f);
               Debug.Log("무승부");
           }
           if(player.Rptrand == 2){
               GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);
               Debug.Log("졌음");
           }
       }
       // scissors이 0의 자리일 때
       if(player.rand[2] == 4){
           if(player.Rptrand == 0){
               GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);
               Debug.Log("졌음");
           }
           if(player.Rptrand == 1){
               GetComponent<Image>().color = new Color(98/255f, 225/255f, 255/255f, 255/255f);
               player.timer += 4f;
                player.timer2 += 4f;
               Debug.Log("이김");
           }
           if(player.Rptrand == 2){
               GetComponent<Image>().color = new Color(255/255f, 255/255f, 74/255f, 255/255f);
               Debug.Log("무승부");
           }
       }
        // if(ok == true){
        //     GetComponent<Image>().color = new Color(255/255f, 160/255f, 160/255f, 255/255f);
        // }
    }
}
