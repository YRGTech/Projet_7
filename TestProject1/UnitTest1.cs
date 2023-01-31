namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void TestHeal()
        {
            Pikachu pikachu = new Pikachu();
            pikachu.Hurt(50, Projet_7.Type.Giselle);
            pikachu.Heal(pikachu.PVMax);
            Assert.IsTrue(pikachu.PV > pikachu.PVMax - 50 && pikachu.PV <= pikachu.PVMax);
        }

        [Test]
        public void TestEnnemyTurn()
        {
            Pikachu pikachu = new Pikachu();
            Combat c = new Combat(pikachu);
            c.EnemyTurn();
            Assert.IsTrue(pikachu.PV < pikachu.PVMax);
        }

        [Test]
        public void TestIsPlayerOnGrass()
        {
            Map m = new Map();
            m.playerX = 32;
            m.playerY = 5;
            Pikachu pikachu = new Pikachu();
            Assert.IsTrue(m.IsPlayerOnGrass());
        }
        [Test]
        public void Testcreationpikaenemy()
        {
            Pikachu pikachu = new Pikachu(2);
            Console.Write(pikachu.DEF);
        }
    }
}