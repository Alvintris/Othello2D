using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeHandler : MonoBehaviour
{
    private Rigidbody2D rbProbe;
    [SerializeField] private Vector3 direction;

    private void Start()
    {
        rbProbe = GetComponent<Rigidbody2D>();
        rbProbe.velocity = direction * 5;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("empty"))
        {
            Destroy(gameObject);

            if (gameObject.CompareTag("left"))
            {
                GameManager.NeedChangeL = "reverse";
            }
            else if (gameObject.CompareTag("right"))
            {
                GameManager.NeedChangeR = "reverse";
            }
            else if (gameObject.CompareTag("up"))
            {
                GameManager.NeedChangeU = "reverse";
            }
            else if (gameObject.CompareTag("down"))
            {
                GameManager.NeedChangeD = "reverse";
            }
            else if (gameObject.CompareTag("ur"))
            {
                GameManager.NeedChangeUR = "reverse";
            }
            else if (gameObject.CompareTag("ul"))
            {
                GameManager.NeedChangeUL = "reverse";
            }
            else if (gameObject.CompareTag("dr"))
            {
                GameManager.NeedChangeDR = "reverse";
            }
            else if (gameObject.CompareTag("dl"))
            {
                GameManager.NeedChangeDL = "reverse";
            }

        }
        else if (other.CompareTag(GameManager.CurrentTurn))
        {
            if (gameObject.CompareTag("left"))
            {
                GameManager.NeedChangeL = "yes";
            }
            else if (gameObject.CompareTag("right"))
            {
                GameManager.NeedChangeR = "yes";
            }
            else if (gameObject.CompareTag("up"))
            {
                GameManager.NeedChangeU = "yes";
            }
            else if (gameObject.CompareTag("down"))
            {
                GameManager.NeedChangeD = "yes";
            }
            else if (gameObject.CompareTag("ur"))
            {
                GameManager.NeedChangeUR = "yes";
            }
            else if (gameObject.CompareTag("ul"))
            {
                GameManager.NeedChangeUL = "yes";
            }
            else if (gameObject.CompareTag("dr"))
            {
                GameManager.NeedChangeDR = "yes";
            }
            else if (gameObject.CompareTag("dl"))
            {
                GameManager.NeedChangeDL = "yes";
            }

            Destroy(gameObject);
        }
        else if (!other.CompareTag(GameManager.CurrentTurn) && !other.CompareTag("empty") && other.gameObject.layer != LayerMask.NameToLayer("Probe"))
        {
            other.tag = gameObject.tag;
        }
    }
}
