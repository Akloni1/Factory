
using AbstractFactory.Factory;
using AbstractFactory.FlyingMagician;
using AbstractFactory.Magician;

IFlyingMagician flyingMagician = FactoryFlyingMagician.CreateMagician("Белый маг");
IMagician magician = FactoryMagician.CreateMagician("Черный маг");
magician.Confirmation();
flyingMagician.Confirmation();