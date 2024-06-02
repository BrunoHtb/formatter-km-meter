namespace KmMeterFormatter.Tests
{
    [TestClass]
    public class KmMeterFormatterTests
    {
        [TestMethod]
        public void ShouldFormatterKmMeter()
        {
            string km = "23";
            string meter = "601";
            string separation = "+";
            string expected = "023+601";

            string formattedString = KmMeterFormatter.ConcatKmMeter(km, meter, separation);

            Assert.AreEqual(expected, formattedString);
        }
    }
}