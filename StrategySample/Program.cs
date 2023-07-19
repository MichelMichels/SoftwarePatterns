using StrategySample;

StringEditor stringEditor = new(new LowercaseStrategy());

Console.WriteLine($"Input value is 'TEST': result = {stringEditor.Execute("TEST")}");

stringEditor.SetStrategy(new UppercaseStrategy());

Console.WriteLine($"Input values is 'test', result = {stringEditor.Execute("test")}");