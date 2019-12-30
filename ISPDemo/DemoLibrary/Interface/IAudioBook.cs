using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Interface
{
    public interface IAudioBook : ILibraryItem
    {
        int RunTimeInMinutes { get; set; }

    }
}
