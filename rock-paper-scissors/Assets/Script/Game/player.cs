using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    static public int Obs; 
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
        if((time - 0.01f) < timer){
            ChangeColor.ok = false;
        }
        if(time < timer){
            text.SetActive(false);
            rock.SetActive(true);
            paper.SetActive(true);
            scissors.SetActive(true);

            ChangeColor.ok = true;
            Rptrand = Random.Range(0,3);

            // 랜덤 위치 값 넣고 위치 겹침 방지
            // Random location and overlap prevention
            PositionCheck(Random.Range(0,20), Random.Range(0,20), Random.Range(0,20));
            Obs = Random.Range(0,25);

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
    private void OnCollisionEnter2D(Collision2D other) {
        Replay.die = true;
    }

}

