using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;
    [SerializeField] private AudioClip pickupSound;

    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score :" + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "MyCoin")
        {
            //[SerializeField] private AudioClip pickupSound;
            SoundManager.instance.PlaySound(pickupSound);
            ScoreNum += 1;
            Destroy(Coin.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }
    }


}
