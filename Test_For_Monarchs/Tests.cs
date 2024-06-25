using MonarchsChallenge;
using NUnit.Framework;

namespace Test_For_Monarchs;


//Check if list of Monarchs isn't empty 
[TestFixture]
public class CountMonarchsTest
{

    private Monarch _monarch;
    

    [SetUp]
    public void SetUp()
    {
        _monarch = new Monarch();
    }
    
    [Test]
    //Monarchs count test-shouldn't be zero 
    public async Task CountMonarchs_shouldNotBeZero()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        int monarchsCount = monarchs.CountMonarchs();

        Assert.That(monarchsCount, Is.Not.EqualTo(0), "Monarchs count can't be zero" );
        
    }
    
    [Test]
    //Monarchs count test-shouldn't be negative value 
    public async Task CountMonarchs_shouldNotBeNegativeValue()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        int monarchsCount = monarchs.CountMonarchs();

        Assert.That(monarchsCount, Is.Not.Negative, "Monarchs count can't be negative value");
        
    }

    [Test]
    // Check longest ruling monarch shouldn't be zero 
    public async Task LongestRulingMonarch_shouldNotBeZero()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        var rulingMonarch = monarchs.LongestRulingMonarch();

        Assert.That(rulingMonarch, Is.Not.EqualTo(0), "Monarchs longest ruling value can't be zero");
    }

    [Test]
    // Check longest ruling monarch shouldn't be negative value 
    public async Task LongestRulingMonarch_shouldNotBeNegativeValue()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        var rulingMonarch = monarchs.LongestRulingMonarch();

        Assert.That(rulingMonarch.RulingLength, Is.Not.Negative, "Monarchs longest ruling value can't be negative value");
    }
    
    [Test]
    // Check longest ruling house shouldn't be zero 
    public async Task LongestRulingHouse_shouldNotBeZero()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        var rulingHouse = monarchs.LongestRulingHouse();

        Assert.That(rulingHouse, Is.Not.EqualTo(0), "Longest ruling house value can't be zero");
    }
    
    [Test]
    // Check longest ruling house shouldn't be negative value 
    public async Task LongestRulingHouse_shouldNotBeNegativeValue()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        var rulingHouse = monarchs.LongestRulingHouse();

        Assert.That(rulingHouse.RulingTime, Is.Not.Negative, "Longest ruling house value can't be negative value");
    }
    
    [Test]
    // Check most monarch common name 
    public async Task CheckMostCommonName_shouldNotBeEmpty()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        var mostCommon = monarchs.MostCommonMonarchName();

        Assert.That(mostCommon, Is.Not.Empty, "Most common name can't be empty");
    }
    
    [Test]
    //Monarchs count test-correct value 
    public async Task CountMonarchs_correctValue()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        int monarchsCount = monarchs.CountMonarchs();

        Assert.That(monarchsCount, Is.EqualTo(57), "Monarchs count is incorrect" );
        
    }
    
    [Test]
    // Check longest ruling monarch-correct value
    public async Task LongestRulingMonarch_correctValue()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();
        
        var rulingMonarch = monarchs.LongestRulingMonarch();
        
        Assert.Multiple(() =>
        {
            Assert.That(rulingMonarch.RulingLength, Is.EqualTo(72), "Monarchs longest ruling value is incorrect");
            Assert.That(rulingMonarch.Name, Is.EqualTo("Elizabeth II"), "Monarchs longest ruling value is incorrect");
            Assert.That(rulingMonarch.House, Is.EqualTo("House of Windsor"),
                "Monarchs longest ruling value is incorrect");
        });
    }
    
    [Test]
    // Check longest ruling house correct value 
    public async Task LongestRulingHouse_correctValue()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        var rulingHouse = monarchs.LongestRulingHouse();
        
        Assert.Multiple(() =>
        {
            Assert.That(rulingHouse.RulingTime, Is.EqualTo(187), "Monarchs longest ruling value is incorrect");
            Assert.That(rulingHouse.HouseName, Is.EqualTo("House of Hanover"),
                "Monarchs longest ruling value is incorrect");
        });
    }
    
    [Test]
    // Check most monarch common name-correct value 
    public async Task CheckMostCommonName_CorrectValue()
    {
        var customHttpClient = new CustomClient();

        var collector = new MonarchsCollector(customHttpClient);
        var monarchs = await collector.GetMonarchs();

        var mostCommon = monarchs.MostCommonMonarchName();

        Assert.That(mostCommon, Is.EqualTo("Edward"), "Most common name is incorrect");
    }
    
}

