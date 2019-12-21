using System;
using Mp3Cutter.Extensibility.Dto;

namespace Mp3Cutter.Extensibility
{
    public interface IMp3Cutter
    {
        Mp3OutputDto ExecuteCut(Mp3InputDto mp3InputDto);
    }
}