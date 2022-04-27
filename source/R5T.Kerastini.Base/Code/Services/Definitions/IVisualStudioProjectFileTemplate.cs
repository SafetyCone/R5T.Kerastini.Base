using System;

using R5T.Gloucester.Types;using R5T.T0064;


namespace R5T.Kerastini
{[ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileTemplate:IServiceDefinition
    {
        ProjectFile Generate();
    }
}
