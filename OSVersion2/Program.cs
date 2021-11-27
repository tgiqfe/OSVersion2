// See https://aka.ms/new-console-template for more information

var _1903 = OSVersion2.Windows.Windows10.Create1903(OSVersion2.Windows.Edition.Home);
var _2004 = OSVersion2.Windows.Windows10.Create2004(OSVersion2.Windows.Edition.Home);

Console.WriteLine("イコール: {0}", _1903 == _2004);
Console.WriteLine("ノットイコール: {0}", _1903 != _2004);
Console.WriteLine("大なり: {0}", _1903 > _2004);
Console.WriteLine("小なり: {0}", _1903 < _2004);
Console.WriteLine("大なりイコール: {0}", _1903 >= _2004);
Console.WriteLine("小なりイコール: {0}", _1903 <= _2004);



Console.WriteLine("Hello, World!");

Console.ReadLine();