using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Возможно если будет время то передеать неоторые вещи под юнити ивенты , что бы было по красоте
// например обновление счета не через update() , а через ивент и т.п.

public class GameManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] Timer timer;
    [SerializeField] ScoreManagerPaint scoreManagerPaint;
    [SerializeField] ScoreManagerPaintRed scoreManagerPaintRed;
    [SerializeField] private GameObject RedWinPanel;
    [SerializeField] private GameObject BlueWinPanel;
    [SerializeField] private GameObject DrawPanel;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject Pong;
    [SerializeField] private GameObject Racing;
    [SerializeField] private GameObject Paint;
    [SerializeField] private Collider2D CameraCol;
    [SerializeField] private Transform Camera;
    [SerializeField] private Rigidbody2D CameraRb;

    private void Awake()
    {
        Finish.BlueWin.AddListener(BlueWin);
        Finish.RedWin.AddListener(RedWin);
    }
    void Update()
    {
        PongGame();
        WhoWinInPaint();
    }

    // через корутну сделать показ окна выигрыша , затем через пару секунд перйти в главное меню к выбору

    public void ResetScore()
    {
        scoreManager.FirstPlayerScore = 0;
        scoreManager.SecondPlayerScore = 0;
    }


    public void StartPongGame()
    {
        CameraCol.enabled = false;
        MainMenu.SetActive(false);
        Pong.SetActive(true);
    }

    private void PongGame()
    {
        if (scoreManager.FirstPlayerScore == 5)
        {
            BlueWinPanel.SetActive(true);
            ResetScore();
        }
        if (scoreManager.SecondPlayerScore == 5)
        {
            RedWinPanel.SetActive(true);
            ResetScore();
        }
    }

    public void StartPaintGame()
    {
        CameraCol.enabled = false;
        MainMenu.SetActive(false);
        Paint.SetActive(true);
    }
    private void BlueWin()
    {
        StartCoroutine(BlueWinCor());
    }
    private void RedWin()
    {
        StartCoroutine(RedWinCor());
    }
    private void Draw()
    {
        StartCoroutine(DrawCor());
    }

    public void StartRacingGame()
    {
        MainMenu.SetActive(false);
        Racing.SetActive(true);
        CameraCol.enabled = true;
    }
    public void BackToMenu()
    {
        DrawPanel.SetActive(false);
        RedWinPanel.SetActive(false);
        BlueWinPanel.SetActive(false);
        MainMenu.SetActive(true);
        Racing.SetActive(false);
        Pong.SetActive(false);
        Paint.SetActive(false);
        CameraCol.enabled = false;
        Camera.position = Vector2.zero;
        CameraRb.velocity = Vector2.zero;
    }

    private void WhoWinInPaint()
    {
        if (timer.Complited == true)
        {
            if (scoreManagerPaint.score > scoreManagerPaintRed.score)
            {
                BlueWin();
            }
            if (scoreManagerPaint.score < scoreManagerPaintRed.score)
            {
                RedWin();
            }
            if (scoreManagerPaint.score == scoreManagerPaintRed.score)
            {
                Draw();
            }
        }
    }

    private IEnumerator BlueWinCor()
    {
        BlueWinPanel.SetActive(true);
        yield return new WaitForSeconds(3);
        BackToMenu();
    }
    private IEnumerator RedWinCor()
    {
        RedWinPanel.SetActive(true);
        yield return new WaitForSeconds(3);
        BackToMenu();
    }
    private IEnumerator DrawCor()
    {
        DrawPanel.SetActive(true);
        yield return new WaitForSeconds(3);
        BackToMenu();
    }
}



