// Here will be the enemy attacking.


public class Enemyattack
{
public static void goblinenemy()
{
    int er2 = Random.Shared.Next(2, 4);
    List<Ability> goblinad = [
        new() {name = "Slash", minDmg = 5*er2, maxDmg = 7*er2},
        new() {name = "Pierce", minDmg = 4*er2, maxDmg = 8*er2},
        new() {name = "Stab", minDmg = 5*er2, maxDmg = 6*er2}
    ];
    
}

public static void bantitenemy()
{
    int er1 = Random.Shared.Next(2, 4);
     List<Ability> banditad = [
        new() {name = "Kick", minDmg = 7*er1, maxDmg = 9*er1},
        new() {name = "Sever", minDmg = 6*er1, maxDmg = 10*er1},
        new() {name = "Punch", minDmg = 7*er1, maxDmg = 8*er1}
    ];           
}

public static void wolfenemy()
{
    int er3 = Random.Shared.Next(2, 4);
     List<Ability> wolfad = [
        new() {name = "Claw attack", minDmg = 5*er3, maxDmg = 7*er3},
        new() {name = "Bite", minDmg = 4*er3, maxDmg = 8*er3},
        new() {name = "Headbutt", minDmg = 5*er3, maxDmg = 7*er3}
        ];

}



}




