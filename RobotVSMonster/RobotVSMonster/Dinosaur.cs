namespace RobotVSMonster;

public class Dinosaur

{
    public string Name;
    public int Health;
    public int AttackPower;

    public Dinosaur(string Name, int Health, int AttackPower)
    {
        this.Name = Name; 
    }
    public int RecieveDamage(int Damage)
    {
        this.Health -= Damage;
        return this.Health;
    }







}



