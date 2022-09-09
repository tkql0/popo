using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSet : MonoBehaviour
{
    public int x = 0;
    public int z = 0;

    public GameObject Rook;
    public GameObject Knight;
    public GameObject Bishop;
    public GameObject King;
    public GameObject Queen;
    public GameObject Pawn;

    public GameObject Pick;
    public GameObject Range;
    public GameObject Target;

    private void Start()
    {
        ChessSet();
    }

    private void Update()
    {
    }

    private void OnMouseEnter()
    {
        Pick.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        Pick.gameObject.SetActive(false);
    }

    public void ChessSet()
    {
        switch (z)
        {
            case 1:
                switch (x)
                {
                    case 1:
                        GameObject BRook1 = Rook;
                        BRook1.gameObject.SetActive(true);
                        BRook1.GetComponent<MeshRenderer>().material.color = Color.black;
                        BRook1.layer = 7;
                        BRook1.tag = "Rook";
                        Target = BRook1;
                        break;
                    case 2:
                        GameObject BKnight1 = Knight;
                        BKnight1.gameObject.SetActive(true);
                        BKnight1.GetComponent<MeshRenderer>().material.color = Color.black;
                        BKnight1.layer = 7;
                        BKnight1.tag = "Knight";
                        Target = Knight;
                        break;
                    case 3:
                        GameObject BBishop1 = Bishop;
                        BBishop1.gameObject.SetActive(true);
                        BBishop1.GetComponent<MeshRenderer>().material.color = Color.black;
                        BBishop1.layer = 7;
                        BBishop1.tag = "Bishop";
                        Target = Bishop;
                        break;
                    case 4:
                        GameObject BKing1 = King;
                        BKing1.gameObject.SetActive(true);
                        BKing1.GetComponent<MeshRenderer>().material.color = Color.black;
                        BKing1.layer = 7;
                        BKing1.tag = "King";
                        Target = King;
                        break;
                    case 5:
                        GameObject BQueen1 = Queen;
                        BQueen1.gameObject.SetActive(true);
                        BQueen1.GetComponent<MeshRenderer>().material.color = Color.black;
                        BQueen1.layer = 7;
                        BQueen1.tag = "Queen";
                        Target = Queen;
                        break;
                    case 6:
                        GameObject BBishop2 = Bishop;
                        BBishop2.gameObject.SetActive(true);
                        BBishop2.GetComponent<MeshRenderer>().material.color = Color.black;
                        BBishop2.layer = 7;
                        BBishop2.tag = "Bishop";
                        Target = Bishop;
                        break;
                    case 7:
                        GameObject BKnight2 = Knight;
                        BKnight2.gameObject.SetActive(true);
                        BKnight2.GetComponent<MeshRenderer>().material.color = Color.black;
                        BKnight2.layer = 7;
                        BKnight2.tag = "Knight";
                        Target = Knight;
                        break;
                    case 8:
                        GameObject BRook2 = Rook;
                        BRook2.gameObject.SetActive(true);
                        BRook2.GetComponent<MeshRenderer>().material.color = Color.black;
                        BRook2.layer = 7;
                        BRook2.tag = "Rook";
                        Target = Rook;
                        break;
                }
                break;
            case 2:
                switch (x)
                {
                    case 1:
                        GameObject BPawn0 = Pawn;
                        BPawn0.gameObject.SetActive(true);
                        BPawn0.GetComponent<MeshRenderer>().material.color = Color.black;
                        BPawn0.layer = 7;
                        BPawn0.tag = "Pawn";
                        Target = Pawn;
                        break;
                    case 2:
                        GameObject BPawn1 = Pawn;
                        BPawn1.gameObject.SetActive(true);
                        BPawn1.GetComponent<MeshRenderer>().material.color = Color.black;
                        BPawn1.layer = 7;
                        BPawn1.tag = "Pawn";
                        Target = Pawn;
                        break;
                    case 3:
                        GameObject BPawn2 = Pawn;
                        BPawn2.gameObject.SetActive(true);
                        BPawn2.GetComponent<MeshRenderer>().material.color = Color.black;
                        BPawn2.layer = 7;
                        BPawn2.tag = "Pawn";
                        Target = Pawn;
                        break;
                    case 4:
                        GameObject BPawn3 = Pawn;
                        BPawn3.gameObject.SetActive(true);
                        BPawn3.GetComponent<MeshRenderer>().material.color = Color.black;
                        BPawn3.layer = 7;
                        BPawn3.tag = "Pawn";
                        Target = Pawn;
                        break;
                    case 5:
                        GameObject BPawn4 = Pawn;
                        BPawn4.gameObject.SetActive(true);
                        BPawn4.GetComponent<MeshRenderer>().material.color = Color.black;
                        BPawn4.layer = 7;
                        BPawn4.tag = "Pawn";
                        Target = Pawn;
                        break;
                    case 6:
                        GameObject BPawn5 = Pawn;
                        BPawn5.gameObject.SetActive(true);
                        BPawn5.GetComponent<MeshRenderer>().material.color = Color.black;
                        BPawn5.layer = 7;
                        BPawn5.tag = "Pawn";
                        Target = Pawn;
                        break;
                    case 7:
                        GameObject BPawn6 = Pawn;
                        BPawn6.gameObject.SetActive(true);
                        BPawn6.GetComponent<MeshRenderer>().material.color = Color.black;
                        BPawn6.layer = 7;
                        BPawn6.tag = "Pawn";
                        Target = Pawn;
                        break;
                    case 8:
                        GameObject BPawn7 = Pawn;
                        BPawn7.gameObject.SetActive(true);
                        BPawn7.GetComponent<MeshRenderer>().material.color = Color.black;
                        BPawn7.layer = 7;
                        BPawn7.tag = "Pawn";
                        Target = Pawn;
                        break;
                }
                break;
            case 7:
                switch (x)
                {
                    case 1:
                        GameObject WPawn0 = Pawn;
                        WPawn0.gameObject.SetActive(true);
                        WPawn0.GetComponent<MeshRenderer>().material.color = Color.white;
                        WPawn0.layer = 6;
                        WPawn0.tag = "Pawn";
                        Target = Pawn;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 2:
                        GameObject WPawn1 = Pawn;
                        WPawn1.gameObject.SetActive(true);
                        WPawn1.GetComponent<MeshRenderer>().material.color = Color.white;
                        WPawn1.layer = 6;
                        WPawn1.tag = "Pawn";
                        Target = Pawn;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 3:
                        GameObject WPawn2 = Pawn;
                        WPawn2.gameObject.SetActive(true);
                        WPawn2.GetComponent<MeshRenderer>().material.color = Color.white;
                        WPawn2.layer = 6;
                        WPawn2.tag = "Pawn";
                        Target = Pawn;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 4:
                        GameObject WPawn3 = Pawn;
                        WPawn3.gameObject.SetActive(true);
                        WPawn3.GetComponent<MeshRenderer>().material.color = Color.white;
                        WPawn3.layer = 6;
                        WPawn3.tag = "Pawn";
                        Target = Pawn;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 5:
                        GameObject WPawn4 = Pawn;
                        WPawn4.gameObject.SetActive(true);
                        WPawn4.GetComponent<MeshRenderer>().material.color = Color.white;
                        WPawn4.layer = 6;
                        WPawn4.tag = "Pawn";
                        Target = Pawn;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 6:
                        GameObject WPawn5 = Pawn;
                        WPawn5.gameObject.SetActive(true);
                        WPawn5.GetComponent<MeshRenderer>().material.color = Color.white;
                        WPawn5.layer = 6;
                        WPawn5.tag = "Pawn";
                        Target = Pawn;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 7:
                        GameObject WPawn6 = Pawn;
                        WPawn6.gameObject.SetActive(true);
                        WPawn6.GetComponent<MeshRenderer>().material.color = Color.white;
                        WPawn6.layer = 6;
                        WPawn6.tag = "Pawn";
                        Target = Pawn;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 8:
                        GameObject WPawn7 = Pawn;
                        WPawn7.gameObject.SetActive(true);
                        WPawn7.GetComponent<MeshRenderer>().material.color = Color.white;
                        WPawn7.layer = 6;
                        WPawn7.tag = "Pawn";
                        Target = Pawn;
                        transform.Rotate(0, 180, 0);
                        break;
                }
                break;
            case 8:
                switch (x)
                {
                    case 1:
                        GameObject WRook1 = Rook;
                        WRook1.gameObject.SetActive(true);
                        WRook1.GetComponent<MeshRenderer>().material.color = Color.white;
                        WRook1.layer = 6;
                        WRook1.tag = "Rook";
                        Target = Rook;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 2:
                        GameObject WKnight1 = Knight;
                        WKnight1.gameObject.SetActive(true);
                        WKnight1.GetComponent<MeshRenderer>().material.color = Color.white;
                        WKnight1.layer = 6;
                        WKnight1.tag = "Knight";
                        Target = Knight;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 3:
                        GameObject WBishop1 = Bishop;
                        WBishop1.gameObject.SetActive(true);
                        WBishop1.GetComponent<MeshRenderer>().material.color = Color.white;
                        WBishop1.layer = 6;
                        WBishop1.tag = "Bishop";
                        Target = Bishop;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 4:
                        GameObject WKing1 = King;
                        WKing1.gameObject.SetActive(true);
                        WKing1.GetComponent<MeshRenderer>().material.color = Color.white;
                        WKing1.layer = 6;
                        WKing1.tag = "King";
                        Target = King;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 5:
                        GameObject WQueen1 = Queen;
                        WQueen1.gameObject.SetActive(true);
                        WQueen1.GetComponent<MeshRenderer>().material.color = Color.white;
                        WQueen1.layer = 6;
                        WQueen1.tag = "Queen";
                        Target = Queen;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 6:
                        GameObject WBishop2 = Bishop;
                        WBishop2.gameObject.SetActive(true);
                        WBishop2.GetComponent<MeshRenderer>().material.color = Color.white;
                        WBishop2.layer = 6;
                        WBishop2.tag = "Bishop";
                        Target = Bishop;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 7:
                        GameObject WKnight2 = Knight;
                        WKnight2.gameObject.SetActive(true);
                        WKnight2.GetComponent<MeshRenderer>().material.color = Color.white;
                        WKnight2.layer = 6;
                        WKnight2.tag = "Knight";
                        Target = Knight;
                        transform.Rotate(0, 180, 0);
                        break;
                    case 8:
                        GameObject WRook2 = Rook;
                        WRook2.gameObject.SetActive(true);
                        WRook2.GetComponent<MeshRenderer>().material.color = Color.white;
                        WRook2.layer = 6;
                        WRook2.tag = "Rook";
                        Target = Rook;
                        transform.Rotate(0, 180, 0);
                        break;
                }
                break;
        }
    }
}
