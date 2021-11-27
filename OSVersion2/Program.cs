using OSVersion2.OS.Windows;
using OSVersion2.OS;

var _1903 = Windows10.Create1903(Edition.Home);
var _2004 = Windows10.Create2004(Edition.Home);

Console.WriteLine("イコール: {0}", _1903 == _2004);
Console.WriteLine("ノットイコール: {0}", _1903 != _2004);
Console.WriteLine("大なり: {0}", _1903 > _2004);
Console.WriteLine("小なり: {0}", _1903 < _2004);
Console.WriteLine("大なりイコール: {0}", _1903 >= _2004);
Console.WriteLine("小なりイコール: {0}", _1903 <= _2004);
Console.WriteLine("--------");

var info = OSVersion.GetCurrent();
Console.WriteLine(info);
Console.WriteLine("--------");

OSInfoCollection collection = new OSInfoCollection();
collection.LoadDefault();
foreach (var osInfo in collection)
{
    Console.WriteLine(osInfo);
}



Console.WriteLine("Hello, World!");

Console.ReadLine();