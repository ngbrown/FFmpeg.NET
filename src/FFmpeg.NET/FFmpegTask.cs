namespace FFmpeg.NET
{
    internal enum FFmpegTask
    {
        NotDefined = 0,
        Convert,
        GetMetaData,
        GetThumbnail,
        SingleInputCustom,
        CustomArguments,
    }
}