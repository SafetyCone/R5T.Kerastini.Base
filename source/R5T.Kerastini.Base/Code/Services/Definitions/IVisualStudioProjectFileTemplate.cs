using System;

using R5T.Gloucester.Types;


namespace R5T.Kerastini
{
    public interface IVisualStudioProjectFileTemplate
    {
        ProjectFile Generate();
    }
}
