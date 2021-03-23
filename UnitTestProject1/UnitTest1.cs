using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CardDeckInitializeShouldPopulateDeck()
        {
            var deck = new CardDeck();
           

            Assert.AreEqual(deck.Count, 52);
            Assert.AreEqual(deck.Draw().Suit, CardSuit.Spades);
        }
    }
}
