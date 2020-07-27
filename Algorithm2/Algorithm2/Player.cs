using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm2
{
    class Player
    {
        public int PosY { get; private set; }
        public int PosX { get; private set; }
        Random _ramdon = new Random();

        Board _board;

        public void Initialize(int posY, int posX, int desY, int desX,Board board)
        {
            PosX = posX;
            PosY = posY;

            _board = board;
        }

        const int MOVE_TICK = 100;
        int _sumTick = 0;
        public void Update(int deltaTick)
        {
            _sumTick += deltaTick;
            if(_sumTick>=MOVE_TICK)
            {
                _sumTick = 0;

                // 0.1초마다 실행될 로직을 넣어준다.
                int randValue=_ramdon.Next(0, 5);
                switch(randValue)
                {
                    case 0: //상
                        if (_board.Tile[PosY - 1, PosX] == Board.TileType.Empty)
                            PosY = PosY - 1;
                        break;
                    case 1: //하
                        if (_board.Tile[PosY + 1, PosX] == Board.TileType.Empty)
                            PosY = PosY + 1;
                        break;
                    case 2:
                        if (_board.Tile[PosY, PosX - 1] == Board.TileType.Empty)
                            PosX = PosX - 1;
                        break;
                    case 3:
                        if (_board.Tile[PosY, PosX + 1] == Board.TileType.Empty)
                            PosX = PosX + 1;
                        break;
                }
            }
        }
    }
}
