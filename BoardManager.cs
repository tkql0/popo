using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoSingleTon<BoardManager>
{
    public Board board = new Board();
    public UnitSet unitSet = new UnitSet();

    public Pawn pawn = new Pawn();
    public Rook rook = new Rook();
    public Knight knight = new Knight();
    public Bishop bishop = new Bishop();
    public King king = new King();
    public Queen queen = new Queen();

    public GameObject target;

    private void Awake()
    {
        board.ChessBoards();
        unitSet.ChessSet();
    }
}
