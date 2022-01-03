using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    static public int rand;
    float time;
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
        time += Time.deltaTime;
        if(time > 5f){
            rand = Random.Range(1,2);
            time = 0;
            Debug.Log(rand);
        }

        Move();
    }
    
    public void Move(){ // 방향 이동
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

