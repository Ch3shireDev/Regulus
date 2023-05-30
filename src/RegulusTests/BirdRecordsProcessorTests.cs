using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Processors;

namespace RegulusTests;

[TestClass]
public class BirdRecordsProcessorTests
{
    private BirdRecordsProcessor processor;

    [TestInitialize]
    public void TestInitialize()
    {
        processor = new BirdRecordsProcessor();
    }

    [TestMethod]
    public void SingleRecordTest()
    {
        var birdRecord = new BirdRecord
        {
            Id = 1,
            SpeciesCode = "AAA.BBB",
            Sex = "F",
            Wing = 10,
            Tail = 20,
            Weight = 5,
            DateTime = new DateTime(2020, 01, 02)
        };

        var result = processor.Process(new[] { birdRecord }).ToList();

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count);
        Assert.AreEqual(1, result[0].Id);
        Assert.AreEqual("AAA.BBB", result[0].SpeciesCode);
        Assert.AreEqual("F", result[0].Sex);
        Assert.AreEqual(10, result[0].Wing);
        Assert.AreEqual(20, result[0].Tail);
        Assert.AreEqual(5, result[0].Weight);
        Assert.AreEqual(new DateTime(2020, 01, 02), result[0].DateTime);
        Assert.AreEqual(10, result[0].WingPopulationMean);
        Assert.AreEqual(0, result[0].WingPopulationStandardDeviation);
        Assert.AreEqual(20, result[0].TailPopulationMean);
        Assert.AreEqual(0, result[0].TailPopulationStandardDeviation);
        Assert.AreEqual(5, result[0].WeightPopulationMean);
        Assert.AreEqual(0, result[0].WeightPopulationStandardDeviation);
    }

    [TestMethod]
    public void IgnoreZeroValueTest()
    {

        var birdRecord1 = new BirdRecord
        {
            Id = 1,
            SpeciesCode = "AAA.BBB",
            Sex = "F",
            Wing = 10,
            Tail = 20,
            Weight = 5,
            DateTime = new DateTime(2020, 01, 02)
        };

        var birdRecord2 = new BirdRecord
        {
            Id = 2,
            SpeciesCode = "AAA.BBB",
            Sex = "F",
            Wing = 0,
            Tail = 0,
            Weight = 0,
            DateTime = new DateTime(2020, 01, 03)
        };

        var result = processor.Process(new[] { birdRecord1, birdRecord2 }).ToList();

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);

        Assert.AreEqual(1, result[0].Id);
        Assert.AreEqual("AAA.BBB", result[0].SpeciesCode);
        Assert.AreEqual("F", result[0].Sex);
        Assert.AreEqual(10, result[0].Wing);
        Assert.AreEqual(20, result[0].Tail);
        Assert.AreEqual(5, result[0].Weight);
        Assert.AreEqual(new DateTime(2020, 01, 02), result[0].DateTime);
        Assert.AreEqual(10, result[0].WingPopulationMean);
        Assert.AreEqual(0, result[0].WingPopulationStandardDeviation);
        Assert.AreEqual(20, result[0].TailPopulationMean);
        Assert.AreEqual(0, result[0].TailPopulationStandardDeviation);
        Assert.AreEqual(5, result[0].WeightPopulationMean);
        Assert.AreEqual(0, result[0].WeightPopulationStandardDeviation);

        Assert.AreEqual(2, result[1].Id);
        Assert.AreEqual("AAA.BBB", result[1].SpeciesCode);
        Assert.AreEqual("F", result[1].Sex);
        Assert.AreEqual(0, result[1].Wing);
        Assert.AreEqual(0, result[1].Tail);
        Assert.AreEqual(0, result[1].Weight);
        Assert.AreEqual(new DateTime(2020, 01, 03), result[1].DateTime);
        Assert.AreEqual(10, result[1].WingPopulationMean);
        Assert.AreEqual(0, result[1].WingPopulationStandardDeviation);
        Assert.AreEqual(20, result[1].TailPopulationMean);
        Assert.AreEqual(0, result[1].TailPopulationStandardDeviation);
        Assert.AreEqual(5, result[1].WeightPopulationMean);
        Assert.AreEqual(0, result[1].WeightPopulationStandardDeviation);
    }

    [TestMethod]
    public void TwoRecordsTest()
    {

        var birdRecord1 = new BirdRecord
        {
            Id = 1,
            SpeciesCode = "AAA.BBB",
            Sex = "F",
            Wing = 10,
            Tail = 20,
            Weight = 5,
            DateTime = new DateTime(2020, 01, 02)
        };

        var birdRecord2 = new BirdRecord
        {
            Id = 2,
            SpeciesCode = "AAA.BBB",
            Sex = "M",
            Wing = 20,
            Tail = 40,
            Weight = 7,
            DateTime = new DateTime(2020, 01, 03)
        };

        var results = processor.Process(new[] { birdRecord1 , birdRecord2}).ToList();

        Assert.IsNotNull(results);
        Assert.AreEqual(2, results.Count);

        Assert.AreEqual(1, results[0].Id);
        Assert.AreEqual("AAA.BBB", results[0].SpeciesCode);
        Assert.AreEqual("F", results[0].Sex);
        Assert.AreEqual(10, results[0].Wing);
        Assert.AreEqual(20, results[0].Tail);
        Assert.AreEqual(5, results[0].Weight);
        Assert.AreEqual(new DateTime(2020, 01, 02), results[0].DateTime);
        Assert.AreEqual(15, results[0].WingPopulationMean);
        Assert.AreEqual((double)7.071M, (double)results[0].WingPopulationStandardDeviation, 0.001);
        Assert.AreEqual(30, results[0].TailPopulationMean);
        Assert.AreEqual(14.142, (double)results[0].TailPopulationStandardDeviation, 0.001);
        Assert.AreEqual(6, results[0].WeightPopulationMean);
        Assert.AreEqual(1.4142, (double)results[0].WeightPopulationStandardDeviation, 0.001);

        Assert.AreEqual(2, results[1].Id);
        Assert.AreEqual("AAA.BBB", results[1].SpeciesCode);
        Assert.AreEqual("M", results[1].Sex);
        Assert.AreEqual(20, results[1].Wing);
        Assert.AreEqual(40, results[1].Tail);
        Assert.AreEqual(7, results[1].Weight);
        Assert.AreEqual(new DateTime(2020, 01, 03), results[1].DateTime);
        Assert.AreEqual(15, results[1].WingPopulationMean);
        Assert.AreEqual((double)7.071M, (double)results[1].WingPopulationStandardDeviation, 0.001);
        Assert.AreEqual(30, results[1].TailPopulationMean);
        Assert.AreEqual(14.142, (double)results[1].TailPopulationStandardDeviation, 0.001);
        Assert.AreEqual(6, results[1].WeightPopulationMean);
        Assert.AreEqual(1.4142, (double)results[1].WeightPopulationStandardDeviation, 0.001);
    }

    [TestMethod]
    public void CalculateForEachSpeciesSeparately()
    {

        var birdRecord1 = new BirdRecord
        {
            Id = 1,
            SpeciesCode = "AAA.BBB",
            Sex = "F",
            Wing = 10,
            Tail = 20,
            Weight = 5,
            DateTime = new DateTime(2020, 01, 02)
        };

        var birdRecord2 = new BirdRecord
        {
            Id = 2,
            SpeciesCode = "AAA.BBB",
            Sex = "M",
            Wing = 20,
            Tail = 40,
            Weight = 7,
            DateTime = new DateTime(2020, 01, 03)
        };

        var birdRecord3 = new BirdRecord
        {
            Id = 3,
            SpeciesCode = "BBB.CCC",
            Sex = "M",
            Wing = 30,
            Tail = 50,
            Weight = 50,
            DateTime = new DateTime(2020, 01, 04)
        };

        var birdRecord4 = new BirdRecord
        {
            Id = 4,
            SpeciesCode = "BBB.CCC",
            Sex = "M",
            Wing = 50,
            Tail = 100,
            Weight = 80,
            DateTime = new DateTime(2020, 01, 05)
        };

        var results = processor.Process(new[] { birdRecord1, birdRecord2 , birdRecord3, birdRecord4}).ToList();

        Assert.IsNotNull(results);
        Assert.AreEqual(4, results.Count);

        Assert.AreEqual(1, results[0].Id);
        Assert.AreEqual(15, results[0].WingPopulationMean);
        Assert.AreEqual((double)7.071M, (double)results[0].WingPopulationStandardDeviation, 0.001);
        Assert.AreEqual(30, results[0].TailPopulationMean);
        Assert.AreEqual(14.142, (double)results[0].TailPopulationStandardDeviation, 0.001);
        Assert.AreEqual(6, results[0].WeightPopulationMean);
        Assert.AreEqual(1.4142, (double)results[0].WeightPopulationStandardDeviation, 0.001);

        Assert.AreEqual(2, results[1].Id);
        Assert.AreEqual(15, results[1].WingPopulationMean);
        Assert.AreEqual((double)7.071M, (double)results[1].WingPopulationStandardDeviation, 0.001);
        Assert.AreEqual(30, results[1].TailPopulationMean);
        Assert.AreEqual(14.142, (double)results[1].TailPopulationStandardDeviation, 0.001);
        Assert.AreEqual(6, results[1].WeightPopulationMean);
        Assert.AreEqual(1.4142, (double)results[1].WeightPopulationStandardDeviation, 0.001);

        
        Assert.AreEqual(3, results[2].Id);
        Assert.AreEqual(40, results[2].WingPopulationMean);
        Assert.AreEqual((double)14.142, (double)results[2].WingPopulationStandardDeviation, 0.001);
        Assert.AreEqual(75, results[2].TailPopulationMean);
        Assert.AreEqual(35.355, (double)results[2].TailPopulationStandardDeviation, 0.001);
        Assert.AreEqual(65, results[2].WeightPopulationMean);
        Assert.AreEqual(21.213, (double)results[2].WeightPopulationStandardDeviation, 0.001);

        Assert.AreEqual(4, results[3].Id);
        Assert.AreEqual(40, results[3].WingPopulationMean);
        Assert.AreEqual((double)14.142, (double)results[3].WingPopulationStandardDeviation, 0.001);
        Assert.AreEqual(75, results[3].TailPopulationMean);
        Assert.AreEqual(35.355, (double)results[3].TailPopulationStandardDeviation, 0.001);
        Assert.AreEqual(65, results[3].WeightPopulationMean);
        Assert.AreEqual(21.213, (double)results[3].WeightPopulationStandardDeviation, 0.001);
    }

    [TestMethod]
    public void EmptyRecordTest()
    {
        var record = new BirdRecord();

        var results = processor.Process(new[] { record }).ToList();

        Assert.AreEqual(1, results.Count);
    }
}