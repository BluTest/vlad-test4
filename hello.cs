using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

public void test(string CmdName)
{
    new BinaryFormatter();
}

public void call(string CmdName)
{
    y = Process.Start(CmdName);
}

public void call(string CmdName2)
{
    y = Process.Start(CmdName2);
}
