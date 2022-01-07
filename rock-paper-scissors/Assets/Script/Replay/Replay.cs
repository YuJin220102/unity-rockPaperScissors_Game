using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Replay : MonoBehaviour
{
    public GameObject text;
    public GameObject rock;
    public GameObject paper;
    public GameObject scissors;
    public Text Best;
    int Score = 1;
    static public bool die = false;
    public GameObject playerObj;
    public CanvasGroup GameCG;
    public CanvasGroup ReplayCG;


    // Update is called once per frame
    void Update()
    {
        if(die == true){
            // 플레이어 이동 정지
            player.left = 0;
            player.right = 0;
            player.up = 0;
            player.down = 0;
            
            // 게임 일시정지
            Time.timeScale = 0;

            // Replay 캔버스 킴
            ON(ReplayCG);
            OFF(GameCG);
        }
    }
    public void BtnClick(){
        // 일시정지 해제
        Time.timeScale = 1;
        die = false;

        // 플레이어 이동 활성화
        player.left = 0.8f;
        player.right = 0.8f;
        player.up = 0.8f;
        player.down = 0.8f;

        // 플레이어 위치 초기로 이동
        playerObj.transform.position = new Vector3(0,0,0);

        // 시간 처음으로
        Timer.num = 11f; 
        player.timer = 0f;

        // Best 점수 추가
        if(Score < Level.BestLv){
            Score = Level.BestLv;
            Best.GetComponent<Text>().text = "BEST : " + Level.BestLv.ToString();
        }
        else{
            Best.GetComponent<Text>().text = "BEST : " + Score.ToString();
        }

        // 플레이어 가위바위보 없애줌
        rock.SetActive(false);
        paper.SetActive(false);
        scissors.SetActive(false);

        text.SetActive(true);

        // 레벨 초기로 변경
        Level.num1 = 1;
        Level.num2 = 2;

        // 색상 회색으로 변경
        ChangeColor.ok = false;

        // 게임화면으로 돌아감
        ON(GameCG);
        OFF2(ReplayCG);
    }

    // Canvas On or Off
    public void ON(CanvasGroup cg){
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void OFF(CanvasGroup cg){
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
    public void OFF2(CanvasGroup cg){
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
}
