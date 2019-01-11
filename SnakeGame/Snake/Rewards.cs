using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    class Rewards
    {
        List<Position> applelist;
        Board mainBoard;
        Bitmap rewardImage = Resource1.appleReward;
        

        public Rewards(int size, Board mainBoard)
        {
            this.mainBoard = mainBoard;
            applelist = new List<Position>();
            for (int i=0;i< size;i++)
            {
                int rowNo, colNo;

                //Generate an apple at random position but not duplicated
                do
                {
                    //Generate a random number between 1 and MaxRowNo
                    rowNo = (new Random()).Next(1, mainBoard.getMaxRowNo()+1);

                    //Generate a random number between 1 and MaxColNo
                    colNo = (new Random()).Next(1, mainBoard.getMaxColNo()+1);

                } while (isDuplicate(rowNo, colNo) == true);

                applelist.Add(new Position(rowNo, colNo));

            }
        }

        private Boolean isDuplicate(int row, int col)
        {
            Boolean result = false;

            for (int i=0;i< applelist.Count;i++)
            {
                if (applelist[i].getRowNo() == row && applelist[i].getColNo() == col)
                    result = true;
            }

            return result;
        }
        
        public void draw()
        {
            for (int i = 0; i < applelist.Count; i++)
            {
                mainBoard.draw(applelist[i], rewardImage);
            }     
        }

        public Boolean checkIFSnakeEatApple(Snake s)
        {
            Boolean result = false;
            Position snakeHeadPos = s.getHeadPosition();

            for (int i = 0; i < applelist.Count; i++)
            {
                if (snakeHeadPos.getRowNo() == applelist[i].getRowNo() && snakeHeadPos.getColNo() == applelist[i].getColNo())
                    result = true;
            }
            return result;
        }

        public int eatAppleAtPostion(Position p)
        {
            Boolean result = false;
            Position snakeHeadPos = p;

            for (int i = 0; i < applelist.Count; i++)
            {
                if (snakeHeadPos.getRowNo() == applelist[i].getRowNo() && snakeHeadPos.getColNo() == applelist[i].getColNo())
                    applelist.RemoveAt(i);
            }
            return 50;  //50 points per apple
        }

        public Boolean noMoreApples()
        {
            if (applelist.Count > 0)
                return false;
            else
                return true;
        }
    }
}
