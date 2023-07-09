using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipHandler : MonoBehaviour
{
    [SerializeField] private string currentColor;
    private CircleCollider2D circleCollider;

    private void Start()
    {
        currentColor = gameObject.tag;

        //Getcomponent
        circleCollider = GetComponent<CircleCollider2D>();
        circleCollider.enabled = false;
        StartCoroutine(ColliderDelay());

        /*SpawnProbe();*/
    }

    private void Update()
    {
        if (gameObject.CompareTag("left"))
        {
            if(GameManager.NeedChangeL == "yes" && currentColor == "black")
            {
                ChangeColorWhite();
            }
            else if(GameManager.NeedChangeL == "yes" && currentColor == "white")
            {
                ChangeColorBlack();
            }
            else if (GameManager.NeedChangeL == "reverse" && currentColor == "black")
            {
                gameObject.tag = "black";
            }
            else if (GameManager.NeedChangeL == "reverse" && currentColor == "white")
            {
                gameObject.tag = "white";
            }
        }
        else if (gameObject.CompareTag("right"))
        {
            if (GameManager.NeedChangeR == "yes" && currentColor == "black")
            {
                ChangeColorWhite();
            }
            else if (GameManager.NeedChangeR == "yes" && currentColor == "white")
            {
                ChangeColorBlack();
            }
            else if (GameManager.NeedChangeR == "reverse" && currentColor == "black")
            {
                gameObject.tag = "black";
            }
            else if (GameManager.NeedChangeR == "reverse" && currentColor == "white")
            {
                gameObject.tag = "white";
            }
        }
        else if (gameObject.CompareTag("up"))
        {
            if (GameManager.NeedChangeU == "yes" && currentColor == "black")
            {
                ChangeColorWhite();
            }
            else if (GameManager.NeedChangeU == "yes" && currentColor == "white")
            {
                ChangeColorBlack();
            }
            else if (GameManager.NeedChangeU == "reverse" && currentColor == "black")
            {
                gameObject.tag = "black";
            }
            else if (GameManager.NeedChangeU == "reverse" && currentColor == "white")
            {
                gameObject.tag = "white";
            }
        }
        else if (gameObject.CompareTag("down"))
        {
            if (GameManager.NeedChangeD == "yes" && currentColor == "black")
            {
                ChangeColorWhite();
            }
            else if (GameManager.NeedChangeD == "yes" && currentColor == "white")
            {
                ChangeColorBlack();
            }
            else if (GameManager.NeedChangeD == "reverse" && currentColor == "black")
            {
                gameObject.tag = "black";
            }
            else if (GameManager.NeedChangeD == "reverse" && currentColor == "white")
            {
                gameObject.tag = "white";
            }
        }
        else if (gameObject.CompareTag("dl"))
        {
            if (GameManager.NeedChangeDL == "yes" && currentColor == "black")
            {
                ChangeColorWhite();
            }
            else if (GameManager.NeedChangeDL == "yes" && currentColor == "white")
            {
                ChangeColorBlack();
            }
            else if (GameManager.NeedChangeDL == "reverse" && currentColor == "black")
            {
                gameObject.tag = "black";
            }
            else if (GameManager.NeedChangeDL == "reverse" && currentColor == "white")
            {
                gameObject.tag = "white";
            }
        }
        else if (gameObject.CompareTag("dr"))
        {
            if (GameManager.NeedChangeDR == "yes" && currentColor == "black")
            {
                ChangeColorWhite();
            }
            else if (GameManager.NeedChangeDR == "yes" && currentColor == "white")
            {
                ChangeColorBlack();
            }
            else if (GameManager.NeedChangeDR == "reverse" && currentColor == "black")
            {
                gameObject.tag = "black";
            }
            else if (GameManager.NeedChangeDR == "reverse" && currentColor == "white")
            {
                gameObject.tag = "white";
            }
        }
        else if (gameObject.CompareTag("ul"))
        {
            if (GameManager.NeedChangeUL == "yes" && currentColor == "black")
            {
                ChangeColorWhite();
            }
            else if (GameManager.NeedChangeUL == "yes" && currentColor == "white")
            {
                ChangeColorBlack();
            }
            else if (GameManager.NeedChangeUL == "reverse" && currentColor == "black")
            {
                gameObject.tag = "black";
            }
            else if (GameManager.NeedChangeUL == "reverse" && currentColor == "white")
            {
                gameObject.tag = "white";
            }
        }
        else if (gameObject.CompareTag("ur"))
        {
            if (GameManager.NeedChangeUR == "yes" && currentColor == "black")
            {
                ChangeColorWhite();
            }
            else if (GameManager.NeedChangeUR == "yes" && currentColor == "white")
            {
                ChangeColorBlack();
            }
            else if (GameManager.NeedChangeUR == "reverse" && currentColor == "black")
            {
                gameObject.tag = "black";
            }
            else if (GameManager.NeedChangeUR == "reverse" && currentColor == "white")
            {
                gameObject.tag = "white";
            }
        }
    }

    private void ChangeColorBlack()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
        gameObject.tag = "black";
        currentColor = gameObject.tag;
        GameManager.blackScore += 1;
        GameManager.whiteScore -= 1;
    }

    private void ChangeColorWhite()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        gameObject.tag = "white";
        currentColor = gameObject.tag;
        GameManager.whiteScore += 1;
        GameManager.blackScore -= 1;
    }

    IEnumerator ColliderDelay()
    {
        yield return new WaitForSeconds(1);
        circleCollider.enabled = true;
    }
}