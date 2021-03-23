using NUnit.Framework;

namespace ConsoleAppPlayers
{
    [TestFixture]
        public class PlayerHandling
        {
            [Test]
            public void TestOne()
            {
                foreach (var P in Program.Plist())
                {
                    Assert.IsNotNull(P.PId);
                    Assert.IsNotEmpty(P.PName);
                    Assert.IsNotEmpty(P.PTeam);
                }
            }
        }
    }
