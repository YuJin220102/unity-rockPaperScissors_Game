using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    bool test2;
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
        test2 = false;
        left = 0.77f;
        right = 0.77f;
        up = 0.77f;
        down = 0.77f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //timer2 += Time.deltaTime;
        //if(RPStime < timer2){
        //    Rptrand = Random.Range(0,3);
        //    Color1_1.ok = false;
        //}
        if(time < timer){
            Color1_1.ok = true;
            // 묵 찌 빠 랜덤 값 넣고
            for(int i = 0; i < 3; i++){
                Rptrand = Random.Range(0,3);
                rand[i] = Random.Range(0,24);
            }
            while(test2 == true){
                test();
            }
            Debug.Log("1 : "+ rand[0]);
            Debug.Log("2 : "+ rand[1]);
            Debug.Log("3 : "+ rand[2]);
            timer = 0;
        }
            // 위치 겹침 방지
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

    public void test(){
        if((rand[0] == rand[1]) || (rand[0] == rand[2]) || (rand[1] == rand[2])){
            test2 = false;
            rand[0] = Random.Range(0,24);
            rand[1] = Random.Range(0,24);
            rand[2] = Random.Range(0,24);
        }
        if((rand[0] != rand[1]) || (rand[0] != rand[2]) || (rand[1] != rand[2])){
            test2 = true;
        }
    }
}

