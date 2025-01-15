using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int score;
    public Text text;
    public GameObject gameoverscreen;

    public void addscore(int scoretoadd)
    {
        score=score+scoretoadd;
        text.text=score.ToString();
    }
    
public void restart()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
public void gameover()
{
    gameoverscreen.SetActive(true);
}
}
