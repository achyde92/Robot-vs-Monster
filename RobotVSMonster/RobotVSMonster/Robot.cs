using System;
namespace RobotVSMonster;

public class Robot 

{
	public string Name;
	public int Health;
	public Weapon ActiveWeapon;

	public Robot(string Name, int Health, Weapon ActiveWeapon)
	{
		this.Name = Name;
		this.ActiveWeapon = new Weapon("sword", 25);
	}
	public int ReceiveDamage (int attackpower)
	{
		this.Health -= attackpower;
		return this.Health;		
	}


	

	
}

