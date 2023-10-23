using System;
namespace RobotVSMonster
{
	public class Battlefield
	{
        public Robot Tron;
        public Dinosaur TFlex;

        public Battlefield()
		{
            Weapon Swordof1000truths = new Weapon("sword", 25);
            

            this.Tron = new Robot("Tron", 250, Swordof1000truths);
            TFlex = new Dinosaur("TFlex", 250, 20);


        }
        public void RunGame()

        {
            Console.WriteLine("Welcome to Robot vs Dinosaur!");

            bool isRobotattacker = true;
            while (this.Tron.Health > 0 && this.TFlex.Health > 0)
            {

                if (isRobotattacker)
                { this.TFlex.RecieveDamage(this.Tron.ActiveWeapon.AttackPower); }
                else
                {
                    this.Tron.ReceiveDamage(this.TFlex.AttackPower);
                }
                    isRobotattacker = !isRobotattacker;
            }
            if (this.Tron.Health > 0)
            {
                Console.WriteLine(" Tron wins!");
            }
            else
            { Console.WriteLine("TFlex wins!"); }

                

                    
        }

        


	}


    
}

