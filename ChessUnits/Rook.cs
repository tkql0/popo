using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : MonoBehaviour
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
    }
}
