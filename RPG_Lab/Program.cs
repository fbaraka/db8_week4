// pair programming done with Feras Baraka and AJ Wilsea

List<GameCharacter> gameCharacters = new List<GameCharacter>();

GameCharacter warrior1 = new WarriorCharacter("Broad Sword","Feras", 25, 2, 100);

gameCharacters.Add(warrior1);

gameCharacters.Add(new WarriorCharacter("Wet Noodle", "AJ", 100, 0, 200));
gameCharacters.Add(new WarriorCharacter("Battle Axe", "Jeff", 10, 4, 100));
gameCharacters.Add(new WarriorCharacter("Wet Noodle", "Riley", 15, 1, 100));
gameCharacters.Add(new WizardCharacter(4, 20, "Chris", 4, 75, 100));
gameCharacters.Add(new WizardCharacter(12, 1000, "Sara", 20, 150, 200));
gameCharacters.Add(new WizardCharacter(12, 500, "Fidan", 20, 100, 100));


foreach (GameCharacter character in gameCharacters)
{
    character.Play();
}

Console.WriteLine();
Console.WriteLine("=====================================");
Console.WriteLine("         INVADING TEAM               ");
Console.WriteLine("=====================================");
Console.WriteLine();

List<GameCharacter> invadingGameCharacters = new List<GameCharacter>();

invadingGameCharacters.Add(new WarriorCharacter("Broad Sword", "Ali", 25, 2, 100));
invadingGameCharacters.Add(new WarriorCharacter("Kayak Paddle", "Eddie", 100, 0, 150));
invadingGameCharacters.Add(new WarriorCharacter("Spear", "Brynn", 10, 4, 100));
invadingGameCharacters.Add(new WarriorCharacter("Cane", "Lonnie", 15, 1, 100));
invadingGameCharacters.Add(new WizardCharacter(4, 20, "Jacob", 4, 75, 100));
invadingGameCharacters.Add(new WizardCharacter(12, 1000, "Al", 20, 150, 200));
invadingGameCharacters.Add(new WizardCharacter(12, 600, "Lindsey", 20, 90, 100));

foreach (GameCharacter character in invadingGameCharacters)
{
    character.Play();
}


/* 

sooooo we go through a foreach for gameCharachters 
-for each charachter they can attack() 
    - they will get a random num generated from 2-12
    - need to use that number to subtract from a random character in invadingGameCharacters 
    - can use the Random function to get an int between 0 and invadingGameCharacters.Count
            -- So that character will then attack()
            -- and get a random num between 2-12
            -- have to build a method that takes the two attack numbers and determines which int is larger 
                    -- then take that int and subtact it from the loser's hp 

===================================================
Does the console print the characters name for who is up and who they are attacking? 
        -- we can say how they are attacking 
        -- weapon, or magic etc. 
Afterwards, show the result of who won
and the updated HP 

then show list of team and just HP. 






*/





class GameCharacter
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int HP;

    public GameCharacter(string _Name, int _Strength, int _Intelligence, int _HP )
    {

        Name = _Name;
        Strength = _Strength;
        Intelligence = _Intelligence;
        HP = _HP;


    }



    public virtual void Play()
    {
        Console.WriteLine($"\nName: {Name}\t HP: {HP}\n\n\tStrength: {Strength}\n\tIntelligence: {Intelligence}");
    }

    public virtual int RollDice()
    { 
    
        Random dice = new Random();
        int attackNum1 = dice.Next(1, 6);
        int attackNum2 = dice.Next(1, 6);

        return attackNum1 + attackNum2;
    }

}


class MagicUsingCharacter : GameCharacter
{
    public int MagicalEnergy;

    public MagicUsingCharacter(int _MagicalEnergy, string _Name,  int _Strength, int _Intelligence, int _HP) 
        : base(_Name, _Strength, _Intelligence, _HP)
    {
        MagicalEnergy = _MagicalEnergy;
    }

    public override void Play()
    {
        Console.WriteLine($"\nName: {Name}\t HP: {HP}\n\n\tStrength: {Strength}\n\tIntelligence: {Intelligence}\n\tMagical Energy: {MagicalEnergy}");

    }
}

class WizardCharacter : MagicUsingCharacter
{
    public int SpellCount; 

    public WizardCharacter(int _Spellcount, int _MagicalEnergy, string _Name, int _Strength, int _Intelligence, int _HP) 
        : base(_MagicalEnergy, _Name, _Strength, _Intelligence, _HP)
    {
        SpellCount = _Spellcount;
    }

    public override void Play()
    {
        Console.WriteLine($"\nName: {Name}\t HP: {HP}\n\n\tStrength: {Strength}\n\tIntelligence: {Intelligence}\n\tMagical Energy: {MagicalEnergy}\n\tSpell Count: {SpellCount}");

    }
}

class WarriorCharacter : GameCharacter
{
    public string WeaponType;

    public WarriorCharacter(string _WeaponType, string _Name, int _Strength, int _Intelligence, int _HP)
        : base(_Name, _Strength, _Intelligence, _HP)
    {
        WeaponType = _WeaponType;
    }

    public override void Play()
    {
        Console.WriteLine($"\nName: {Name}\t HP: {HP}\n\n\tStrength: {Strength}\n\tIntelligence: {Intelligence}\n\tWeapon Type: {WeaponType}");

    }
}
