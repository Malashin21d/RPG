using RpgLogicProject;


Console.WriteLine("Начало симуляции битвы");
Console.WriteLine("Вы находитесь в темной пещере и видите гоблина рядом с факелом");
var Hero = new Hero("Герой", 1, 110);
var Enemy = new Enemy("Гоблин", 1, 70, 5);
var BackPack = new BackPack(10);
var BattleArena = new BattleArena(Enemy,Hero);
BattleArena.Battle();
Console.WriteLine("Конец симуляции битвы");



///////////////////////////////////////////////////////////////////
// Дополнительное задание на 5.
// Реализовать механизм лута предметов с противника в случае победы
// Отсутствует 
///////////////////////////////////////////////////////////////////