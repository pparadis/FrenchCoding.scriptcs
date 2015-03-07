using System;

var uri = new Uri(Env.ScriptArgs[0]);

Console.WriteLine("AbsolutePath - " + uri.AbsolutePath);
Console.WriteLine("AbsoluteUri - " + uri.AbsoluteUri);
Console.WriteLine("Authority - " + uri.Authority);
Console.WriteLine("DnsSafeHost - " + uri.DnsSafeHost);
Console.WriteLine("Fragment - " + uri.Fragment);
Console.WriteLine("Host - " + uri.Host);
Console.WriteLine("HostNameType - " + uri.HostNameType);
Console.WriteLine("IsAbsoluteUri - " + uri.IsAbsoluteUri);
Console.WriteLine("IsDefaultPort - " + uri.IsDefaultPort);
Console.WriteLine("IsFile - " + uri.IsFile);
Console.WriteLine("IsLoopback - " + uri.IsLoopback);
Console.WriteLine("IsUnc - " + uri.IsUnc);
Console.WriteLine("LocalPath - " + uri.LocalPath);
Console.WriteLine("PathAndQuery - " + uri.PathAndQuery);
Console.WriteLine("Port - " + uri.Port);
Console.WriteLine("Query - " + uri.Query);
Console.WriteLine("Scheme - " + uri.Scheme);

foreach(var segment in uri.Segments)
{
    Console.WriteLine("Segment - " + segment);
}

Console.WriteLine("UserInfo - " + uri.UserInfo);

Console.ReadKey();
