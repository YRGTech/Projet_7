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
    }
}