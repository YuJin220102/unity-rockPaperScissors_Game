using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    // rock, scissors, paper - rand position
    static public int[,] test = new int[3, 2];

    // timer
    float timer = 0;
    static public float time = 5f;

    // Move
    static public float left;
    static public float right;
    static public float up;
    static public float down;

    // Start is called before the first frame update
    void Start()
    {        
        left = 0.77f;
        right = 0.77f;
        up = 0.77f;
        down = 0.77f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(time < timer){

            // random position
            for(int i = 0; i < 3; i++){
                for(int j = 0; j < 2; j++){
                    test[i,j] = Random.Range(0, 7);
                    }
                }
            //To prevent overlapping // ?? 하는중.............
            
            if(test[0,1] > 0 && test[0,1] < 6){
                if(test[0,0] > 0 && test[0,0] < 6){
                    test[0, 0] = 0;
                }
            }
            
            // if(test[0,0] == test[1,0]){
            //     if(test[0,1] == test[1,1]){
            //         test[0,1] = Random.Range(0, 7);
            //     }
            // }
            // if(test[0,0] == test[2,0]){
            //     if(test[0,1] == test[2,1]){
            //         test[0,1] = Random.Range(0, 7);
            //     }
            // } 
            // if(test[1,0] == test[2,0]){
            //     if(test[1,1] == test[2,1]){
            //         test[1,1] = Random.Range(0, 7);
            //     }
            // } 

            Debug.Log("1 : " + test[0,0] + " " + test[0,1]);
            Debug.Log("2 : " + test[1,0] + " " + test[1,1]);
            Debug.Log("3 : " + test[2,0] + " " + test[2,1]);

            timer = 0;
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
}

