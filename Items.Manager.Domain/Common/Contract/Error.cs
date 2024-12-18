﻿namespace Items.Manager.Domain.Common.Contract;

public record Error(string Code, string Name)
{
    public static Error None = new(string.Empty, string.Empty);

    public static Error NullValue = new("Error.NullValue", "Null value was provided");

    public static Error NotFound = new("Error.NotFound", "Item not found");

    public static Error Concurrency = new("Error.Concurrency", "Item is not valid, try again");
}
