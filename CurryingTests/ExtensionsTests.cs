namespace Currying.Tests;

[TestClass()]
public class ExtensionsTests
{
    [TestMethod]
    public void PipeTest()
    {
        int i = 0;
        var add = (int i, int j) => i + j;
        var addBy10 = (int i) => add(i, 10);
        var square = (int i) => i * i;

        var res = i.Pipe(addBy10, square);
        Assert.AreEqual((i + 10) * 10, res);
    }
    [TestMethod()]
    public void PipeTest2()
    {
        int i = 0;
        var add = (int i, int j) => i + j;
        var addBy10 = i.Pipe(add, 10);
        var square = (int i) => i * i;
        var res = addBy10.Pipe(square);
        Assert.AreEqual((i + 10) * 10, res);
    }
    [TestMethod]
    public void PipeTest3()
    {
        int i = 0;
        var add = (int j) =>
        {
            i += j;
        };
        var square = (int j) =>
        {
            i = j * j;
        };
        10.Pipe(add, square);
        Assert.AreEqual(100, i);
    }
    [TestMethod]
    public void PipeTest4()
    {
        var getList = () => new int[] { 1, 2, 3, 4 };
        var res = getList().Sum().Pipe(p => p * 10, p => p / 100);
        Assert.AreEqual(1, res);
    }
    
    [TestMethod]
    public void OperatorRightShift_InvokesFunction()
    {
        Func<string, int> parse = s => int.Parse(s);
        Func<int, int> squareIt = x => x * x;
        var result = squareIt >> (parse >> "12");
        Assert.AreEqual(144, result);
    }
    [TestMethod]
    public void OperatorRighttShift_Combined_InvokesFunction()
    {
        Func<string, int> parse = s => int.Parse(s);
        Func<int, int> squareIt = x => x * x;

        var result = ("12" >> parse) >> squareIt;
        var result2 = squareIt >> ("12" >> parse);
        Assert.AreEqual(144, result);
        Assert.AreEqual(result2, result);
    }

    [TestMethod]
    public void OperatorRightShift_WithComplexType()
    {
        Func<int, string> toString = i => $"Value:{i}";
        Func<string, string> appendExclamation = s => s + "!";
        var result = appendExclamation >> (toString >> 7);
        Assert.AreEqual("Value:7!", result);
    }
    [TestMethod]
    public void ForwardCompose_InvokesFunction()
    {
        Func<int, int> squareIt = x => x * x;
        Func<int, string> toString = i => $"Value:{i}";
        Func<string, string> appendExclamation = s => s +"!";
        var sqToExclammation = squareIt >> toString >> appendExclamation;
        var result = sqToExclammation >> 5;
        Assert.AreEqual("Value:25!", result);
        var result2 = squareIt >> toString >> appendExclamation >> 5;
        Assert.AreEqual(result, result2);
        var result3 =  5 >> squareIt >> toString >> appendExclamation;
        Assert.AreEqual(result, result3);
    }
    [TestMethod]
    public void BackwardCompose_InvokesFunction()
    {
        Func<int, int> squareIt = x => x * x;
        Func<int, string> toString = i => $"Value:{i}";
        Func<string, string> appendExclamation = s => s + "!";
        var sqToExclammation = appendExclamation << toString << squareIt;
        var result = sqToExclammation >> 5;
        Assert.AreEqual("Value:25!", result);
    }
    [TestMethod]
    public void ForwardComposeZeroArg_InvokesFunction()
    {
        Func<string> dateString = () => DateTime.Today.ToString("yyyy-MM-dd");
        Func<int, int> squareIt = x => x * x;
        Func<int, string> toString = i => $"Value:{i}";
        Func<string, string> appendExclamation = s => s + "!";
        var composeFromZeroArg = dateString >> appendExclamation;
        Assert.AreEqual(DateTime.Today.ToString("yyyy-MM-dd") + "!", composeFromZeroArg());
    }
    [TestMethod]
    public void ComposeZeroArg_InvokesFunction()
    {
        var bom = new Table("BOM", new Dictionary<string, string> { ["Part1"] = "Value1", ["Part2"] = "Value2", ["Part3"] = "Value3" });
        //Func<Table, (Table tbl, string col)> ColOf = tbl => (tbl, );
        Func<(Table tbl, string col, string value), Table> filterOn = (args) => args.tbl;
        //Func<(Table tbl, string col, string value), Table> filterOn = (args) => args.tbl;

        Func<(Table tbl, string col), List<string>> select = (args) => args.tbl.Columns.Values.Where(v => v.EndsWith(args.col)).ToList();
        Func<Table, List<string>> selectMC = (args) => args.Columns.Where(v => v.Key.StartsWith("MC")).Select(p => p.Value).ToList();

        Func<List<string>, string> sumup = (cols) => string.Join(",", cols);
        var composed = filterOn >> selectMC >> sumup;
        var composed2 = ((bom, "MC", "C") >> filterOn, "PHR") >> select >> sumup;
        //x >> y >> func is equivalent to func(y(x))
        //tbl >> withCol >> value >> filteron;
    }
    public record Table(string Name, Dictionary<string, string > Columns);
}