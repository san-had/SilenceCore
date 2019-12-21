using System;
using Mp3Cutter.Extensibility.Dto;
using Mp3Cutter.Service;

namespace Mp3Cutter.Console
{
    internal class Program
    {
        private static void Main()
        {
            var mp3InputDto = new Mp3InputDto
            {
                BeginCut = 0,
                EndCut = 1,
                Mp3Path = @"D:\mp3\20191215_ori.mp3"
            };

            var mp3Cutter = new Service.Mp3Cutter();

            var mp3OutputDto = mp3Cutter.ExecuteCut(mp3InputDto);

            System.Console.WriteLine(mp3OutputDto.Mp3OutputFileName);
        }
    }
}