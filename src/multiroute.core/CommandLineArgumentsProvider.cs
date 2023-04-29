﻿namespace multiroute.core;

public interface ICommandLineArgumentsProvider
{
    string[] GetCommandLineArguments();
}

public class CommandLineArgumentsProvider : ICommandLineArgumentsProvider
{
    public string[] GetCommandLineArguments()
    {
        var args = Environment.GetCommandLineArgs();
        return args.ToArray();
    }
}