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

    public void OnMouseDown() //해당 오브젝트를 누르면
    {
        BoardManager.Instance.board.SetXZ(x, z); //클릭한 값 보내기
        BoardManager.Instance.target = Target; //클릭한 오브젝트 보내기
        Tile_Instantiate();
    }

    public void Tile_Instantiate()
    {
        if (Target.layer == 6) //만약 레이어타입이 화이트라면
        {
            int _x = x;
            int _z = z;
        }
        if (Target.layer == 7) //만약 레이어타입이 블랙이라면
        {
            int _x = x;
            int _z = z;
        }
    }
}
