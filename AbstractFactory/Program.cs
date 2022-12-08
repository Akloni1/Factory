
using AbstractFactory.Factory;
using AbstractFactory.FlyingMagician;
using AbstractFactory.Magician;

IFlyingMagician flyingMagician = FactoryFlyingMagician.CreateMagician("Белый маг");
IMagician magician = FactoryMagician.CreateMagician("Черный маг");
magician.Confirmation();
flyingMagician.Confirmation();

Console.WriteLine($"Здоровье летающего белого мага до боя: {flyingMagician.Health}");
Console.WriteLine($"Здоровье черного мага до боя: {magician.Health}");

magician.Battle(flyingMagician);
flyingMagician.Battle(magician);
Console.WriteLine($"Здоровье летающего белого мага после боя: {flyingMagician.Health}");
Console.WriteLine($"Здоровье черного мага после боя: {magician.Health}");