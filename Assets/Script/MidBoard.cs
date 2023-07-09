using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidBoard : MonoBehaviour
{
    [SerializeField] private Transform whiteChip;
    [SerializeField] private Transform blackChip;
    [SerializeField] private string chipColor;

    private void Start()
    {
        if(chipColor == "black")
        {
            Instantiate(blackChip, this.transform);
            GameManager.blackScore += 1;
        }
        else if(chipColor == "white")
        {
            Instantiate(whiteChip, this.transform);
            GameManager.whiteScore += 1;
        }
    }
}
