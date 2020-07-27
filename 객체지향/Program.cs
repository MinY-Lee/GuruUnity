using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 객체지향
{
    // 객체(OOP Object Oriented Programming)
    // 은닉성/상속성/다형성(poly morphism)
    
    class Player
    {
        protected int hp;
        protected int attack;

        public virtual void Move()
        {
            Console.WriteLine("Player 이동");
        }
    }

    class Knight : Player
    {
        public override void Move()
        {
            base.Move();

            Console.WriteLine("Knight 이동");
        }
    }

    class Mage : Player
    {
        public int mp;

        public override void Move()
        {
            Console.WriteLine("Mage 이동");
        }
    }
    
    class Program
    {
        static void EnterGame(Player player)
        {
            player.Move();

            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
                mage.Move();
            }
        }

        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            knight.Move();
            mage.Move();

            EnterGame(knight);
        }
    }
}
