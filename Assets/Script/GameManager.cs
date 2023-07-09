using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static string CurrentTurn = "black";
    public static string NeedChangeL = "no";
    public static string NeedChangeR = "no";
    public static string NeedChangeU = "no";
    public static string NeedChangeD = "no";
    public static string NeedChangeUL = "no";
    public static string NeedChangeUR = "no";
    public static string NeedChangeDR = "no";
    public static string NeedChangeDL = "no";

    public static int blackScore = 0;
    public static int whiteScore = 0;

    [Header("Text Settings")]
    [SerializeField] private TMP_Text blackScoreUI;
    [SerializeField] private TMP_Text whiteScoreUI;
    [SerializeField] private TMP_Text currentTurnUI;
    [SerializeField] private TMP_Text winnerTitleUI;

    [Header("Canvas Settings")]
    [SerializeField] private GameObject StartUI;
    [SerializeField] private GameObject GameOverUI;
    [SerializeField] private GameObject MainUI;

    private BoardSpawner boardS;

    private void Awake()
    {
        Screen.SetResolution(1280, 720, false);
    }

    private void Start()
    {
        NewGame();

        boardS = FindObjectOfType<BoardSpawner>();
        StartUI.SetActive(true);
        GameOverUI.SetActive(false);
        MainUI.SetActive(false);
    }

    private void Update()
    {
        SetScore();
        SetTurn();

        if(blackScore + whiteScore == 64 && Board.doneTurn == true)
        {
            GameOver();
        }
    }

    private void NewGame()
    {
        blackScore = 0;
        whiteScore = 0;
        CurrentTurn = "black";

        NeedChangeL = "no";
        NeedChangeR = "no";
        NeedChangeU = "no";
        NeedChangeD = "no";
        NeedChangeUL = "no";
        NeedChangeUR = "no";
        NeedChangeDR = "no";
        NeedChangeDL = "no";
}

    private void GameOver()
    {
        if(blackScore > whiteScore)
        {
            winnerTitleUI.text = "Black Wins";
        }
        else if(blackScore < whiteScore)
        {
            winnerTitleUI.text = "White Wins";
        }

        GameOverUI.SetActive(true);
    }

    private void SetTurn()
    {
        currentTurnUI.text = CurrentTurn + " turn";
    }

    private void SetScore()
    {
        if (blackScoreUI != null)
        {
            blackScoreUI.text = blackScore.ToString();
        }

        if (whiteScoreUI != null)
        {
            whiteScoreUI.text = whiteScore.ToString();
        }
    }

    public void StartButton()
    {
        NewGame();

        boardS.SpawnBoard();
        StartUI.SetActive(false);
        MainUI.SetActive(true);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameOverUI.SetActive(false);
        StartUI.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
