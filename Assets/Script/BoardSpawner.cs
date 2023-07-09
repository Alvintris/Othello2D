using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSpawner : MonoBehaviour
{
    [SerializeField] private Board _boardPrefab;
    [SerializeField] private MidBoard _midBlackPrefab;
    [SerializeField] private MidBoard _midWhitePrefab;

    public void SpawnBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            float width = (8 - 1);
            float height = (8 - 1);
            Vector3 centering = new Vector3(-width * 0.5f, -height * 0.5f, 0);
            Vector3 rowPosition = new Vector3(centering.x, centering.y + i, 0);

            for (int j = 0; j < 8; j++)
            {
                if(i == 3 && j == 3 || i == 4 && j == 4)
                {
                    MidBoard board = Instantiate(_midBlackPrefab, this.transform);
                    Vector3 position = rowPosition;
                    position.x += j;
                    board.transform.localPosition = position;
                }
                else if (i == 3 && j == 4 || i == 4 && j == 3)
                {
                    MidBoard board = Instantiate(_midWhitePrefab, this.transform);
                    Vector3 position = rowPosition;
                    position.x += j;
                    board.transform.localPosition = position;
                }
                else
                {
                    Board board = Instantiate(_boardPrefab, this.transform);
                    Vector3 position = rowPosition;
                    position.x += j;
                    board.transform.localPosition = position;
                }
            }
        }
    }
}
