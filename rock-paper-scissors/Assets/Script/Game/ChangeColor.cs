using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public GameObject colorPlayer;
    static public bool ok;
    bool pass = false;
    float timer = 0;
    float time = 0.3f;
    static public float LevelUp = 0;

    // Update is called once per frame
    void Update()
    {
        // 플레이어와 접촉하지 않을 시 기본 색으로 변환
        // Change the basic color
        if(ok == false){
            GameObject.Find(player.rand[0].ToString()).GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f);
            GameObject.Find(player.rand[1].ToString()).GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f);
            GameObject.Find(player.rand[2].ToString()).GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f);
        }
        // 승리했을 때 기본 색상으로 변경 후 랜덤 가위바위보 바로 실행 
        // If you win, change the default color and play rock paper scissors
        if(pass == true){
           timer += Time.deltaTime;
           if(time < timer){
               GameObject.Find(player.rand[0].ToString()).GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f);
               GameObject.Find(player.rand[1].ToString()).GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f);
               GameObject.Find(player.rand[2].ToString()).GetComponent<Image>().color = new Color(149/255f, 149/255f, 149/255f, 255/255f);
               
               // 장애물 생상 기본 색상으로 변경, 콜라이더 해제
               GameObject.Find("Image"+player.Obs).GetComponent<Image>().color = new Color(82/255f, 82/255f, 82/255f, 255/255f); 
               GameObject.Find("Image"+player.Obs).GetComponent<BoxCollider2D>().enabled = false;

               player.time = 2f;
               pass = false;
           }
        }
    }


    private void OnTriggerEnter2D(Collider2D other) {
        //   승리 - 파란색 (Victory - Blue  )
        //   패배 - 빨간색 ( Defeat - Red   )
        // 무승부 - 노란색 (   draw - Yellow)
       if(colorPlayer.transform.position == new Vector3(Player_RPS.position[player.rand[0],0], Player_RPS.position[player.rand[0],1], 0)){
           if(player.Rptrand == 2){ // 승리(Victory)
               GameObject.Find(player.rand[0].ToString()).GetComponent<Image>().color = new Color(98/255f, 225/255f, 255/255f, 255/255f);
               pass = true;
               LevelUp += 0.2f;
               Timer.num = 6f;
           }
           if(player.Rptrand == 0){ // 무승부(draw)
                Replay.die = true;
                GameObject.Find(player.rand[0].ToString()).GetComponent<Image>().color = new Color(255/255f, 255/255f, 74/255f, 255/255f);
           }
           if(player.Rptrand == 1){ // 패배(Defeat)
                Replay.die = true;
               GameObject.Find(player.rand[0].ToString()).GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);
           }
       }

       if(colorPlayer.transform.position == new Vector3(Player_RPS.position[player.rand[1],0], Player_RPS.position[player.rand[1],1], 0)){
           if(player.Rptrand == 0){
               GameObject.Find(player.rand[1].ToString()).GetComponent<Image>().color = new Color(98/255f, 225/255f, 255/255f, 255/255f);
               pass = true;
               LevelUp += 0.2f;
               Timer.num = 6f;
           }
           if(player.Rptrand == 1){
               Replay.die = true;
               GameObject.Find(player.rand[1].ToString()).GetComponent<Image>().color = new Color(255/255f, 255/255f, 74/255f, 255/255f);
           }
           if(player.Rptrand == 2){
               Replay.die = true;
               GameObject.Find(player.rand[1].ToString()).GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);
           }
       }

       if(colorPlayer.transform.position == new Vector3(Player_RPS.position[player.rand[2],0], Player_RPS.position[player.rand[2],1], 0)){
           if(player.Rptrand == 1){
               GameObject.Find(player.rand[2].ToString()).GetComponent<Image>().color = new Color(98/255f, 225/255f, 255/255f, 255/255f);
               pass = true;
               LevelUp += 0.2f;
               Timer.num = 6f;
           }
           if(player.Rptrand == 2){
               Replay.die = true;
               GameObject.Find(player.rand[2].ToString()).GetComponent<Image>().color = new Color(255/255f, 255/255f, 74/255f, 255/255f);
           }
           if(player.Rptrand == 0){
               Replay.die = true;
               GameObject.Find(player.rand[2].ToString()).GetComponent<Image>().color = new Color(255/255f, 74/255f, 74/255f, 255/255f);
           }
       }
    }
}
