using UnityEngine;
using UnityEngine.UI; //引用文字介面

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text TV;
    [Header("分數")]
    public int score;
    //[Header("進球音效")]
    //public AudioClip Sound;


    private void OnTriggerEnter(Collider other) //進入感應區
    {
        if (other.tag =="撞球")
        {
            AddScore();
        }

        if (other.tag == "特殊撞球")
        {
            AddMoreScore();
        }

        if (other.transform.root.name == "Player")
        {
            print("歡迎來到公主撞球場");
        }
    }

    //加分系統
    private void AddScore()
    {
        score += 1;
        TV.text = "Score : " + score;
        
    }

    private void AddMoreScore()
    {
        score += 2;
        TV.text = "Score : " + score;

    }
}
