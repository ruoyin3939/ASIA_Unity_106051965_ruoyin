using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class eatprop : MonoBehaviour
{
    [Header("寶相數量介面")]
    public Text textcount;
    [Header("提示畫面")]
    public GameObject objTip;

    public int propCount;
    public int propTotal = 10;
    public bool finish;
    public hint ht;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "寶箱")
        {
            Destroy(collision.gameObject);


            propCount++;
            textcount.text = "寶箱:" + propCount + "/10";

            if (propCount == propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }
        }

    }

    private void Update()
    {
        Gameover();
    }

    private string T1 = "按 E 離開遊戲";
    private string T2 = "按 R 重新遊戲";
    private void Gameover()

    {
        if (finish)
        {
            if (Input.GetKeyDown(KeyCode.E))
            { Application.Quit(); }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("game");
            }
            
            if (finish)
            {
                ht.ShowDialog(T1, T2);
            }
        }

    }

}
