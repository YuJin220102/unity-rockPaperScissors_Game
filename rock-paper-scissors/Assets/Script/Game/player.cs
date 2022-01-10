using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    // 위험 존
    static public int risk; 
    static public int count;
    
    // 안전 존
    static public int Safety;

    // 가위바위보 오브젝트
    public GameObject text;
    public GameObject rock;
    public GameObject paper;
    public GameObject scissors;
    // rock, paper, scissors - rand position
    static public int[] rand = new int[3];
    // Representative, rock-paper-scissors
    static public int Rptrand;
    // timer
    static public float timer = 0;
    static public float time = 5f;

    // Move
    static public float left = 0.8f;
    static public float right = 0.8f;
    static public float up = 0.8f;
    static public float down = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        rock.SetActive(false);
        paper.SetActive(false);
        scissors.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
  
        if(time < timer){

            // 레벨 이상일 때부터 장애물 시작
            if(Level.num1 >= 3){
                // 랜덤 장애물 생성
                if(count > 0 && count < 6){
                    Safety_risk(Random.Range(0,25), Random.Range(0,25));
                }
                count++;
                if(count >= 6){
                    // 한단계 올라갈때마다 초기화
                    for(int i = 0; i < 25; i++){
                        GameObject.Find("Image" + i).GetComponent<BoxCollider2D>().enabled = false;
                        GameObject.Find("Image" + i).GetComponent<Image>().color = new Color(82/255f, 82/255f, 82/255f, 255/255f); 
                    }
                    count = 0;
                }
            }

            // 가위바위보 접촉 하지 않았을 때
            ChangeColor.ok = false;

            // "?" 텍스트 false
            text.SetActive(false);
            // 가위바위보 보여줌
            rock.SetActive(true);
            paper.SetActive(true);
            scissors.SetActive(true);

            ChangeColor.ok = true;
            // 컴퓨터 랜덤 가위바위보
            Rptrand = Random.Range(0,3);

            // 0 Collider is running.
            GameObject.Find("0").GetComponent<BoxCollider2D>().enabled = true;

            // 플레이어 가위바위보 랜덤 위치 값 넣고 위치 겹침 방지
            // Random location and overlap prevention
            PositionCheck(Random.Range(0,20), Random.Range(0,20), Random.Range(0,20));
        
            timer = 0;
            time = 5f;
            
        }
        Move();
    }
    
    public void Move(){ // Directional movement
    if(Input.GetKeyDown(KeyCode.A)){
        transform.Translate(-left, 0, 0);
        }
    if(Input.GetKeyDown(KeyCode.D)){
        transform.Translate(right, 0, 0);
        }
    if(Input.GetKeyDown(KeyCode.W)){
        transform.Translate(0, up, 0);
        }
    if(Input.GetKeyDown(KeyCode.S)){
        transform.Translate(0, -down, 0);
        }
    }

    public void PositionCheck(int a, int b, int c){
        rand[0] = a; // rock
        rand[1] = b; // paper
        rand[2] = c; // scissors

        // 위치 겹칠 시
        // positions overlap
        if((rand[0] == rand[1]) || (rand[0] == rand[2]) || (rand[1] == rand[2])){
            PositionCheck(Random.Range(0,20), Random.Range(0,20), Random.Range(0,20));
        }
        // 위치 겹치지 않을 시
        // doesn't overlap
        if((rand[0] != rand[1]) && (rand[0] != rand[2]) && (rand[1] != rand[2])){
            return;
        }
    }

    public void Safety_risk(int a, int b){
        Safety = a;
        risk = b;

        if(Safety == risk){
            Safety_risk(Random.Range(0,25), Random.Range(0,25));
        }

        if(Safety != risk){
            return;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Replay.die = true;
    }

}

