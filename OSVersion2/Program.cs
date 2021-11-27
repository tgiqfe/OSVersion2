using OSVersion2.Windows;
using OSVersion2;

var _1903 = OSVersion2.Windows.Windows10.Create1903(OSVersion2.Windows.Edition.Home);
var _2004 = OSVersion2.Windows.Windows10.Create2004(OSVersion2.Windows.Edition.Home);

Console.WriteLine("イコール: {0}", _1903 == _2004);
Console.WriteLine("ノットイコール: {0}", _1903 != _2004);
Console.WriteLine("大なり: {0}", _1903 > _2004);
Console.WriteLine("小なり: {0}", _1903 < _2004);
Console.WriteLine("大なりイコール: {0}", _1903 >= _2004);
Console.WriteLine("小なりイコール: {0}", _1903 <= _2004);
Console.WriteLine("--------");

var info = OSVersion2.OSVersion.GetCurrent();
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