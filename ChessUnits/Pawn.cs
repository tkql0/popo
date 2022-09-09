using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public int x = 0;
    public int z = 0;

    public int Move_count = 0;

    public GameObject Target;
    public Transform Target_Tile;

    private void Start()
    {
        Target = this.gameObject;
        Target_Tile = this.transform;
    }

    private void Update()
    {
        x = (int)this.transform.position.x;
        z = (int)this.transform.position.z;
    }

    public void OnMouseDown() //�ش� ������Ʈ�� ������
    {
        BoardManager.Instance.board.SetXZ(x, z); //Ŭ���� �� ������
        BoardManager.Instance.target = Target; //Ŭ���� ������Ʈ ������
        Tile_Instantiate();
    }

    public void Tile_Instantiate()
    {
        if (Target.layer == 6) //���� ���̾�Ÿ���� ȭ��Ʈ���
        {
            int _x = x;
            int _z = z;
        }
        if (Target.layer == 7) //���� ���̾�Ÿ���� ���̶��
        {
            int _x = x;
            int _z = z;
        }
    }
}
