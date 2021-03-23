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
                    Assert.IsNotNull(P.PName);
                    Assert.IsNotNull(P.PTeam);
                }
            }
        }
    }
