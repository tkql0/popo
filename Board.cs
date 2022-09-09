using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{




    public int[,] Chess;
    int WidthX = 8; //���� �ִ� ����
    int WidthZ = 8; //���� �ִ� ����
    public int x;
    public int z;
    public GameObject Board_U; //������ ��������
    public Transform ChessBoard; //������ ������

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
                if ((i + j) % 2 == 0) //�������� 0�̸� ������
                {
                    location.GetComponent<MeshRenderer>().material.color = Color.black;
                }
                else //0�� �ƴϸ� �Ͼ��
                {
                    location.GetComponent<MeshRenderer>().material.color = Color.white;
                }

                UnitSet unitSet = location.GetComponent<UnitSet>();
                unitSet.x = i;
                unitSet.z = j;
            }
        }
    }

    public void SetXZ(int x, int z) //Ŭ���� ���� ��������
    {
        this.x = x; //Ŭ���� x�� 
        this.z = z; //Ŭ���� z�� 
    }
}
