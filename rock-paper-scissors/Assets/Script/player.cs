using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    // rock, paper, scissors - rand position
    static public int[] rand = new int[3];
    // Representative, rock-paper-scissors
    static public int Rptrand;
    // timer
    static public float timer = 0;
    static public float time = 5f;
    static public float RPStime = 4.8f;
    static public float timer2 = 0;

    // Move
    static public float left;
    static public float right;
    static public float up;
    static public float down;

    // Start is called before the first frame update
    void Start()
    {
        left = 0.8f;
        right = 0.8f;
        up = 0.8f;
        down = 0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if((time - 0.01f) < timer){
            ColorTEST.ok = false;
        }
        if(time < timer){
            ColorTEST.ok = true;
            Rptrand = Random.Range(0,3);

            // 랜덤 위치 값 넣고 위치 겹침 방지
            // Random location and overlap prevention
            PositionCheck(Random.Range(0,24), Random.Range(0,24), Random.Range(0,24));

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
            PositionCheck(Random.Range(0,24), Random.Range(0,24), Random.Range(0,24));
        }
        // 위치 겹치지 않을 시
        // doesn't overlap
        if((rand[0] != rand[1]) && (rand[0] != rand[2]) && (rand[1] != rand[2])){
            return;
        }
    }
}

