using System.Collections.Generic;

namespace DemoLibrary.Interface
{
    public interface IDVD : ILibraryItem
    {
        int RunTimeInMinutes { get; set; }
        List<string> Actors { get; set; }
    }
}
