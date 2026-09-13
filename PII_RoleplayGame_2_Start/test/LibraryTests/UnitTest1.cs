using NUnit.Framework;

namespace TestLibrary;

public class CharactersTests
{
    private static Knight CrearKnight()
    {
        return new Knight("Arthur")
        {
            Sword = new Sword(),
            Shield = new Shield(), 
            Armor = new Armor(),
        };
    } 
    [Test]
    public void Knight_AttackValue_EsElDeLaEspada()
    {

        Knight knight = CrearKnight();

        Assert.That(knight.AttackValue, Is.EqualTo(20));
    }
    [Test]
    public void Knight_DefenseValue_EsArmaduraMasEscudo()
    {
        Knight knight = CrearKnight();

        Assert.That(knight.DefenseValue, Is.EqualTo(25 + 14)); 
    }  
    [Test]
    public void Knight_DefenseValue_EsArmaduraMasEscudo()
    {
        Knight knight = CrearKnight();

        Assert.That(knight.DefenseValue, Is.EqualTo(25 + 14)); 
    }  
    [Test]
    public void ReceiveAttack_SiElPoderNoSuperaLaDefensa_NoPierdeVida()
    {
        Knight knight = CrearKnight();

        knight.ReceiveAttack(30);

        Assert.That(knight.Health, Is.EqualTo(100));
    } 
    [Test]
    public void ReceiveAttack_LaVidaNuncaBajaDeCero()
    {

        Knight knight = CrearKnight();

        knight.ReceiveAttack(1000);

        Assert.That(knight.Health, Is.EqualTo(0));
    } 
    [Test]
    public void Cure_DevuelveLaVidaA100()
    {
        Knight knight = CrearKnight();

        knight.ReceiveAttack(1000); 

        knight.Cure();

        Assert.That(knight.Health, Is.EqualTo(100));
    } 
}

public class ItemsTests
{
    [Test]
    public void Axe_AttackValue_Es25()
    {
        var axe = new Axe();

        int attack = axe.AttackValue;

        Assert.That(attack, Is.EqualTo(25));
    }

    [Test]
    public void Bow_AttackValue_Es15()
    {
        var bow = new Bow();
        Assert.That(bow.AttackValue, Is.EqualTo(15));
    }

    [Test]
    public void Sword_AttackValue_Es20()
    {
        var sword = new Sword();
        Assert.That(sword.AttackValue, Is.EqualTo(20));
    }

    [Test]
    public void Armor_DefenseValue_Es25()
    {
        var armor = new Armor();
        Assert.That(armor.DefenseValue, Is.EqualTo(25));
    }

    [Test]
    public void Helmet_DefenseValue_Es18()
    {
        var helmet = new Helmet();
        Assert.That(helmet.DefenseValue, Is.EqualTo(18));
    }

    [Test]
    public void Shield_DefenseValue_Es14()
    {
        var shield = new Shield();
        Assert.That(shield.DefenseValue, Is.EqualTo(14));
    }
    [Test]
    public void Staff_TieneAtaqueYDefensa_Es100Y100()
    {
        var staff = new Staff();

        Assert.Multiple(() =>
        {
            Assert.That(staff.AttackValue, Is.EqualTo(100));
            Assert.That(staff.DefenseValue, Is.EqualTo(100));
        });
    }
    [Test]
    public void Spell_TieneAtaqueYDefensa_Es70Y70()
    {
        var spell = new Spell();

        Assert.Multiple(() =>
        {
            Assert.That(spell.AttackValue, Is.EqualTo(70));
            Assert.That(spell.DefenseValue, Is.EqualTo(70));
        });
    }
 }

