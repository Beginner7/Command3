using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bitboard = System.UInt64;

namespace ChessEngine
{
    public class Board
    {
        private Bitboard WhiteKing;
        private Bitboard WhiteQueens;
        private Bitboard WhiteRooks; 
        private Bitboard WhiteBishops; 
        private Bitboard WhiteKnights;
        private Bitboard WhitePawns;

        private Bitboard BlackKing;
        private Bitboard BlackQueens;
        private Bitboard BlackRooks; 
        private Bitboard BlackBishops; 
        private Bitboard BlackKnights;
        private Bitboard BlackPawns;

        private Bitboard AllWhitePieces;
        private Bitboard AllBlackPieces;
        private Bitboard AllPieces;
      
        //Lookup tables
        private Bitboard[] clearRank = new Bitboard[8];
        private Bitboard[] maskRank = new Bitboard[8];
        private Bitboard[] clearFile = new Bitboard[8];
        private Bitboard[] maskFile = new Bitboard[8];

        private void InitMaskRank()
        {
            maskRank[0] = 0x00000000000000ff;
            for(int i=0;i<7;i++){
                maskRank[i+1] = maskRank[i] << 8;
            }
        }
        private void InitMaskFile()
        {
            maskFile[0] = 0x0101010101010101;
            for(int i=0;i<7;i++){
                maskFile[i+1] = maskFile[i] << 1;
            }
        }


    }
}
