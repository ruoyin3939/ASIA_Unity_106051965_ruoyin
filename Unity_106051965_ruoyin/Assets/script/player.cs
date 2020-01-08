
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("玩家")]
    public string run = "跑步開關";
    public Animator ani;

    [Header("需要道具")]
    public int demand = 10;
    [Header("現有道具")]
    public int have = 0;


    private void running()
    {
        print("水平" + Input.GetAxis("Horizontal"));
        print("垂直" + Input.GetAxis("Vertical"));

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        print("跑步動畫");
        ani.SetBool("跑步開關", h != 0 || v != 0);
    }

        private void eatprop()
        {

        }

        private void pass()
        {

        }

        private void Update()
        {
             running();
           }




    

    }

















