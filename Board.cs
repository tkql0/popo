using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{




    public int[,] Chess;
    int WidthX = 8; //가로 최대 길이
    int WidthZ = 8; //세로 최대 길이
    public int x;
    public int z;
    public GameObject Board_U; //생성할 보드유닛
    public Transform ChessBoard; //생성된 보드판

    private void Awake()
    {
        Chess = new int[WidthX, WidthZ];
    }

    public void ChessBoards()
    {
        for (int i = 1; i <= WidthX; i++)
        {
            for (int j = 1; j <= WidthZ; j++)
            {
                GameObject location = Instantiate(Board_U, new Vector3(i, 1f, j), Quaternion.identity, ChessBoard);
                if ((i + j) % 2 == 0) //나머지가 0이면 검은색
                {
                    location.GetComponent<MeshRenderer>().material.color = Color.black;
                }
                else //0이 아니면 하얀색
                {
                    location.GetComponent<MeshRenderer>().material.color = Color.white;
                }

                UnitSet unitSet = location.GetComponent<UnitSet>();
                unitSet.x = i;
                unitSet.z = j;
            }
        }
    }

    public void SetXZ(int x, int z) //클릭한 값을 가져오기
    {
        this.x = x; //클릭한 x값 
        this.z = z; //클릭한 z값 
    }
}
