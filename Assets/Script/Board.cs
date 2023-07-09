using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private Transform probeL;
    [SerializeField] private Transform probeR;
    [SerializeField] private Transform probeU;
    [SerializeField] private Transform probeD;
    [SerializeField] private Transform probeUL;
    [SerializeField] private Transform probeUR;
    [SerializeField] private Transform probeDR;
    [SerializeField] private Transform probeDL;
    [SerializeField] private Transform whiteChip;
    [SerializeField] private Transform blackChip;
    public static bool doneTurn = true;

    private void OnMouseDown()
    {
        if (GameManager.CurrentTurn == "black" && doneTurn)
        {
            doneTurn = false;
            Instantiate(blackChip, transform.position, blackChip.rotation);
            GameManager.blackScore += 1;
            SpawnProbe();
            StartCoroutine(ChangeToWhite());
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else if(GameManager.CurrentTurn == "white" && doneTurn)
        {
            doneTurn = false;
            Instantiate(whiteChip, transform.position, whiteChip.rotation);
            GameManager.whiteScore += 1;
            SpawnProbe();
            StartCoroutine(ChangeToBlack());
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

    private void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
    }

    private void SpawnProbe()
    {
        Instantiate(probeL, transform.position, Quaternion.identity);
        Instantiate(probeR, transform.position, Quaternion.identity);
        Instantiate(probeU, transform.position, Quaternion.identity);
        Instantiate(probeD, transform.position, Quaternion.identity);
        Instantiate(probeUL, transform.position, Quaternion.identity);
        Instantiate(probeUR, transform.position, Quaternion.identity);
        Instantiate(probeDR, transform.position, Quaternion.identity);
        Instantiate(probeDL, transform.position, Quaternion.identity);
    }

    IEnumerator ChangeToWhite()
    {
        yield return new WaitForSeconds(1.2f);
        GameManager.NeedChangeL = "no";
        GameManager.NeedChangeR = "no";
        GameManager.NeedChangeU = "no";
        GameManager.NeedChangeD = "no";
        GameManager.NeedChangeDL = "no";
        GameManager.NeedChangeDR = "no";
        GameManager.NeedChangeUR = "no";
        GameManager.NeedChangeUL = "no";
        GameManager.CurrentTurn = "white";
        doneTurn = true;
    }

    IEnumerator ChangeToBlack()
    {
        yield return new WaitForSeconds(1.2f);
        GameManager.NeedChangeL = "no";
        GameManager.NeedChangeR = "no";
        GameManager.NeedChangeU = "no";
        GameManager.NeedChangeD = "no";
        GameManager.NeedChangeDL = "no";
        GameManager.NeedChangeDR = "no";
        GameManager.NeedChangeUR = "no";
        GameManager.NeedChangeUL = "no";
        GameManager.CurrentTurn = "black";
        doneTurn = true;
    }
}
