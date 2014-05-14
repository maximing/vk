﻿namespace VkApiGenerator.Utils
{
    public class Template
    {
        public static readonly string ThrowIfNumberIsNegative = "VkErrors.ThrowIfNumberIsNegative(() => {0});";

        public static readonly string Method = @"public @Raw(@Model.ReturnType) @(Model.Name)(@Model.Params)
{
@Raw(@Model.Check)
@Raw(@Model.ParamsDefinition)

    @Raw(@Model.Invoke)

    @Raw(@Model.Return)
}";
    }
}