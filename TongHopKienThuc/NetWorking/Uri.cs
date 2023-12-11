public static void ShowUriInfo(string url) {
    Uri uri = new Uri(url);
    Console.WriteLine(url);
    Console.WriteLine($"Scheme   : {uri.Scheme}");
    Console.WriteLine($"Host     : {uri.Host}");
    Console.WriteLine($"Port     : {uri.Port}");
    Console.WriteLine($"Fragment : {uri.Fragment}");
    Console.WriteLine($"Query    : {uri.Query}");
    Console.WriteLine($"Path     : {uri.LocalPath}");
    foreach (var seg in uri.Segments)
        Console.WriteLine($"           {seg}");
    /*
    https://xuanthulab.net/abc/testpate.html?read=1#testfragment
    Scheme   : https
    Host     : xuanthulab.net
    Port     : 443
    Fragment : #testfragment
    Query    : ?read=1
    Path     : /abc/testpate.html
            /
            abc/
            testpate.html
    */
}

public static void BuildUriExample() {
    UriBuilder uriBuilder = new UriBuilder();
    uriBuilder.Host = "xuanthulab.net";
    uriBuilder.Port = 80;
    uriBuilder.Path = "path/to/site";
    uriBuilder.Query = "lession=1";
    uriBuilder.Fragment = "xyz";
    Uri uri = uriBuilder.Uri;
    Console.WriteLine(uri);
    // http://xuanthulab.net/path/to/site?lession=1#xyz
}