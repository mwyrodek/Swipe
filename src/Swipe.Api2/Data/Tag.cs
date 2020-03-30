using System;

namespace Swipe.Api.Data
{
    [Flags]
    public enum Tag
    {
        None = 0,
        Testing = 1,
        DevOps = 2,
        Automation=4,
        Programing=8,
        SoftwareCraftmanship = 16,
    }
}