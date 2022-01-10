using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_play : MonoBehaviour
{
    public GameObject stop;
    public GameObject play;
    public void stopBtn(){
        // 플레이어 이동 정지
        player.left = 0;
        player.right = 0;
        player.up = 0;
        player.down = 0;
            
        // 게임 일시정지
        Time.timeScale = 0;

        // play 버튼 보여줌
        stop.SetActive(false);
        play.SetActive(true);
    }
    public void playBtn(){ 
        player.left = 0.8f;
        player.right = 0.8f;
        player.up = 0.8f;
        player.down = 0.8f;
            
        Time.timeScale = 1;

        stop.SetActive(true);
        play.SetActive(false);
    }
}
